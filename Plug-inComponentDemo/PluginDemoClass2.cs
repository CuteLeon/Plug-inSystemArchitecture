using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plug_inTemplate;

namespace Plug_inComponentDemo
{
    class PluginDemoClass2 : TemplateClass
    {
        public PluginDemoClass2()
        {
            Name = "另一个演示插件";
            Description = "可以在一个DLL里设计多个插件，每个插件都是一个继承自 Plug-inTemplate.TemplateClass 的类。";
            this.MainForm = new Form1();
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
            
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
