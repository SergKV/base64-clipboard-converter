using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Base64ClipboardDecoder
{
    public partial class ClipBoardViewer : Form
    {
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

        private void lstClipboardHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            clipboardHistory.Clear();
            UpdateClipboardList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = checkBox1.Checked;
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
