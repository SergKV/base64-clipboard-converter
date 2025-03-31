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
            panel1 = new Panel();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            File = new ToolStripDropDownButton();
            deactivateToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            Edit = new ToolStripDropDownButton();
            converToTxtToolStripMenuItem = new ToolStripMenuItem();
            copySelectedToolStripMenuItem = new ToolStripMenuItem();
            clearHistoryToolStripMenuItem = new ToolStripMenuItem();
            Help = new ToolStripDropDownButton();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            History = new ListBox();
            exportToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonMaximize);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 46);
            panel1.TabIndex = 8;
            panel1.MouseDoubleClick += button2_Click;
            panel1.MouseDown += mouse_Down;
            panel1.MouseMove += mouse_Move;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Image = decoder.Properties.Resources.icons8_64_bit_32;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(11, 10);
            label2.Name = "label2";
            label2.Size = new Size(272, 25);
            label2.TabIndex = 8;
            label2.Text = "      Base64 clipboard convertor";
            label2.MouseDoubleClick += button2_Click;
            label2.MouseDown += mouse_Down;
            label2.MouseMove += mouse_Move;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { File, Edit, Help });
            toolStrip1.Location = new Point(0, 46);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(523, 27);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
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
            deactivateToolStripMenuItem.Size = new Size(180, 24);
            deactivateToolStripMenuItem.Text = "Disable";
            deactivateToolStripMenuItem.Click += toolStripMenuItem5_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(180, 24);
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
            // History
            // 
            History.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            History.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            History.HorizontalScrollbar = true;
            History.ItemHeight = 21;
            History.Location = new Point(0, 72);
            History.Name = "History";
            History.Size = new Size(523, 592);
            History.TabIndex = 10;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 24);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // ClipBoardViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 664);
            ControlBox = false;
            Controls.Add(History);
            Controls.Add(toolStrip1);
            Controls.Add(buttonClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClipBoardViewer";
            Text = "Base64Decoder";
            Resize += ClipBoardViewer_Resize;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox History;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem3;
        private Button buttonClose;
        private Button buttonMaximize;
        private ContextMenuStrip contextMenuStrip2;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton File;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripDropDownButton Edit;
        private ToolStripMenuItem converToTxtToolStripMenuItem;
        private ToolStripMenuItem clearHistoryToolStripMenuItem;
        private ToolStripDropDownButton Help;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem deactivateToolStripMenuItem;
        private Label label2;
        private ToolStripMenuItem copySelectedToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem1;
        private ToolStripMenuItem disableToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
    }
}
