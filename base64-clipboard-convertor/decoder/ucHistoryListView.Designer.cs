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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DisableToolStripMenuItem, exportToolStripMenuItem1, quitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // DisableToolStripMenuItem
            // 
            DisableToolStripMenuItem.Name = "DisableToolStripMenuItem";
            DisableToolStripMenuItem.Size = new Size(180, 24);
            DisableToolStripMenuItem.Text = "Disable";
            DisableToolStripMenuItem.Click += DisableToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem1
            // 
            exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            exportToolStripMenuItem1.Size = new Size(180, 24);
            exportToolStripMenuItem1.Text = "Export";
            exportToolStripMenuItem1.Click += ExportToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem1
            // 
            quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            quitToolStripMenuItem1.Size = new Size(180, 24);
            quitToolStripMenuItem1.Text = "Exit";
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
    }
}
