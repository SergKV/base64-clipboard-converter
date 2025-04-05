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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exportAsFileToolStripMenuItem = new ToolStripMenuItem();
            exportToClipboardToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            fontSizeToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            ButtonPanel = new Panel();
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
            menuStrip1.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 11.25F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolStripMenuItem1, textToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(147, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, exportAsFileToolStripMenuItem, exportToClipboardToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(207, 24);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exportAsFileToolStripMenuItem
            // 
            exportAsFileToolStripMenuItem.Name = "exportAsFileToolStripMenuItem";
            exportAsFileToolStripMenuItem.Size = new Size(207, 24);
            exportAsFileToolStripMenuItem.Text = "Export as file";
            // 
            // exportToClipboardToolStripMenuItem
            // 
            exportToClipboardToolStripMenuItem.Name = "exportToClipboardToolStripMenuItem";
            exportToClipboardToolStripMenuItem.Size = new Size(207, 24);
            exportToClipboardToolStripMenuItem.Text = "Export to clipboard";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(207, 24);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(47, 24);
            toolStripMenuItem1.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(114, 24);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(114, 24);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(114, 24);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(114, 24);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(114, 24);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontSizeToolStripMenuItem });
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(48, 24);
            textToolStripMenuItem.Text = "Text";
            // 
            // fontSizeToolStripMenuItem
            // 
            fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            fontSizeToolStripMenuItem.Size = new Size(136, 24);
            fontSizeToolStripMenuItem.Text = "Font size";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(515, 505);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // ButtonPanel
            // 
            ButtonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            ButtonPanel.Location = new Point(0, 31);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(515, 43);
            ButtonPanel.TabIndex = 2;
            // 
            // ExitButton
            // 
            ExitButton.BackgroundImage = Properties.Resources.icons8_export_481;
            ExitButton.BackgroundImageLayout = ImageLayout.Zoom;
            ExitButton.Location = new Point(363, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(34, 34);
            ExitButton.TabIndex = 12;
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // FontSizeButton
            // 
            FontSizeButton.BackgroundImage = Properties.Resources.icons8_font_size_50;
            FontSizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            FontSizeButton.Location = new Point(323, 5);
            FontSizeButton.Name = "FontSizeButton";
            FontSizeButton.Size = new Size(34, 34);
            FontSizeButton.TabIndex = 11;
            FontSizeButton.UseVisualStyleBackColor = true;
            // 
            // PasteButton
            // 
            PasteButton.BackgroundImage = Properties.Resources.icons8_paste_48;
            PasteButton.BackgroundImageLayout = ImageLayout.Zoom;
            PasteButton.Location = new Point(283, 5);
            PasteButton.Name = "PasteButton";
            PasteButton.Size = new Size(34, 34);
            PasteButton.TabIndex = 10;
            PasteButton.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            CopyButton.BackgroundImage = Properties.Resources.icons8_copy_48;
            CopyButton.BackgroundImageLayout = ImageLayout.Zoom;
            CopyButton.Location = new Point(243, 5);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(34, 34);
            CopyButton.TabIndex = 9;
            CopyButton.UseVisualStyleBackColor = true;
            // 
            // CutButton
            // 
            CutButton.BackgroundImage = Properties.Resources.icons8_cut_48;
            CutButton.BackgroundImageLayout = ImageLayout.Zoom;
            CutButton.Location = new Point(203, 5);
            CutButton.Name = "CutButton";
            CutButton.Size = new Size(34, 34);
            CutButton.TabIndex = 8;
            CutButton.UseVisualStyleBackColor = true;
            // 
            // RedoButton
            // 
            RedoButton.BackgroundImage = Properties.Resources.icons8_redo_32;
            RedoButton.BackgroundImageLayout = ImageLayout.Zoom;
            RedoButton.Location = new Point(163, 5);
            RedoButton.Name = "RedoButton";
            RedoButton.Size = new Size(34, 34);
            RedoButton.TabIndex = 7;
            RedoButton.UseVisualStyleBackColor = true;
            // 
            // UndoButton
            // 
            UndoButton.BackgroundImage = Properties.Resources.icons8_undo_32;
            UndoButton.BackgroundImageLayout = ImageLayout.Zoom;
            UndoButton.Location = new Point(123, 5);
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(34, 34);
            UndoButton.TabIndex = 6;
            UndoButton.UseVisualStyleBackColor = true;
            // 
            // CopyToClipBoardButton
            // 
            CopyToClipBoardButton.BackgroundImage = Properties.Resources.icons8_export_48;
            CopyToClipBoardButton.BackgroundImageLayout = ImageLayout.Zoom;
            CopyToClipBoardButton.Location = new Point(83, 5);
            CopyToClipBoardButton.Name = "CopyToClipBoardButton";
            CopyToClipBoardButton.Size = new Size(34, 34);
            CopyToClipBoardButton.TabIndex = 5;
            CopyToClipBoardButton.UseVisualStyleBackColor = true;
            // 
            // SaveAsFileButton
            // 
            SaveAsFileButton.BackgroundImage = Properties.Resources.icons8_export_file_50;
            SaveAsFileButton.BackgroundImageLayout = ImageLayout.Zoom;
            SaveAsFileButton.Location = new Point(43, 5);
            SaveAsFileButton.Name = "SaveAsFileButton";
            SaveAsFileButton.Size = new Size(34, 34);
            SaveAsFileButton.TabIndex = 4;
            SaveAsFileButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.BackgroundImage = Properties.Resources.icons8_save_48;
            SaveButton.BackgroundImageLayout = ImageLayout.Zoom;
            SaveButton.Location = new Point(3, 5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(34, 34);
            SaveButton.TabIndex = 3;
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // ucEditListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonPanel);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Name = "ucEditListView";
            Size = new Size(515, 581);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exportAsFileToolStripMenuItem;
        private ToolStripMenuItem exportToClipboardToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem fontSizeToolStripMenuItem;
        private RichTextBox richTextBox1;
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
    }
}
