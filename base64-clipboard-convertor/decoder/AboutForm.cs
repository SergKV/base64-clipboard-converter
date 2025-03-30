using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decoder
{
    public partial class AboutForm : Form
    {
        private static string sourceUrl = "https://github.com/SergKV/base64-clipboard-convertor/";

        private Point mouseLocation;

        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = sourceUrl,
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
