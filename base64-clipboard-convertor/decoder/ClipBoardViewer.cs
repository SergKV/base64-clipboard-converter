using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Base64ClipboardDecoder
{
    public partial class ClipBoardViewer : Form
    {
        public Point mouseLocation;

        private List<string> clipboardHistory = new List<string>();

        private bool isChecked = true;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        public ClipBoardViewer()
        {
            InitializeComponent();
            this.Load += ClipboardViewer_Load;

            notifyIcon1.BalloonTipTitle = "Base64Convertor";
            notifyIcon1.BalloonTipText = "Convert";
            notifyIcon1.Text = "Base64Convertor";

            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClipboardViewer_Load(object sender, EventArgs e)
        {
            SetClipboardViewer(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0308) // WM_DRAWCLIPBOARD
            {
                OnClipboardUpdate();
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void OnClipboardUpdate()
        {
            if (Clipboard.ContainsText() && isChecked == true)
            {
                string text = Clipboard.GetText();

                try
                {
                    byte[] bytes = Convert.FromBase64String(text);
                    var decodedText = Encoding.UTF8.GetString(bytes);
                    Clipboard.SetText(decodedText);

                    AddClipboardTextToHistory(text);
                }
                catch (FormatException)
                {

                }
            }
        }

        private void AddClipboardTextToHistory(string text)
        {
            if (!clipboardHistory.Contains(text))
            {
                clipboardHistory.Insert(0, text);
                UpdateClipboardList();
            }
        }

        private void UpdateClipboardList()
        {
            History.Items.Clear();
            foreach (var item in clipboardHistory)
            {
                History.Items.Add(item);
            }
        }

        private void lstClipboardHistory_DoubleClick(object sender, EventArgs e)
        {
            if (History.SelectedItem != null)
            {
                Clipboard.SetText(History.SelectedItem.ToString());
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void ClipBoardViewer_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem != null)
            {
                isChecked = !isChecked;
                menuItem.Text = isChecked ? "Disable" : "Enable";
            }
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            clipboardHistory.Clear();
            UpdateClipboardList();
        }
    }
}
