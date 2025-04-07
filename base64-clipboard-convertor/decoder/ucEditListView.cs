using System.Windows.Forms;
using decoder.Events;

namespace decoder
{
    public partial class ucEditListView : BaseUserControl
    {
        ClipBoardItem editItem;

        FontDialog fontDialog;

        private bool isModified = false;

        private UcVisibilityStatusEvent UcVisibilityStatusEvent;

        public ucEditListView()
        {
            this.Visible = false;
            InitializeComponent();

            InitializeUI();

            UcVisibilityStatusEvent = new UcVisibilityStatusEvent();
            UcVisibilityStatusEvent.ucVisibilityStatusEvent -= UcVisibilityStatusEvent_UcVisibilityStatusChanged;
            UcVisibilityStatusEvent.ucVisibilityStatusEvent += UcVisibilityStatusEvent_UcVisibilityStatusChanged;
        }

        private void UcVisibilityStatusEvent_UcVisibilityStatusChanged(object? sender, UcVisibilityStatusEvent e)
        {
            this.Visible = true;
            editItem = e.Item;

            EditTextBox.SuspendLayout();

            EditTextBox.Clear();
            EditTextBox.AppendText(e.Item.Text);

            EditTextBox.ResumeLayout();

            isModified = false;
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

        private void ExportToClipBoardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(EditTextBox.Text.ToString());
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EditTextBox.SelectedText))
            {
                EditTextBox.Cut();
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EditTextBox.SelectedText))
            {
                EditTextBox.Copy();
            }
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            EditTextBox.Paste();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (EditTextBox.CanUndo)
            {
                EditTextBox.Undo();
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (EditTextBox.CanUndo)
            {
                EditTextBox.Redo();
            }
        }

        private void FontButton_Click(object sender, EventArgs e)
        {

            fontDialog = new FontDialog()
            {
                ShowColor = false,
                AllowVectorFonts = false,
                AllowVerticalFonts = false,
                FixedPitchOnly = false,
                MaxSize = 36,
                MinSize = 10,
                ShowEffects = false,
                FontMustExist = true
            };

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                EditTextBox.Font = fontDialog.Font;
            }

        }

        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var size = int.Parse(FontSizeComboBox.SelectedItem.ToString());

            EditTextBox.Font = new Font(EditTextBox.Font.FontFamily, size);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (isModified)
            {
                var result = MessageBox.Show("You have unsaved changes. Do you want to save them?",
                                             "Confirm Exit",
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    editItem.Text = EditTextBox.Text;

                    UcVisibilityStatusEvent.SendEventInfo(editItem);

                    this.Visible = false;
                }
                else if (result == DialogResult.No)
                {
                    this.Visible = false;
                }

            }
            else
            {
                this.Visible = false;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTextBox.SelectAll();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FontSizeComboBox.SelectedIndex = 1;

            EditTextBox.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

            EditTextBox.Clear();
            EditTextBox.Text = editItem.Text;
            isModified = false;
        }

        private void InitializeUI()
        {
            FontSizeComboBox.SelectedIndex = 1;

            saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;

            saveAsFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            saveAsFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;

            exportToClipboardToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            exportToClipboardToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;

            exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;

            undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctlr+Z";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;

            redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;

            cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;

            copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;

            pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;

            delteToolStripMenuItem.ShortcutKeyDisplayString = "Delete";
            delteToolStripMenuItem.ShortcutKeys = Keys.Delete;

            selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;

            fontToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+P";
            fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.P;
        }
    }
}
