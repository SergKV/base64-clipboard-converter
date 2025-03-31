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
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            disableToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            buttonClose = new Button();
            buttonMaximize = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            headerPanel = new Panel();
            productLabel = new Label();
            toolStrip = new ToolStrip();
            File = new ToolStripDropDownButton();
            deactivateToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            Edit = new ToolStripDropDownButton();
            converToTxtToolStripMenuItem = new ToolStripMenuItem();
            copySelectedToolStripMenuItem = new ToolStripMenuItem();
            clearHistoryToolStripMenuItem = new ToolStripMenuItem();
            Help = new ToolStripDropDownButton();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            history = new ListBox();
            contextMenuStrip1.SuspendLayout();
            headerPanel.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { disableToolStripMenuItem, closeToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 48);
            // 
            // disableToolStripMenuItem
            // 
            disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            disableToolStripMenuItem.Size = new Size(112, 22);
            disableToolStripMenuItem.Text = "Disable";
            disableToolStripMenuItem.Click += disableToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(112, 22);
            closeToolStripMenuItem1.Text = "Exit";
            closeToolStripMenuItem1.Click += closeToolStripMenuItem1_Click;
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
            buttonClose.Click += button1_Click;
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
            buttonMaximize.Click += button2_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
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
            headerPanel.MouseDoubleClick += button2_Click;
            headerPanel.MouseDown += mouse_Down;
            headerPanel.MouseMove += mouse_Move;
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
            productLabel.MouseDoubleClick += button2_Click;
            productLabel.MouseDown += mouse_Down;
            productLabel.MouseMove += mouse_Move;
            // 
            // toolStrip
            // 
            toolStrip.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip.Items.AddRange(new ToolStripItem[] { File, Edit, Help });
            toolStrip.Location = new Point(0, 46);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(523, 27);
            toolStrip.TabIndex = 9;
            toolStrip.Text = "toolStrip1";
            // 
            // File
            // 
            File.AutoToolTip = false;
            File.DisplayStyle = ToolStripItemDisplayStyle.Text;
            File.DropDownItems.AddRange(new ToolStripItem[] { deactivateToolStripMenuItem, exportToolStripMenuItem, quitToolStripMenuItem });
            File.ImageTransparentColor = Color.Magenta;
            File.Name = "File";
            File.Size = new Size(45, 24);
            File.Text = "File";
            // 
            // deactivateToolStripMenuItem
            // 
            deactivateToolStripMenuItem.Name = "deactivateToolStripMenuItem";
            deactivateToolStripMenuItem.Size = new Size(128, 24);
            deactivateToolStripMenuItem.Text = "Disable";
            deactivateToolStripMenuItem.Click += toolStripMenuItem5_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(128, 24);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(128, 24);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // Edit
            // 
            Edit.AutoToolTip = false;
            Edit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Edit.DropDownItems.AddRange(new ToolStripItem[] { converToTxtToolStripMenuItem, copySelectedToolStripMenuItem, clearHistoryToolStripMenuItem });
            Edit.ImageTransparentColor = Color.Magenta;
            Edit.Name = "Edit";
            Edit.Size = new Size(48, 24);
            Edit.Text = "Edit";
            // 
            // converToTxtToolStripMenuItem
            // 
            converToTxtToolStripMenuItem.Name = "converToTxtToolStripMenuItem";
            converToTxtToolStripMenuItem.Size = new Size(171, 24);
            converToTxtToolStripMenuItem.Text = "Convert to txt";
            converToTxtToolStripMenuItem.Click += formatToolStripMenuItem_Click;
            // 
            // copySelectedToolStripMenuItem
            // 
            copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            copySelectedToolStripMenuItem.Size = new Size(171, 24);
            copySelectedToolStripMenuItem.Text = "Copy selected";
            copySelectedToolStripMenuItem.Click += copySelectedToolStripMenuItem_Click;
            // 
            // clearHistoryToolStripMenuItem
            // 
            clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            clearHistoryToolStripMenuItem.Size = new Size(171, 24);
            clearHistoryToolStripMenuItem.Text = "Clear History";
            clearHistoryToolStripMenuItem.Click += toolStripMenuItem4_Click_1;
            // 
            // Help
            // 
            Help.AutoToolTip = false;
            Help.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Help.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            Help.ImageTransparentColor = Color.Magenta;
            Help.Name = "Help";
            Help.Size = new Size(54, 24);
            Help.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(119, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
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
            // ClipBoardViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 664);
            ControlBox = false;
            Controls.Add(history);
            Controls.Add(toolStrip);
            Controls.Add(buttonClose);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClipBoardViewer";
            Text = "Base64Decoder";
            Shown += ClipBoardViewer_Shown;
            Resize += ClipBoardViewer_Resize;
            contextMenuStrip1.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox history;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem3;
        private Button buttonClose;
        private Button buttonMaximize;
        private ContextMenuStrip contextMenuStrip2;
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
        private ToolStripMenuItem disableToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
    }
}
