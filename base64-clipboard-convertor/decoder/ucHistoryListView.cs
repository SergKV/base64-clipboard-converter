using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace decoder
{
    public partial class ucHistoryListView : BaseUserControl
    {
        private Form clipBoardViewer;

        private const string convertToTxt = "Convert to txt";
        private const string convertToBase64 = "Convert to base64";
        private const string disabled = "Disable";
        private const string enabled = "Enable";

        private List<string> clipboardHistory = [];

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

        public ucHistoryListView(Form clipBoardViewer)
        {
            InitializeComponent();
            this.clipBoardViewer = clipBoardViewer;
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsDisabled = !IsDisabled;
        }

        private void AppStatusChanged()
        {
            List<ToolStripMenuItem> menuItems =
            [
                //DisableMenuStripMenuItem,
                DisableToolStripMenuItem
            ];

            foreach (ToolStripMenuItem menuItem in menuItems)
            {
                menuItem.Text = isDisabled ? enabled : disabled;
            }
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
            clipBoardViewer.Close();
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
            var clipboardHistoryTmp = history.Items.Cast<string>().ToList();
            history.Items.Clear();

            var formatFunc = currentFormat == Format.Base54
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

        private void UpdateClipboardList()
        {
            history.Items.Clear();
            foreach (var item in clipboardHistory)
            {
                history.Items.Add(item);
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
    }
}
