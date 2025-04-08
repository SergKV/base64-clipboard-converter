namespace decoder
{
    partial class ucHistoryListView
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
            history = new ListBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            disableToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            convertToTxtToolStripMenuItem = new ToolStripMenuItem();
            editSelectedItemStripMenuItem = new ToolStripMenuItem();
            copySelectedItemStripMenuItem = new ToolStripMenuItem();
            deleteSelectedToolStripMenuItem = new ToolStripMenuItem();
            deleteAllToolStripMenuItem = new ToolStripMenuItem();
            clearClipboardToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            minimizeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // history
            // 
            history.Dock = DockStyle.Fill;
            history.DrawMode = DrawMode.OwnerDrawVariable;
            history.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            history.HorizontalScrollbar = true;
            history.IntegralHeight = false;
            history.ItemHeight = 21;
            history.Location = new Point(0, 28);
            history.Name = "history";
            history.Size = new Size(537, 567);
            history.TabIndex = 12;
            history.MouseDoubleClick += EditSelectedToolStripMenuItem_Click;
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Segoe UI", 11.25F);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(537, 28);
            menuStrip.TabIndex = 13;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disableToolStripMenuItem, saveAsToolStripMenuItem, minimizeToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // disableToolStripMenuItem
            // 
            disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            disableToolStripMenuItem.Size = new Size(180, 24);
            disableToolStripMenuItem.Text = "Disable";
            disableToolStripMenuItem.Click += DisableToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 24);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += QuitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertToTxtToolStripMenuItem, editSelectedItemStripMenuItem, copySelectedItemStripMenuItem, deleteSelectedToolStripMenuItem, deleteAllToolStripMenuItem, clearClipboardToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(47, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // convertToTxtToolStripMenuItem
            // 
            convertToTxtToolStripMenuItem.Name = "convertToTxtToolStripMenuItem";
            convertToTxtToolStripMenuItem.Size = new Size(181, 24);
            convertToTxtToolStripMenuItem.Text = "Convert to txt";
            convertToTxtToolStripMenuItem.Click += ConvertToTxtToolStripMenuItem_Click;
            // 
            // editSelectedItemStripMenuItem
            // 
            editSelectedItemStripMenuItem.Name = "editSelectedItemStripMenuItem";
            editSelectedItemStripMenuItem.Size = new Size(181, 24);
            editSelectedItemStripMenuItem.Text = "Edit selected";
            editSelectedItemStripMenuItem.Click += EditSelectedToolStripMenuItem_Click;
            // 
            // copySelectedItemStripMenuItem
            // 
            copySelectedItemStripMenuItem.Name = "copySelectedItemStripMenuItem";
            copySelectedItemStripMenuItem.Size = new Size(181, 24);
            copySelectedItemStripMenuItem.Text = "Copy selected";
            copySelectedItemStripMenuItem.Click += CopySelectedToolStripMenuItem_Click;
            // 
            // deleteSelectedToolStripMenuItem
            // 
            deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            deleteSelectedToolStripMenuItem.Size = new Size(181, 24);
            deleteSelectedToolStripMenuItem.Text = "Delete selected";
            deleteSelectedToolStripMenuItem.Click += deleteSelectedToolStripMenuItem_Click;
            // 
            // deleteAllToolStripMenuItem
            // 
            deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            deleteAllToolStripMenuItem.Size = new Size(181, 24);
            deleteAllToolStripMenuItem.Text = "Delete all";
            deleteAllToolStripMenuItem.Click += ClearHistoryToolStripMenuItem_Click;
            // 
            // clearClipboardToolStripMenuItem
            // 
            clearClipboardToolStripMenuItem.Name = "clearClipboardToolStripMenuItem";
            clearClipboardToolStripMenuItem.Size = new Size(181, 24);
            clearClipboardToolStripMenuItem.Text = "Clear clipboard";
            clearClipboardToolStripMenuItem.Click += ClearClipboardToolStripMenuItem_Click;
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
            // minimizeToolStripMenuItem
            // 
            minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            minimizeToolStripMenuItem.Size = new Size(180, 24);
            minimizeToolStripMenuItem.Text = "Minimize";
            minimizeToolStripMenuItem.Click += minimizeToolStripMenuItem_Click;
            // 
            // ucHistoryListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(history);
            Controls.Add(menuStrip);
            Name = "ucHistoryListView";
            Size = new Size(537, 595);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox history;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem disableToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem convertToTxtToolStripMenuItem;
        private ToolStripMenuItem editSelectedItemStripMenuItem;
        private ToolStripMenuItem copySelectedItemStripMenuItem;
        private ToolStripMenuItem deleteAllToolStripMenuItem;
        private ToolStripMenuItem clearClipboardToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
    }
}
