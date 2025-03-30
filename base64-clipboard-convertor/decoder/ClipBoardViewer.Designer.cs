﻿namespace Base64ClipboardDecoder
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
            closeToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            panel1 = new Panel();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            File = new ToolStripDropDownButton();
            toolStripMenuItem5 = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            Edit = new ToolStripDropDownButton();
            formatToolStripMenuItem = new ToolStripMenuItem();
            copySelectedToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            Help = new ToolStripDropDownButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            History = new ListBox();
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
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(94, 26);
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(93, 22);
            closeToolStripMenuItem1.Text = "Exit";
            closeToolStripMenuItem1.Click += closeToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Quit";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = SystemColors.ControlLight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(486, 8);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = SystemColors.ControlLight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(453, 9);
            button2.Name = "button2";
            button2.Size = new Size(28, 28);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            panel1.Controls.Add(button2);
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
            label2.Location = new Point(11, 10);
            label2.Name = "label2";
            label2.Size = new Size(242, 25);
            label2.TabIndex = 8;
            label2.Text = "Base64 clipboard convertor";
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
            File.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, quitToolStripMenuItem });
            File.ImageTransparentColor = Color.Magenta;
            File.Name = "File";
            File.Size = new Size(45, 24);
            File.Text = "File";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(128, 24);
            toolStripMenuItem5.Text = "Disable";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
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
            Edit.DropDownItems.AddRange(new ToolStripItem[] { formatToolStripMenuItem, copySelectedToolStripMenuItem, toolStripMenuItem4 });
            Edit.ImageTransparentColor = Color.Magenta;
            Edit.Name = "Edit";
            Edit.Size = new Size(48, 24);
            Edit.Text = "Edit";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(171, 24);
            formatToolStripMenuItem.Text = "Convert to txt";
            formatToolStripMenuItem.Click += formatToolStripMenuItem_Click;
            // 
            // copySelectedToolStripMenuItem
            // 
            copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            copySelectedToolStripMenuItem.Size = new Size(171, 24);
            copySelectedToolStripMenuItem.Text = "Copy selected";
            copySelectedToolStripMenuItem.Click += copySelectedToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(171, 24);
            toolStripMenuItem4.Text = "Clear History";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click_1;
            // 
            // Help
            // 
            Help.AutoToolTip = false;
            Help.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Help.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            Help.ImageTransparentColor = Color.Magenta;
            Help.Name = "Help";
            Help.Size = new Size(54, 24);
            Help.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(119, 24);
            toolStripMenuItem1.Text = "Help";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(119, 24);
            toolStripMenuItem2.Text = "About";
            // 
            // History
            // 
            History.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            History.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            History.HorizontalScrollbar = true;
            History.ItemHeight = 21;
            History.Location = new Point(0, 93);
            History.Name = "History";
            History.Size = new Size(523, 571);
            History.TabIndex = 10;
            // 
            // ClipBoardViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 664);
            ControlBox = false;
            Controls.Add(History);
            Controls.Add(toolStrip1);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private ContextMenuStrip contextMenuStrip2;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton File;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripDropDownButton Edit;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripDropDownButton Help;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem5;
        private Label label2;
        private ToolStripMenuItem copySelectedToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem1;
    }
}
