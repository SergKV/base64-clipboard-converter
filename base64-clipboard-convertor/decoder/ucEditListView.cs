using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using decoder.Events;

namespace decoder
{
    public partial class ucEditListView : BaseUserControl
    {
        ClipBoardItem editItem;

        private UcVisibilityStatusEvent UcVisibilityStatusEvent;

        public ucEditListView()
        {
            this.Visible = false;
            InitializeComponent();

            UcVisibilityStatusEvent = new UcVisibilityStatusEvent();
            UcVisibilityStatusEvent.ucVisibilityStatusEvent -= UcVisibilityStatusEvent_UcVisibilityStatusChanged;
            UcVisibilityStatusEvent.ucVisibilityStatusEvent += UcVisibilityStatusEvent_UcVisibilityStatusChanged;
        }

        private void UcVisibilityStatusEvent_UcVisibilityStatusChanged(object? sender, UcVisibilityStatusEvent e)
        {
            this.Visible = true;

            editItem = e.Item;
            EditTextBox.Text = e.Item.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            editItem.Text = EditTextBox.Text;
            
            UcVisibilityStatusEvent.SendEventInfo(editItem);

            this.Visible = false;
        }

        private void SaveAsFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportAsFile(EditTextBox.Text.ToString(), sfd.FileName);
                MessageBox.Show("File saved successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CopyToClipBoardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(EditTextBox.Text.ToString());
        }
    }
}
