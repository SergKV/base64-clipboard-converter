using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace decoder
{
    public partial class EditItemForm : BaseForm
    {
        private string receivedData { get; set; }

        public Point mouseLocation;

        public EditItemForm(string text)
        {
            InitializeComponent();
            receivedData = text;

            if (IsBase64String(text))
            {
                ConvertToTxt(text, out string decodedText);
                itemTextBox.Text = decodedText;
            }
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void MouseDouble_Click(object sender, MouseEventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal)
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal)
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }
    }
}
