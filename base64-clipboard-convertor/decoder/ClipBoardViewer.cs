using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using decoder;
using static System.Net.Mime.MediaTypeNames;

namespace Base64ClipboardDecoder
{
    public partial class ClipBoardViewer : Form
    {
        private const string convertToTxt = "Convert to txt";
        private const string convertToBase64 = "Convert to base64";
        private const string disabled = "Disable";
        private const string enabled = "Enable";

        public Point mouseLocation;

        private List<string> clipboardHistory = [];

        private format currentFormat = format.base54;

        private enum format
        {
            base54,
            txt
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        private bool isDisabled = false;

        public bool IsDisabled
        {
            get => isDisabled;

            set
            {
                if (isDisabled != value)
                {
                    isDisabled = value;
                    AppStatusChanged();
                }
            }
        }

        public ToolStripMenuItem deactivateMenuItem
        {
            get { return deactivateToolStripMenuItem; }
        }

        public ToolStripMenuItem toTxtMenuItem
        {
            get { return converToTxtToolStripMenuItem; }
        }

        public ToolStripMenuItem disableMenuItem
        {
            get { return disableToolStripMenuItem; }
        }

        public ClipBoardViewer()
        {
            InitializeComponent();
            this.Load += ClipboardViewer_Load;

            notifyIcon1.BalloonTipTitle = "Base64Convertor";
            notifyIcon1.BalloonTipText = "Convert";
            notifyIcon1.Text = "Base64Convertor";

            WindowState = FormWindowState.Minimized;
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
            if (Clipboard.ContainsText() && IsDisabled is false)
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
                UpdateMenuItemText(toTxtMenuItem, convertToTxt, convertToBase64);
            }

            if (IsBase64String(text))
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
            if (History.SelectedItem is not null)
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
            IsDisabled = !IsDisabled;
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

            var menuItem = sender as ToolStripMenuItem;

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

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsDisabled = !IsDisabled;
        }

        private void AppStatusChanged()
        {
            List<ToolStripMenuItem> menuItems =
            [
                disableToolStripMenuItem,
                deactivateMenuItem
            ];

            foreach (ToolStripMenuItem menuItem in menuItems)
            {
                menuItem.Text = isDisabled ? enabled : disabled;
            }
        }

        private bool IsBase64String(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length % 4 != 0 || !System.Text.RegularExpressions.Regex.IsMatch(text, @"^[a-zA-Z0-9\+/]*={0,2}$"))
            {
                return false;
            }

            try
            {
                Convert.FromBase64String(text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }
    }
}
