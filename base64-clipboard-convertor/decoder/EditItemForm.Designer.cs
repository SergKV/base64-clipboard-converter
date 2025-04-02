namespace decoder
{
    partial class EditItemForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemTextBox = new RichTextBox();
            headerPanel = new Panel();
            button1 = new Button();
            buttonClose = new Button();
            productLabel = new Label();
            buttonMaximize = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exportAsFileToolStripMenuItem = new ToolStripMenuItem();
            exportToClipboardToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            fontSizeToolStripMenuItem = new ToolStripMenuItem();
            headerPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // itemTextBox
            // 
            itemTextBox.Location = new Point(0, 77);
            itemTextBox.Name = "itemTextBox";
            itemTextBox.Size = new Size(905, 866);
            itemTextBox.TabIndex = 0;
            itemTextBox.Text = "";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.ControlLight;
            headerPanel.Controls.Add(button1);
            headerPanel.Controls.Add(buttonClose);
            headerPanel.Controls.Add(productLabel);
            headerPanel.Controls.Add(buttonMaximize);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(905, 46);
            headerPanel.TabIndex = 9;
            headerPanel.MouseDoubleClick += MouseDouble_Click;
            headerPanel.MouseDown += Mouse_Down;
            headerPanel.MouseMove += Mouse_Move;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = SystemColors.ControlLight;
            button1.BackgroundImage = Properties.Resources.icons8_maximize_window_24;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(834, 8);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButtonMaximize_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = SystemColors.ControlLight;
            buttonClose.BackgroundImage = Properties.Resources.icons8_close_window_24;
            buttonClose.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClose.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(867, 8);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(30, 30);
            buttonClose.TabIndex = 9;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += ButtonClose_Click;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productLabel.Image = Properties.Resources.icons8_64_bit_32;
            productLabel.ImageAlign = ContentAlignment.MiddleLeft;
            productLabel.Location = new Point(11, 10);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(242, 25);
            productLabel.TabIndex = 8;
            productLabel.Text = "      Base64 edit history item";
            productLabel.MouseDoubleClick += MouseDouble_Click;
            productLabel.MouseDown += Mouse_Down;
            productLabel.MouseMove += Mouse_Move;
            // 
            // buttonMaximize
            // 
            buttonMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximize.BackColor = SystemColors.ControlLight;
            buttonMaximize.BackgroundImage = Properties.Resources.icons8_maximize_window_24;
            buttonMaximize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.Location = new Point(1158, 8);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Size = new Size(30, 30);
            buttonMaximize.TabIndex = 7;
            buttonMaximize.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 11.25F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, textToolStripMenuItem });
            menuStrip1.Location = new Point(0, 46);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, exportAsFileToolStripMenuItem, exportToClipboardToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontSizeToolStripMenuItem });
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(48, 24);
            textToolStripMenuItem.Text = "Text";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(47, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 24);
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
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(180, 24);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(180, 24);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(180, 24);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 24);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(180, 24);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // fontSizeToolStripMenuItem
            // 
            fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            fontSizeToolStripMenuItem.Size = new Size(180, 24);
            fontSizeToolStripMenuItem.Text = "Font size";
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 943);
            Controls.Add(headerPanel);
            Controls.Add(itemTextBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "EditItemForm";
            Text = "EditItemForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox itemTextBox;
        private Panel headerPanel;
        private Label productLabel;
        private Button buttonMaximize;
        private Button buttonClose;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exportAsFileToolStripMenuItem;
        private ToolStripMenuItem exportToClipboardToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem fontSizeToolStripMenuItem;
    }
}