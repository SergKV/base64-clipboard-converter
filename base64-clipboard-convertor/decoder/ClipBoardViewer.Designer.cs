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
            NotifyIcon = new NotifyIcon(components);
            ucHistoryListView1 = new decoder.ucHistoryListView();
            ucEditListView1 = new decoder.ucEditListView();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { DisableMenuStripMenuItem, closeToolStripMenuItem1 });
            ContextMenuStrip.Name = "contextMenuStrip1";
            ContextMenuStrip.Size = new Size(113, 48);
            // 
            // DisableMenuStripMenuItem
            // 
            DisableMenuStripMenuItem.Name = "DisableMenuStripMenuItem";
            DisableMenuStripMenuItem.Size = new Size(112, 22);
            DisableMenuStripMenuItem.Text = "Disable";
            DisableMenuStripMenuItem.Click += DisableMenuStrip_Click;
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(112, 22);
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
            // NotifyIcon
            // 
            NotifyIcon.ContextMenuStrip = ContextMenuStrip;
            NotifyIcon.Icon = (Icon)resources.GetObject("NotifyIcon.Icon");
            NotifyIcon.Text = "NotifyIcon";
            NotifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
            // 
            // ucHistoryListView1
            // 
            ucHistoryListView1.Dock = DockStyle.Fill;
            ucHistoryListView1.IsDisabled = false;
            ucHistoryListView1.Location = new Point(0, 0);
            ucHistoryListView1.Name = "ucHistoryListView1";
            ucHistoryListView1.Size = new Size(523, 664);
            ucHistoryListView1.TabIndex = 1;
            // 
            // ucEditListView1
            // 
            ucEditListView1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ucEditListView1.BorderStyle = BorderStyle.FixedSingle;
            ucEditListView1.Dock = DockStyle.Fill;
            ucEditListView1.Location = new Point(0, 0);
            ucEditListView1.Name = "ucEditListView1";
            ucEditListView1.Size = new Size(523, 664);
            ucEditListView1.TabIndex = 9;
            ucEditListView1.Visible = false;
            // 
            // ClipBoardViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 664);
            Controls.Add(ucEditListView1);
            Controls.Add(ucHistoryListView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClipBoardViewer";
            Text = "Base64 clipboard convertor";
            TopMost = true;
            Shown += ClipBoardViewer_Shown;
            SizeChanged += ClipBoardViewer_SizeChanged;
            Resize += ClipBoardViewer_Resize;
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton File;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripDropDownButton Edit;
        private ToolStripMenuItem converToTxtToolStripMenuItem;
        private ToolStripMenuItem clearHistoryToolStripMenuItem;
        private ToolStripDropDownButton Help;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem deactivateToolStripMenuItem;
        private ToolStripMenuItem copySelectedToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem1;
        private ToolStripMenuItem DisableMenuStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem editSelectedToolStripMenuItem;
        private ToolStripMenuItem clearClipboardToolStripMenuItem;
        private NotifyIcon NotifyIcon;
        private decoder.ucHistoryListView ucHistoryListView1;
        private decoder.ucEditListView ucEditListView1;
    }
}
