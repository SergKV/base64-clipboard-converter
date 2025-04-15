namespace decoder
{
    partial class ucEditListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsFileToolStripMenuItem = new ToolStripMenuItem();
            exportToClipboardToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            delteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            EditTextBox = new RichTextBox();
            ButtonPanel = new Panel();
            ResetButton = new Button();
            FontSizeComboBox = new ComboBox();
            ExitButton = new Button();
            FontSizeButton = new Button();
            PasteButton = new Button();
            CopyButton = new Button();
            CutButton = new Button();
            RedoButton = new Button();
            UndoButton = new Button();
            CopyToClipBoardButton = new Button();
            SaveAsFileButton = new Button();
            SaveButton = new Button();
            SaveButtonToolTip = new ToolTip(components);
            ExportAsDocumentToolTip = new ToolTip(components);
            CopyToClipBoardToolTip = new ToolTip(components);
            UndoToolTip = new ToolTip(components);
            RedoToolTip = new ToolTip(components);
            CutToolTip = new ToolTip(components);
            CopyToolTip = new ToolTip(components);
            PasteToolTip = new ToolTip(components);
            Font = new ToolTip(components);
            ExitToolTip = new ToolTip(components);
            Revert = new ToolTip(components);
            FontSize = new ToolTip(components);
            menuStrip.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Segoe UI", 11.25F);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolStripMenuItem1, textToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(537, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsFileToolStripMenuItem, exportToClipboardToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(207, 24);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveButton_Click;
            // 
            // saveAsFileToolStripMenuItem
            // 
            saveAsFileToolStripMenuItem.Name = "saveAsFileToolStripMenuItem";
            saveAsFileToolStripMenuItem.Size = new Size(207, 24);
            saveAsFileToolStripMenuItem.Text = "Save as...";
            saveAsFileToolStripMenuItem.Click += SaveAsFileButton_Click;
            // 
            // exportToClipboardToolStripMenuItem
            // 
            exportToClipboardToolStripMenuItem.Name = "exportToClipboardToolStripMenuItem";
            exportToClipboardToolStripMenuItem.Size = new Size(207, 24);
            exportToClipboardToolStripMenuItem.Text = "Export to clipboard";
            exportToClipboardToolStripMenuItem.Click += ExportToClipBoardButton_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(207, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitButton_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, delteToolStripMenuItem, selectAllToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(47, 24);
            toolStripMenuItem1.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(138, 24);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += UndoButton_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(138, 24);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += RedoButton_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(138, 24);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += CutButton_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(138, 24);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += CopyButton_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(138, 24);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += PasteButton_Click;
            // 
            // delteToolStripMenuItem
            // 
            delteToolStripMenuItem.Name = "delteToolStripMenuItem";
            delteToolStripMenuItem.Size = new Size(138, 24);
            delteToolStripMenuItem.Text = "Delte";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(138, 24);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem });
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(48, 24);
            textToolStripMenuItem.Text = "Text";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(107, 24);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += FontButton_Click;
            // 
            // EditTextBox
            // 
            EditTextBox.Dock = DockStyle.Fill;
            EditTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditTextBox.Location = new Point(0, 71);
            EditTextBox.Name = "EditTextBox";
            EditTextBox.Size = new Size(537, 524);
            EditTextBox.TabIndex = 1;
            EditTextBox.Text = "";
            EditTextBox.TextChanged += TextBox_TextChanged;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(ResetButton);
            ButtonPanel.Controls.Add(FontSizeComboBox);
            ButtonPanel.Controls.Add(ExitButton);
            ButtonPanel.Controls.Add(FontSizeButton);
            ButtonPanel.Controls.Add(PasteButton);
            ButtonPanel.Controls.Add(CopyButton);
            ButtonPanel.Controls.Add(CutButton);
            ButtonPanel.Controls.Add(RedoButton);
            ButtonPanel.Controls.Add(UndoButton);
            ButtonPanel.Controls.Add(CopyToClipBoardButton);
            ButtonPanel.Controls.Add(SaveAsFileButton);
            ButtonPanel.Controls.Add(SaveButton);
            ButtonPanel.Dock = DockStyle.Top;
            ButtonPanel.Location = new Point(0, 28);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(537, 43);
            ButtonPanel.TabIndex = 2;
            // 
            // ResetButton
            // 
            ResetButton.BackgroundImage = Properties.Resources.icons8_reset_50;
            ResetButton.BackgroundImageLayout = ImageLayout.Zoom;
            ResetButton.Location = new Point(412, 5);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(34, 34);
            ResetButton.TabIndex = 14;
            Revert.SetToolTip(ResetButton, "Revert");
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // FontSizeComboBox
            // 
            FontSizeComboBox.Font = new Font("Segoe UI", 14F);
            FontSizeComboBox.FormattingEnabled = true;
            FontSizeComboBox.ItemHeight = 25;
            FontSizeComboBox.Items.AddRange(new object[] { "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36" });
            FontSizeComboBox.Location = new Point(362, 6);
            FontSizeComboBox.Name = "FontSizeComboBox";
            FontSizeComboBox.Size = new Size(44, 33);
            FontSizeComboBox.TabIndex = 13;
            FontSize.SetToolTip(FontSizeComboBox, "Font size");
            FontSizeComboBox.SelectedIndexChanged += FontSizeComboBox_SelectedIndexChanged;
            // 
            // ExitButton
            // 
            ExitButton.BackgroundImage = Properties.Resources.icons8_export_481;
            ExitButton.BackgroundImageLayout = ImageLayout.Zoom;
            ExitButton.Location = new Point(452, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(34, 34);
            ExitButton.TabIndex = 12;
            ExitToolTip.SetToolTip(ExitButton, "Exit");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // FontSizeButton
            // 
            FontSizeButton.BackgroundImage = Properties.Resources.icons8_font_size_50;
            FontSizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            FontSizeButton.Location = new Point(323, 5);
            FontSizeButton.Name = "FontSizeButton";
            FontSizeButton.Size = new Size(34, 34);
            FontSizeButton.TabIndex = 11;
            Font.SetToolTip(FontSizeButton, "Font");
            FontSizeButton.UseVisualStyleBackColor = true;
            FontSizeButton.Click += FontButton_Click;
            // 
            // PasteButton
            // 
            PasteButton.BackgroundImage = Properties.Resources.icons8_paste_48;
            PasteButton.BackgroundImageLayout = ImageLayout.Zoom;
            PasteButton.Location = new Point(203, 5);
            PasteButton.Name = "PasteButton";
            PasteButton.Size = new Size(34, 34);
            PasteButton.TabIndex = 10;
            PasteToolTip.SetToolTip(PasteButton, "Paste");
            PasteButton.UseVisualStyleBackColor = true;
            PasteButton.Click += PasteButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.BackgroundImage = Properties.Resources.icons8_copy_48;
            CopyButton.BackgroundImageLayout = ImageLayout.Zoom;
            CopyButton.Location = new Point(163, 5);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(34, 34);
            CopyButton.TabIndex = 9;
            CopyToolTip.SetToolTip(CopyButton, "Copy");
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // CutButton
            // 
            CutButton.BackgroundImage = Properties.Resources.icons8_cut_48;
            CutButton.BackgroundImageLayout = ImageLayout.Zoom;
            CutButton.Location = new Point(123, 5);
            CutButton.Name = "CutButton";
            CutButton.Size = new Size(34, 34);
            CutButton.TabIndex = 8;
            CutToolTip.SetToolTip(CutButton, "Cut");
            CutButton.UseVisualStyleBackColor = true;
            CutButton.Click += CutButton_Click;
            // 
            // RedoButton
            // 
            RedoButton.BackgroundImage = Properties.Resources.icons8_redo_32;
            RedoButton.BackgroundImageLayout = ImageLayout.Zoom;
            RedoButton.Location = new Point(283, 5);
            RedoButton.Name = "RedoButton";
            RedoButton.Size = new Size(34, 34);
            RedoButton.TabIndex = 7;
            RedoToolTip.SetToolTip(RedoButton, "Redo");
            RedoButton.UseVisualStyleBackColor = true;
            RedoButton.Click += RedoButton_Click;
            // 
            // UndoButton
            // 
            UndoButton.BackgroundImage = Properties.Resources.icons8_undo_32;
            UndoButton.BackgroundImageLayout = ImageLayout.Zoom;
            UndoButton.Location = new Point(243, 5);
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(34, 34);
            UndoButton.TabIndex = 6;
            UndoToolTip.SetToolTip(UndoButton, "Undo");
            UndoButton.UseVisualStyleBackColor = true;
            UndoButton.Click += UndoButton_Click;
            // 
            // CopyToClipBoardButton
            // 
            CopyToClipBoardButton.BackgroundImage = Properties.Resources.icons8_export_48;
            CopyToClipBoardButton.BackgroundImageLayout = ImageLayout.Zoom;
            CopyToClipBoardButton.Location = new Point(83, 5);
            CopyToClipBoardButton.Name = "CopyToClipBoardButton";
            CopyToClipBoardButton.Size = new Size(34, 34);
            CopyToClipBoardButton.TabIndex = 5;
            CopyToClipBoardToolTip.SetToolTip(CopyToClipBoardButton, "Copy to clipboard");
            CopyToClipBoardButton.UseVisualStyleBackColor = true;
            CopyToClipBoardButton.Click += ExportToClipBoardButton_Click;
            // 
            // SaveAsFileButton
            // 
            SaveAsFileButton.BackgroundImage = Properties.Resources.icons8_export_file_50;
            SaveAsFileButton.BackgroundImageLayout = ImageLayout.Zoom;
            SaveAsFileButton.Location = new Point(43, 5);
            SaveAsFileButton.Name = "SaveAsFileButton";
            SaveAsFileButton.Size = new Size(34, 34);
            SaveAsFileButton.TabIndex = 4;
            ExportAsDocumentToolTip.SetToolTip(SaveAsFileButton, "Save as...");
            SaveAsFileButton.UseVisualStyleBackColor = true;
            SaveAsFileButton.Click += SaveAsFileButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackgroundImage = Properties.Resources.icons8_save_48;
            SaveButton.BackgroundImageLayout = ImageLayout.Zoom;
            SaveButton.Location = new Point(3, 5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(34, 34);
            SaveButton.TabIndex = 3;
            SaveButtonToolTip.SetToolTip(SaveButton, "Save");
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ucEditListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditTextBox);
            Controls.Add(ButtonPanel);
            Controls.Add(menuStrip);
            Name = "ucEditListView";
            Size = new Size(537, 595);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsFileToolStripMenuItem;
        private ToolStripMenuItem exportToClipboardToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private RichTextBox EditTextBox;
        private Panel ButtonPanel;
        private Button SaveAsFileButton;
        private Button SaveButton;
        private Button ExitButton;
        private Button FontSizeButton;
        private Button PasteButton;
        private Button CopyButton;
        private Button CutButton;
        private Button RedoButton;
        private Button UndoButton;
        private Button CopyToClipBoardButton;
        private ToolTip SaveButtonToolTip;
        private ToolTip ExportAsDocumentToolTip;
        private ToolTip CopyToClipBoardToolTip;
        private ToolTip UndoToolTip;
        private ToolTip RedoToolTip;
        private ToolTip CutToolTip;
        private ToolTip CopyToolTip;
        private ToolTip ExitToolTip;
        private ToolTip Font;
        private ToolTip PasteToolTip;
        private ComboBox FontSizeComboBox;
        private ToolStripMenuItem delteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private Button ResetButton;
        private ToolTip Revert;
        private ToolTip FontSize;
    }
}
