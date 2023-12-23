namespace LidActionChanger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dCModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doNothingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hibernateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aCModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doNothingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hibernateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openPowerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripContainer1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dCModeToolStripMenuItem,
            this.aCModeToolStripMenuItem,
            this.openPowerSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(312, 200);
            // 
            // dCModeToolStripMenuItem
            // 
            this.dCModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doNothingToolStripMenuItem1,
            this.sleepToolStripMenuItem1,
            this.hibernateToolStripMenuItem1,
            this.shutdownToolStripMenuItem1});
            this.dCModeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dCModeToolStripMenuItem.Name = "dCModeToolStripMenuItem";
            this.dCModeToolStripMenuItem.Size = new System.Drawing.Size(311, 38);
            this.dCModeToolStripMenuItem.Text = "DC Mode";
            // 
            // doNothingToolStripMenuItem1
            // 
            this.doNothingToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.doNothingToolStripMenuItem1.Name = "doNothingToolStripMenuItem1";
            this.doNothingToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.doNothingToolStripMenuItem1.Text = "Do Nothing";
            this.doNothingToolStripMenuItem1.Click += new System.EventHandler(this.doNothingToolStripMenuItem1_Click);
            // 
            // sleepToolStripMenuItem1
            // 
            this.sleepToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sleepToolStripMenuItem1.Name = "sleepToolStripMenuItem1";
            this.sleepToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.sleepToolStripMenuItem1.Text = "Sleep";
            this.sleepToolStripMenuItem1.Click += new System.EventHandler(this.sleepToolStripMenuItem1_Click);
            // 
            // hibernateToolStripMenuItem1
            // 
            this.hibernateToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hibernateToolStripMenuItem1.Name = "hibernateToolStripMenuItem1";
            this.hibernateToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.hibernateToolStripMenuItem1.Text = "Hibernate";
            this.hibernateToolStripMenuItem1.Click += new System.EventHandler(this.hibernateToolStripMenuItem1_Click);
            // 
            // shutdownToolStripMenuItem1
            // 
            this.shutdownToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.shutdownToolStripMenuItem1.Name = "shutdownToolStripMenuItem1";
            this.shutdownToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.shutdownToolStripMenuItem1.Text = "Shutdown";
            this.shutdownToolStripMenuItem1.Click += new System.EventHandler(this.shutdownToolStripMenuItem1_Click);
            // 
            // aCModeToolStripMenuItem
            // 
            this.aCModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doNothingToolStripMenuItem2,
            this.sleepToolStripMenuItem2,
            this.hibernateToolStripMenuItem2,
            this.shutdownToolStripMenuItem2});
            this.aCModeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aCModeToolStripMenuItem.Name = "aCModeToolStripMenuItem";
            this.aCModeToolStripMenuItem.Size = new System.Drawing.Size(311, 38);
            this.aCModeToolStripMenuItem.Text = "AC Mode";
            // 
            // doNothingToolStripMenuItem2
            // 
            this.doNothingToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.doNothingToolStripMenuItem2.Name = "doNothingToolStripMenuItem2";
            this.doNothingToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.doNothingToolStripMenuItem2.Text = "Do Nothing";
            this.doNothingToolStripMenuItem2.Click += new System.EventHandler(this.doNothingToolStripMenuItem2_Click);
            // 
            // sleepToolStripMenuItem2
            // 
            this.sleepToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sleepToolStripMenuItem2.Name = "sleepToolStripMenuItem2";
            this.sleepToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.sleepToolStripMenuItem2.Text = "Sleep";
            this.sleepToolStripMenuItem2.Click += new System.EventHandler(this.sleepToolStripMenuItem2_Click);
            // 
            // hibernateToolStripMenuItem2
            // 
            this.hibernateToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hibernateToolStripMenuItem2.Name = "hibernateToolStripMenuItem2";
            this.hibernateToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.hibernateToolStripMenuItem2.Text = "Hibernate";
            this.hibernateToolStripMenuItem2.Click += new System.EventHandler(this.hibernateToolStripMenuItem2_Click);
            // 
            // shutdownToolStripMenuItem2
            // 
            this.shutdownToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.shutdownToolStripMenuItem2.Name = "shutdownToolStripMenuItem2";
            this.shutdownToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.shutdownToolStripMenuItem2.Text = "Shutdown";
            this.shutdownToolStripMenuItem2.Click += new System.EventHandler(this.shutdownToolStripMenuItem2_Click);
            // 
            // openPowerSettingsToolStripMenuItem
            // 
            this.openPowerSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openPowerSettingsToolStripMenuItem.Name = "openPowerSettingsToolStripMenuItem";
            this.openPowerSettingsToolStripMenuItem.Size = new System.Drawing.Size(311, 38);
            this.openPowerSettingsToolStripMenuItem.Text = "Open Power Settings";
            this.openPowerSettingsToolStripMenuItem.Click += new System.EventHandler(this.openPowerSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(311, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Lid Action Changer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1342, 906);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem dCModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doNothingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sleepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hibernateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aCModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doNothingToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sleepToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hibernateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPowerSettingsToolStripMenuItem;
    }
}

