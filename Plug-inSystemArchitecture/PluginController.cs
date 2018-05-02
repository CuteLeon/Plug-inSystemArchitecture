using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Plug_inTemplate;

namespace Plug_inSystemArchitecture
{
    public static class PluginController
    {
        //TODO : yeid return

        /// <summary>
        /// 扫描指定插件目录内插件动态链接库
        /// </summary>
        /// <param name="PluginsDirectory">插件目录</param>
        /// <returns></returns>
        public static List<TemplateClass> GetPlugins(string PluginsDirectory)
        {
            Debug.Print("扫描插件目录 : {0}", PluginsDirectory);
            List<TemplateClass> PluginInstanceList = new List<TemplateClass>();

            foreach (string PluginPath in Directory.GetFiles(PluginsDirectory))
            {
                if (!PluginPath.ToLower().EndsWith(".dll")) continue;
                Debug.Print("————————————————");
                Debug.Print("发现插件链接库文件 : {0}", PluginPath);

                try
                {
                    foreach (TemplateClass PluginInstance in CreatePluginInstance(PluginPath))
                    {
                        PluginInstanceList.Add(PluginInstance);
                    }
                }
                catch (Exception ex)
                {
                    Debug.Print("加载插件遇到异常：{0}", ex.Message);
                }
            }

            return PluginInstanceList;
        }

        /// <summary>  
        /// 根据全名和路径构造对象  
        /// </summary>  
        /// <param name="PluginPath">插件链接库文件路径</param>
        /// <param name="DynamicLoad">在内存中动态热加载</param>
        /// <returns></returns>  
        public static IEnumerable<TemplateClass> CreatePluginInstance(string PluginPath, bool DynamicLoad = true)
        {
            Debug.Print("开始创建实例 {0}...", DynamicLoad ? "(动态模式) " : string.Empty);
            //List<TemplateClass> PluginInstanceList = new List<TemplateClass>();
            Assembly AssemblyObject = null;

            try
            {
                if (!DynamicLoad)
                {
                    // 从链接库文件路径加载
                    AssemblyObject = Assembly.LoadFrom(PluginPath);
                }
                else
                {
                    // 把链接库文件读入内存后从内存加载，允许程序在运行时更新链接库
                    using (FileStream PluginStream = new FileStream(PluginPath, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader PluginReader = new BinaryReader(PluginStream))
                        {
                            byte[] PluginBuffer = PluginReader.ReadBytes((int)PluginStream.Length);
                            AssemblyObject = Assembly.Load(PluginBuffer);
                            PluginReader.Close();
                        }
                        PluginStream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print("创建程序集遇到异常：{0}", ex.Message);
                throw ex;
            }

            if (AssemblyObject == null) throw new Exception("无法加载链接库文件 : " + PluginPath);

            foreach (Type PluginType in AssemblyObject.GetTypes())
            {
                Debug.Print("发现类型 : {0}", PluginType.FullName);

                // 仅加载TemplateClass类型派生的子类
                if (!PluginType.IsSubclassOf(typeof(TemplateClass))) continue;
                Debug.Print(">>> 可加载的插件类型 : {0}", PluginType.FullName);
                //创建并添加可加载类型的实例
                TemplateClass PluginInstance = null;
                try
                {
                    PluginInstance = AssemblyObject.CreateInstance(PluginType.FullName) as TemplateClass;
                    //PluginInstanceList.Add(PluginInstance);
                }
                catch (Exception ex)
                {
                    Debug.Print("创建 {0} 类型实例遇到异常 : {1}",PluginType.FullName, ex.Message);
                    continue;
                }
                yield return PluginInstance;
            }

            //return PluginInstanceList;
        }

    }
}
