namespace Plug_inSystemArchitecture
{
    partial class ParentForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.PluginListBox = new System.Windows.Forms.ListBox();
            this.PluginLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.PluginListBox);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.PluginLayoutPanel);
            this.MainSplitContainer.Size = new System.Drawing.Size(820, 497);
            this.MainSplitContainer.SplitterDistance = 200;
            this.MainSplitContainer.SplitterWidth = 2;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // PluginListBox
            // 
            this.PluginListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PluginListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginListBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PluginListBox.FormattingEnabled = true;
            this.PluginListBox.ItemHeight = 21;
            this.PluginListBox.Location = new System.Drawing.Point(0, 0);
            this.PluginListBox.Name = "PluginListBox";
            this.PluginListBox.Size = new System.Drawing.Size(200, 497);
            this.PluginListBox.TabIndex = 0;
            // 
            // PluginLayoutPanel
            // 
            this.PluginLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.PluginLayoutPanel.Name = "PluginLayoutPanel";
            this.PluginLayoutPanel.Size = new System.Drawing.Size(618, 497);
            this.PluginLayoutPanel.TabIndex = 0;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 497);
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "ParentForm";
            this.Text = "Parent Form";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.Shown += new System.EventHandler(this.ParentForm_Shown);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.ListBox PluginListBox;
        private System.Windows.Forms.FlowLayoutPanel PluginLayoutPanel;
    }
}

