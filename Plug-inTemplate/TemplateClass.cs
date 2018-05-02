using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plug_inTemplate
{
    public abstract class TemplateClass
    {
        /* ***** 模板向插件提供的数据 *****
         * 进程PID
         * 窗口标题
         * 窗体句柄
         */

        private string _name = string.Empty;
        /// <summary>
        /// 插件名称
        /// </summary>
        public string Name
        {
            get => _name;
            protected set => _name = value;
        }

        private string _description = string.Empty;
        /// <summary>
        /// 插件描述
        /// </summary>
        public string Description
        {
            get => _description;
            protected set => _description = value;
        }

        /// <summary>
        /// 插件控件
        /// </summary>
        public Control MainControl = null;

        /// <summary>
        /// 插件窗口
        /// </summary>
        public Form MainForm = null;

        /* ***** 方法 *****
         * 初始化
         * 显示
         * 隐藏
         * 清理释放
         */
         /// <summary>
         /// 初始化函数
         /// </summary>
        public abstract void Initialize();

        /// <summary>
        /// 显示函数
        /// </summary>
        public abstract void Show();

        /// <summary>
        /// 隐藏函数
        /// </summary>
        public abstract void Hide();

        /// <summary>
        /// 清理释放函数
        /// </summary>
        public abstract void Dispose();

    }
}
