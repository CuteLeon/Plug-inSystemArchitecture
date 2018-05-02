using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Plug_inTemplate;

namespace Plug_inComponentDemo
{
    public class PluginDemoClass1 : TemplateClass
    {
        public PluginDemoClass1()
        {
            //数据初始化要放在构造函数内
            Name = "演示插件 - Leon";
            Description = "这是一个演示的插件。";

            this.MainControl = new UserControl1();
        }
         
        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void Hide()
        {
            throw new NotImplementedException();
        }

        public override void Initialize()
        {
            //MessageBox.Show(string.Format( "Name : {0}\nDescription : {1}", Name,Description));
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }
        


    }
}
