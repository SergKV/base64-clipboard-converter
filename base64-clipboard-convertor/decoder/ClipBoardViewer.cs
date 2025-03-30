using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Base64ClipboardDecoder
{
    public partial class ClipBoardViewer : Form
    {
        public Point mouseLocation;

        ToolStripMenuItem menuItem;

        private List<string> clipboardHistory = new List<string>();

        private bool disabled = true;

        private format currentFormat = format.base54;

        private enum format
        {
            base54,
            txt
        }

        private string convertToTxt = "Convert to txt";
        private string convertToBase64 = "Convert to base64";

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
            if (Clipboard.ContainsText() && disabled == true)
            {
                string text = Clipboard.GetText();

                try
                {
                    byte[] bytes = Convert.FromBase64String(text);
                    var decodedText = Encoding.UTF8.GetString(bytes);

                    if (!string.IsNullOrEmpty(decodedText))
                    {
                        Clipboard.SetText(decodedText);
                    }

                    AddClipboardTextToHistory(text);
                }
                catch (FormatException)
                {

                }
            }
        }

        private void AddClipboardTextToHistory(string text)
        {
            if (clipboardHistory.Contains(text))
            {
                return;
            }

            if (currentFormat == format.txt)
            {
                ConvertHistoryItems();
                UpdateMenuItemText(menuItem, convertToTxt, convertToBase64);
            }

            clipboardHistory.Insert(0, text);
            UpdateClipboardList();
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
                disabled = !disabled;
                menuItem.Text = disabled ? "Disable" : "Enable";
            }
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            clipboardHistory.Clear();
            UpdateClipboardList();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Items.Count == 0)
            {
                return;
            }

            ConvertHistoryItems();

            menuItem = sender as ToolStripMenuItem;

            UpdateMenuItemText(menuItem, convertToTxt, convertToBase64);
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = History.SelectedItem;
            if (selectedItem != null)
            {
                Clipboard.SetText(selectedItem.ToString());
            }
        }

        private void ConvertHistoryItems()
        {
            var clipboardHistoryTmp = History.Items.Cast<string>().ToList();
            History.Items.Clear();
            var formatFunc = currentFormat == format.base54
                ? (Func<string, string>)((item) => Encoding.UTF8.GetString(Convert.FromBase64String(item)))
                : (Func<string, string>)((item) => Convert.ToBase64String(Encoding.UTF8.GetBytes(item)));
            foreach (var item in clipboardHistoryTmp)
            {
                try
                {
                    History.Items.Add(formatFunc(item));
                }
                catch { }
            }

            currentFormat = currentFormat == format.base54 ? format.txt : format.base54;
        }

        private void UpdateMenuItemText(ToolStripMenuItem menuItem, string convertToTxt, string convertToBase64)
        {
            if (menuItem != null)
            {
                menuItem.Text = menuItem.Text == convertToTxt ? convertToBase64 : convertToTxt;
            }
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
