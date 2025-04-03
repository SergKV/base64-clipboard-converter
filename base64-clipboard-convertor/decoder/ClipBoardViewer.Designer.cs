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
            NotifyIcon = new NotifyIcon(components);
            ucHistoryListView1 = new decoder.ucHistoryListView();
            ContextMenuStrip.SuspendLayout();
            headerPanel.SuspendLayout();
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
            // NotifyIcon
            // 
            NotifyIcon.ContextMenuStrip = ContextMenuStrip;
            NotifyIcon.Icon = (Icon)resources.GetObject("NotifyIcon.Icon");
            NotifyIcon.Text = "NotifyIcon";
            NotifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
            // 
            // ucHistoryListView1
            // 
            ucHistoryListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucHistoryListView1.IsDisabled = false;
            ucHistoryListView1.Location = new Point(0, 46);
            ucHistoryListView1.Name = "ucHistoryListView1";
            ucHistoryListView1.Size = new Size(523, 620);
            ucHistoryListView1.TabIndex = 9;
            ucHistoryListView1.Load += ucHistoryListView1_Load;
            // 
            // ClipBoardViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 664);
            ControlBox = false;
            Controls.Add(ucHistoryListView1);
            Controls.Add(buttonClose);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClipBoardViewer";
            Text = "Base64Decoder";
            Shown += ClipBoardViewer_Shown;
            Resize += ClipBoardViewer_Resize;
            ContextMenuStrip.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private NotifyIcon NotifyIcon;
        private decoder.ucHistoryListView ucHistoryListView1;
    }
}
