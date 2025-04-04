using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base64ClipboardDecoder;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;

namespace decoder
{
    public partial class ucHistoryListView : BaseUserControl
    {
        private AppStatusEvent AppStatusEvent;

        private const string convertToTxt = "Convert to txt";
        private const string convertToBase64 = "Convert to base64";
        private const string disabled = "Disable";
        private const string enabled = "Enable";

        private ClipBoardItems clipboardHistory;

        private Format currentFormat = Format.Base54;

        private enum Format
        {
            Base54,
            Txt
        }

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

        public ucHistoryListView()
        {
            InitializeComponent();
            this.Load += ClipboardViewer_Load;

            clipboardHistory = new ClipBoardItems();

            AppStatusEvent = new AppStatusEvent();

            AppStatusEvent.appStatusEvent -= AppStatusEvent_AppStatusChanged;
            AppStatusEvent.appStatusEvent += AppStatusEvent_AppStatusChanged;
        }

        public ToolStripMenuItem toTxtMenuItem
        {
            get { return convertToTxtToolStripMenuItem; }
        }

        public ToolStripMenuItem disableMenuItem
        {
            get { return DisableToolStripMenuItem; }
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        private void ClipboardViewer_Load(object sender, EventArgs e)
        {
            SetClipboardViewer(this.Handle);
        }

        private void AppStatusEvent_AppStatusChanged(object? sender, AppStatusEvent e)
        {
            IsDisabled = !IsDisabled;
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppStatusEvent.appStatusEvent -= AppStatusEvent_AppStatusChanged;
            AppStatusEvent.appStatusEvent += AppStatusEvent_AppStatusChanged;
            AppStatusEvent.SendEventInfo(isDisabled);
        }

        private void AppStatusChanged()
        {
            disableMenuItem.Text = isDisabled ? enabled : disabled;
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

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clipBoardViewer = this.Parent as ClipBoardViewer;

            clipBoardViewer?.Close();
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

        private void ConvertHistoryItems()
        {
            history.Items.Clear();

            foreach (var item in clipboardHistory.List)
            {
                if (currentFormat == Format.Base54)
                {
                    history.Items.Add(item.Text);
                }
                else
                {
                    history.Items.Add(item.Base64);
                }
            }

            currentFormat = currentFormat == Format.Base54 ? Format.Txt : Format.Base54;
        }

        private void UpdateMenuItemText(ToolStripMenuItem menuItem, string convertToTxt, string convertToBase64)
        {
            if (menuItem != null)
            {
                menuItem.Text = menuItem.Text == convertToTxt ? convertToBase64 : convertToTxt;
            }
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

        private void ClearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clipboardHistory.List.Count == 0)
            {
                MessageBox.Show("History is empty.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clipboardHistory.List.Clear();
                UpdateClipboardList();
                MessageBox.Show("History cleared successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateClipboardList()
        {
            history.Items.Clear();
            foreach (var item in clipboardHistory.List)
            {
                if (currentFormat == Format.Base54)
                {
                    history.Items.Add(item.Base64);
                }
                else
                {
                    history.Items.Add(item.Text);
                }
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

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new();
            af.ShowDialog();
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
                ClipBoardItem newItem = new(Clipboard.GetText());

                if (!string.IsNullOrEmpty(newItem.Text))
                {
                    Clipboard.SetText(newItem.Text);
                }

                AddClipboardTextToHistory(newItem);
            }
        }

        private void AddClipboardTextToHistory(ClipBoardItem item)
        {
            if (clipboardHistory.List.Contains(item))
            {
                return;
            }

            if (currentFormat == Format.Txt)
            {
                ConvertHistoryItems();

                clipboardHistory.List.Add(item);

                UpdateMenuItemText(toTxtMenuItem, convertToTxt, convertToBase64);
            }
            else
            {
                clipboardHistory.List.Add(item);
            }

            UpdateClipboardList();
        }
    }
}
