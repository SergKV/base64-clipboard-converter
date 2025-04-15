using Base64ClipboardDecoder;
using decoder.Events;

namespace decoder
{
    public partial class ucEditListView : BaseUserControl
    {
        public ClipBoardViewer ParentForm { get; set; }

        ClipBoardItem editItem;

        FontDialog fontDialog;

        Stack<RichTextBoxState> undoStack = new();
        Stack<RichTextBoxState> redoStack = new();

        private static int defaultFontSize = 12;
        
        private bool isUndoRedoOperation = false;

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

            undoStack.Clear();
            redoStack.Clear();

            EditTextBox.Text = e.Item.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            editItem.Text = EditTextBox.Text;

            UcVisibilityStatusEvent.SendEventInfo(editItem);

            this.Visible = false;

            ParentForm.appTimer.Reset();
        }

        private void SaveAsFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportAsFile(EditTextBox.Text.ToString(), sfd.FileName);
                MessageBox.Show("File saved successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ParentForm.appTimer.Reset();
        }

        private void ExportToClipBoardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(EditTextBox.Text.ToString());

            ParentForm.appTimer.Reset();
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EditTextBox.SelectedText))
            {
                EditTextBox.Cut();
            }

            ParentForm.appTimer.Reset();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EditTextBox.SelectedText))
            {
                EditTextBox.Copy();
            }

            ParentForm.appTimer.Reset();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            EditTextBox.Paste();

            ParentForm.appTimer.Reset();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 1)
            {
                isUndoRedoOperation = true;

                redoStack.Push(new RichTextBoxState
                {
                    Text = EditTextBox.Text,
                    Font = EditTextBox.SelectionFont,
                    FontSize = EditTextBox.SelectionFont.Size,
                    FontFamily = EditTextBox.SelectionFont.FontFamily
                });

                undoStack.Pop();
                var previousState = undoStack.Peek();

                EditTextBox.Text = previousState.Text;
                EditTextBox.Font = new Font(previousState.FontFamily, previousState.FontSize);
                FontSizeComboBox.SelectedIndex = FontSizeComboBox.FindString(previousState.FontSize.ToString());

                isUndoRedoOperation = false;
            }

            ParentForm.appTimer.Reset();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                isUndoRedoOperation = true;

                undoStack.Push(new RichTextBoxState
                {
                    Text = redoStack.Peek().Text,
                    Font = redoStack.Peek().Font,
                    FontSize = redoStack.Peek().FontSize,
                    FontFamily = redoStack.Peek().FontFamily
                });

                var nextState = redoStack.Pop();

                EditTextBox.Text = nextState.Text;
                EditTextBox.Font = new Font(nextState.FontFamily, nextState.FontSize);
                FontSizeComboBox.SelectedIndex = FontSizeComboBox.FindString(nextState.FontSize.ToString());

                isUndoRedoOperation = false;
            }

            ParentForm.appTimer.Reset();
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

                FontSizeComboBox.SelectedIndex = FontSizeComboBox.FindString(fontDialog.Font.Size.ToString());
            }

            ParentForm.appTimer.Reset();
        }

        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size;

            if (FontSizeComboBox.SelectedItem is null)
            {
                size = defaultFontSize;
                FontSizeComboBox.SelectedIndex = FontSizeComboBox.FindString(defaultFontSize.ToString());
            }
            else
            {
                size = int.Parse(FontSizeComboBox.SelectedItem.ToString());
            }


            EditTextBox.Font = new Font(EditTextBox.Font.FontFamily, size);

            //ParentForm.appTimer.Reset();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 1)
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

            ParentForm.appTimer.Reset();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isUndoRedoOperation)
            {
                return;
            }
            
            SaveState();
        }

        private void SaveState()
        {
            RichTextBoxState currentState = new RichTextBoxState
            {
                Text = EditTextBox.Text,
                Font = EditTextBox.SelectionFont,
                FontSize = EditTextBox.SelectionFont.Size,
                FontFamily = EditTextBox.SelectionFont.FontFamily
            };

            undoStack.Push(currentState);

            redoStack.Clear();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTextBox.SelectAll();

            ParentForm.appTimer.Reset();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FontSizeComboBox.SelectedIndex = 1;

            EditTextBox.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

            EditTextBox.Clear();
            undoStack.Clear();
            redoStack.Clear();

            EditTextBox.Text = editItem.Text;

            ParentForm.appTimer.Reset();
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
