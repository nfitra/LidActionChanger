using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LidActionChanger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            // Set Default to Sleep
            SetPowerSetting(0, 1);
            SetPowerSetting(1, 1);
            sleepToolStripMenuItem1.Checked = true;
            sleepToolStripMenuItem2.Checked = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                int x = Cursor.Position.X;
                int y = Cursor.Position.Y - notifyIcon.ContextMenuStrip.Height;

                x = Math.Max(0, x);
                y = Math.Max(0, y);

                notifyIcon.ContextMenuStrip.Show(new Point(x, y));
            }
        }

        // 0 - Do Nothing
        // 1 - Sleep
        // 2 - Hibernate
        // 3 - Shutdown
        private void SetPowerSetting(int mode, int settingValue)
        {
            string settingMode;
            if (mode == 0)
            {
                settingMode = "setdcvalueindex";
            }
            else
            {
                settingMode = "setacvalueindex";
            }

            Process process = new Process();
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            string args = $"-{settingMode} SCHEME_CURRENT 4f971e89-eebd-4455-a8de-9e59040e7347 5ca83367-6e45-459f-a27b-476b1d01c936 {settingValue}";

            process.StartInfo.FileName = "powercfg";
            process.StartInfo.Arguments = args;
            process.Start();
            process.StartInfo.Arguments = "-SetActive SCHEME_CURRENT";
            process.Start();
        }

        private void doNothingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetPowerSetting(0, 0);

            doNothingToolStripMenuItem1.Checked = true;
            sleepToolStripMenuItem1.Checked = false;
            hibernateToolStripMenuItem1.Checked = false;
            shutdownToolStripMenuItem1.Checked = false;
        }

        private void sleepToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetPowerSetting(0, 1);

            doNothingToolStripMenuItem1.Checked = false;
            sleepToolStripMenuItem1.Checked = true;
            hibernateToolStripMenuItem1.Checked = false;
            shutdownToolStripMenuItem1.Checked = false;
        }

        private void hibernateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetPowerSetting(0, 2);

            doNothingToolStripMenuItem1.Checked = false;
            sleepToolStripMenuItem1.Checked = false;
            hibernateToolStripMenuItem1.Checked = true;
            shutdownToolStripMenuItem1.Checked = false;
        }

        private void shutdownToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetPowerSetting(0, 3);

            doNothingToolStripMenuItem1.Checked = false;
            sleepToolStripMenuItem1.Checked = false;
            hibernateToolStripMenuItem1.Checked = false;
            shutdownToolStripMenuItem1.Checked = true;
        }

        private void doNothingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetPowerSetting(1, 0);

            doNothingToolStripMenuItem2.Checked = true;
            sleepToolStripMenuItem2.Checked = false;
            hibernateToolStripMenuItem2.Checked = false;
            shutdownToolStripMenuItem2.Checked = false;
        }

        private void sleepToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetPowerSetting(1, 1);

            doNothingToolStripMenuItem2.Checked = false;
            sleepToolStripMenuItem2.Checked = true;
            hibernateToolStripMenuItem2.Checked = false;
            shutdownToolStripMenuItem2.Checked = false;
        }

        private void hibernateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetPowerSetting(1, 2);

            doNothingToolStripMenuItem2.Checked = false;
            sleepToolStripMenuItem2.Checked = false;
            hibernateToolStripMenuItem2.Checked = true;
            shutdownToolStripMenuItem2.Checked = false;
        }

        private void shutdownToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetPowerSetting(1, 3);

            doNothingToolStripMenuItem2.Checked = false;
            sleepToolStripMenuItem2.Checked = false;
            hibernateToolStripMenuItem2.Checked = false;
            shutdownToolStripMenuItem2.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openPowerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe", "powercfg.cpl");
        }
    }
}
