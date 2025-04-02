using System.Runtime.InteropServices;
using System.Text;
using decoder;

namespace Base64ClipboardDecoder
{
    public partial class ClipBoardViewer : BaseForm
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
            get { return DisableMenuStripMenuItem; }
        }

        public ClipBoardViewer()
        {
            InitializeComponent();
            this.Load += ClipboardViewer_Load;

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
            if (!IsDisabled && Clipboard.ContainsText() && !string.IsNullOrWhiteSpace(Clipboard.GetText()) && IsBase64String(Clipboard.GetText()))
            {
                string text = Clipboard.GetText();

                ConvertToTxt(text, out string decodedText);

                if (!string.IsNullOrEmpty(decodedText))
                {
                    Clipboard.SetText(decodedText);
                }

                AddClipboardTextToHistory(text);
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
            history.Items.Clear();
            foreach (var item in clipboardHistory)
            {
                history.Items.Add(item);
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            NotifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void ClipBoardViewer_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                NotifyIcon.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                NotifyIcon.Visible = false;
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal)
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            IsDisabled = !IsDisabled;
        }

        private void ClearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clipboardHistory.Count == 0)
            {
                MessageBox.Show("History is empty.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clipboardHistory.Clear();
                UpdateClipboardList();
                MessageBox.Show("History cleared successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ConvertToTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (history.Items.Count == 0)
            {
                MessageBox.Show("Select item first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ConvertHistoryItems();

            var menuItem = sender as ToolStripMenuItem;
            UpdateMenuItemText(menuItem, convertToTxt, convertToBase64);
        }

        private void CopySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = history.SelectedItem;

            if (history.SelectedItem is null)
            {
                MessageBox.Show("Select item first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Clipboard.SetText(selectedItem.ToString());
            }
        }

        private void ConvertHistoryItems()
        {
            var clipboardHistoryTmp = history.Items.Cast<string>().ToList();
            history.Items.Clear();

            var formatFunc = currentFormat == format.base54
                ? (Func<string, string>)((item) => Encoding.UTF8.GetString(Convert.FromBase64String(item)))
                : (Func<string, string>)((item) => Convert.ToBase64String(Encoding.UTF8.GetBytes(item)));

            foreach (var item in clipboardHistoryTmp)
            {
                try
                {
                    history.Items.Add(formatFunc(item));
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

        private void AppStatusChanged()
        {
            List<ToolStripMenuItem> menuItems =
            [
                DisableMenuStripMenuItem,
                DisableToolStripMenuItem
            ];

            foreach (ToolStripMenuItem menuItem in menuItems)
            {
                menuItem.Text = isDisabled ? enabled : disabled;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new();
            af.ShowDialog();
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();

            if (history.SelectedItem is null)
            {
                MessageBox.Show("Select item first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportAsFile(history.SelectedItem.ToString(), sfd.FileName);
                MessageBox.Show("File saved successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClipBoardViewer_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void EditSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (history.SelectedItem is null)
            {
                MessageBox.Show("Select item first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!string.IsNullOrEmpty(history.SelectedItem.ToString()))
            {
                EditItemForm eif = new(history.SelectedItem.ToString());
                eif.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select item first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ClearClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                MessageBox.Show("Clipboard was cleared successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.Clear();
            }
            else
            {
                MessageBox.Show("Clipboard is empty.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsDisabled = !IsDisabled;
        }

        private void DisableMenuStrip_Click(object sender, EventArgs e)
        {
            IsDisabled = !IsDisabled;
        }

        private void ExitContextMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
