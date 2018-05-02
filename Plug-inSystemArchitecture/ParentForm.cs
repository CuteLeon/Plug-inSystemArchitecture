using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Plug_inTemplate;

namespace Plug_inSystemArchitecture
{
    public partial class ParentForm : Form
    {
        private Dictionary<string, TemplateClass> Plugins = new Dictionary<string, TemplateClass>();

        private readonly string PluginsDirectory = Application.StartupPath + @"\Plugins";

        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void ParentForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            foreach (TemplateClass PluginInstance in PluginController.GetPlugins(PluginsDirectory))
            {
                PluginListBox.Items.Add(string.Format("{0} ({1})", PluginInstance.Name, PluginInstance.Description));
                Plugins.Add(PluginInstance.Name +"-"+ PluginInstance.GetHashCode(), PluginInstance);
                PluginInstance.Initialize();

                if (PluginInstance.MainControl != null)
                    PluginLayoutPanel.Controls.Add(PluginInstance.MainControl);
                if (PluginInstance.MainForm != null)
                    PluginInstance.MainForm.ShowDialog();
            }
        }
    }
}
