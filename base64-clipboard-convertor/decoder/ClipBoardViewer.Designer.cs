namespace Base64ClipboardDecoder
{
    partial class ClipBoardViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipBoardViewer));
            ContextMenuStrip = new ContextMenuStrip(components);
            DisableMenuStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            buttonClose = new Button();
            buttonMaximize = new Button();
            headerPanel = new Panel();
            productLabel = new Label();
            history = new ListBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            DisableToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem1 = new ToolStripMenuItem();
            quitToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            convertToTxtToolStripMenuItem = new ToolStripMenuItem();
            editSelectedToolStripMenuItem1 = new ToolStripMenuItem();
            copySelectedToolStripMenuItem1 = new ToolStripMenuItem();
            clearHistoryToolStripMenuItem1 = new ToolStripMenuItem();
            clearClipboardToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            NotifyIcon = new NotifyIcon(components);
            ContextMenuStrip.SuspendLayout();
            headerPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { DisableMenuStripMenuItem, closeToolStripMenuItem1 });
            ContextMenuStrip.Name = "contextMenuStrip1";
            ContextMenuStrip.Size = new Size(181, 70);
            // 
            // DisableMenuStripMenuItem
            // 
            DisableMenuStripMenuItem.Name = "DisableMenuStripMenuItem";
            DisableMenuStripMenuItem.Size = new Size(180, 22);
            DisableMenuStripMenuItem.Text = "Disable";
            DisableMenuStripMenuItem.Click += DisableMenuStrip_Click;
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(180, 22);
            closeToolStripMenuItem1.Tag = "";
            closeToolStripMenuItem1.Text = "Exit";
            closeToolStripMenuItem1.Click += ExitContextMenuStrip_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Quit";
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = SystemColors.ControlLight;
            buttonClose.BackgroundImage = decoder.Properties.Resources.icons8_close_window_24;
            buttonClose.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClose.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(486, 8);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(30, 30);
            buttonClose.TabIndex = 6;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += ButtonClose_Click;
            // 
            // buttonMaximize
            // 
            buttonMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximize.BackColor = SystemColors.ControlLight;
            buttonMaximize.BackgroundImage = decoder.Properties.Resources.icons8_maximize_window_24;
            buttonMaximize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.Location = new Point(453, 8);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Size = new Size(30, 30);
            buttonMaximize.TabIndex = 7;
            buttonMaximize.UseVisualStyleBackColor = false;
            buttonMaximize.Click += ButtonMaximize_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.ControlLight;
            headerPanel.Controls.Add(productLabel);
            headerPanel.Controls.Add(buttonMaximize);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(523, 46);
            headerPanel.TabIndex = 8;
            headerPanel.MouseDoubleClick += ButtonMaximize_Click;
            headerPanel.MouseDown += Mouse_Down;
            headerPanel.MouseMove += Mouse_Move;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productLabel.Image = decoder.Properties.Resources.icons8_64_bit_32;
            productLabel.ImageAlign = ContentAlignment.MiddleLeft;
            productLabel.Location = new Point(11, 10);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(272, 25);
            productLabel.TabIndex = 8;
            productLabel.Text = "      Base64 clipboard convertor";
            productLabel.MouseDoubleClick += ButtonMaximize_Click;
            productLabel.MouseDown += Mouse_Down;
            productLabel.MouseMove += Mouse_Move;
            // 
            // history
            // 
            history.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            history.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            history.HorizontalScrollbar = true;
            history.ItemHeight = 21;
            history.Location = new Point(0, 72);
            history.Name = "history";
            history.Size = new Size(523, 592);
            history.TabIndex = 10;
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Segoe UI", 11.25F);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 46);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(523, 28);
            menuStrip.TabIndex = 11;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DisableToolStripMenuItem, exportToolStripMenuItem1, quitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // DisableToolStripMenuItem
            // 
            DisableToolStripMenuItem.Name = "DisableToolStripMenuItem";
            DisableToolStripMenuItem.Size = new Size(128, 24);
            DisableToolStripMenuItem.Text = "Disable";
            DisableToolStripMenuItem.Click += DisableToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem1
            // 
            exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            exportToolStripMenuItem1.Size = new Size(128, 24);
            exportToolStripMenuItem1.Text = "Export";
            exportToolStripMenuItem1.Click += ExportToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem1
            // 
            quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            quitToolStripMenuItem1.Size = new Size(128, 24);
            quitToolStripMenuItem1.Text = "Quit";
            quitToolStripMenuItem1.Click += QuitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertToTxtToolStripMenuItem, editSelectedToolStripMenuItem1, copySelectedToolStripMenuItem1, clearHistoryToolStripMenuItem1, clearClipboardToolStripMenuItem1 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(47, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // convertToTxtToolStripMenuItem
            // 
            convertToTxtToolStripMenuItem.Name = "convertToTxtToolStripMenuItem";
            convertToTxtToolStripMenuItem.Size = new Size(180, 24);
            convertToTxtToolStripMenuItem.Text = "Convert to txt";
            convertToTxtToolStripMenuItem.Click += ConvertToTxtToolStripMenuItem_Click;
            // 
            // editSelectedToolStripMenuItem1
            // 
            editSelectedToolStripMenuItem1.Name = "editSelectedToolStripMenuItem1";
            editSelectedToolStripMenuItem1.Size = new Size(180, 24);
            editSelectedToolStripMenuItem1.Text = "Edit selected";
            editSelectedToolStripMenuItem1.Click += EditSelectedToolStripMenuItem_Click;
            // 
            // copySelectedToolStripMenuItem1
            // 
            copySelectedToolStripMenuItem1.Name = "copySelectedToolStripMenuItem1";
            copySelectedToolStripMenuItem1.Size = new Size(180, 24);
            copySelectedToolStripMenuItem1.Text = "Copy selected";
            copySelectedToolStripMenuItem1.Click += CopySelectedToolStripMenuItem_Click;
            // 
            // clearHistoryToolStripMenuItem1
            // 
            clearHistoryToolStripMenuItem1.Name = "clearHistoryToolStripMenuItem1";
            clearHistoryToolStripMenuItem1.Size = new Size(180, 24);
            clearHistoryToolStripMenuItem1.Text = "Clear history";
            clearHistoryToolStripMenuItem1.Click += ClearHistoryToolStripMenuItem_Click;
            // 
            // clearClipboardToolStripMenuItem1
            // 
            clearClipboardToolStripMenuItem1.Name = "clearClipboardToolStripMenuItem1";
            clearClipboardToolStripMenuItem1.Size = new Size(180, 24);
            clearClipboardToolStripMenuItem1.Text = "Clear clipboard";
            clearClipboardToolStripMenuItem1.Click += ClearClipboardToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(53, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(119, 24);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += AboutToolStripMenuItem_Click;
            // 
            // NotifyIcon
            // 
            NotifyIcon.ContextMenuStrip = ContextMenuStrip;
            NotifyIcon.Icon = (Icon)resources.GetObject("NotifyIcon.Icon");
            NotifyIcon.Text = "NotifyIcon";
            NotifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
            // 
            // ClipBoardViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 664);
            ControlBox = false;
            Controls.Add(history);
            Controls.Add(menuStrip);
            Controls.Add(buttonClose);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip;
            Name = "ClipBoardViewer";
            Text = "Base64Decoder";
            Shown += ClipBoardViewer_Shown;
            Resize += ClipBoardViewer_Resize;
            ContextMenuStrip.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox history;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem toolStripMenuItem3;
        private Button buttonClose;
        private Button buttonMaximize;
        private Panel headerPanel;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton File;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripDropDownButton Edit;
        private ToolStripMenuItem converToTxtToolStripMenuItem;
        private ToolStripMenuItem clearHistoryToolStripMenuItem;
        private ToolStripDropDownButton Help;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem deactivateToolStripMenuItem;
        private Label productLabel;
        private ToolStripMenuItem copySelectedToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem1;
        private ToolStripMenuItem DisableMenuStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem editSelectedToolStripMenuItem;
        private ToolStripMenuItem clearClipboardToolStripMenuItem;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem DisableToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem1;
        private ToolStripMenuItem quitToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem convertToTxtToolStripMenuItem;
        private ToolStripMenuItem editSelectedToolStripMenuItem1;
        private ToolStripMenuItem copySelectedToolStripMenuItem1;
        private ToolStripMenuItem clearHistoryToolStripMenuItem1;
        private ToolStripMenuItem clearClipboardToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private NotifyIcon NotifyIcon;
    }
}
