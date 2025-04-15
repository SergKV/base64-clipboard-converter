namespace decoder
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            LogoImage = new PictureBox();
            Appname_Label = new Label();
            Version_Label = new Label();
            Description_Label = new Label();
            Licensing_Label = new Label();
            UrlLink_Label = new Label();
            Url_Link = new LinkLabel();
            DisctributionNote_Label = new Label();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoImage).BeginInit();
            SuspendLayout();
            // 
            // LogoImage
            // 
            LogoImage.BackgroundImage = Properties.Resources.icons8_64_bit_32;
            LogoImage.BackgroundImageLayout = ImageLayout.Zoom;
            LogoImage.Dock = DockStyle.Top;
            LogoImage.Location = new Point(0, 0);
            LogoImage.Name = "LogoImage";
            LogoImage.Size = new Size(418, 69);
            LogoImage.TabIndex = 10;
            LogoImage.TabStop = false;
            // 
            // Appname_Label
            // 
            Appname_Label.AutoSize = true;
            Appname_Label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Appname_Label.Location = new Point(101, 91);
            Appname_Label.Name = "Appname_Label";
            Appname_Label.Size = new Size(212, 21);
            Appname_Label.TabIndex = 11;
            Appname_Label.Text = "Base64 clipboard convertor";
            // 
            // Version_Label
            // 
            Version_Label.AutoSize = true;
            Version_Label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Version_Label.Location = new Point(177, 125);
            Version_Label.Name = "Version_Label";
            Version_Label.Size = new Size(58, 21);
            Version_Label.TabIndex = 12;
            Version_Label.Text = "0.0.0.0";
            // 
            // Description_Label
            // 
            Description_Label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Description_Label.Location = new Point(12, 164);
            Description_Label.Name = "Description_Label";
            Description_Label.Size = new Size(394, 84);
            Description_Label.TabIndex = 13;
            Description_Label.Text = "  A utility application designed to seamlessly convert Base64-encoded strings into plain text and automatically copy the result to your clipboard for efficient integration and use.";
            // 
            // Licensing_Label
            // 
            Licensing_Label.Font = new Font("Segoe UI", 11.25F);
            Licensing_Label.Location = new Point(12, 362);
            Licensing_Label.Name = "Licensing_Label";
            Licensing_Label.Size = new Size(394, 51);
            Licensing_Label.TabIndex = 14;
            Licensing_Label.Text = "This project is open-source and licensed under the MIT License.";
            // 
            // UrlLink_Label
            // 
            UrlLink_Label.AutoSize = true;
            UrlLink_Label.Font = new Font("Segoe UI", 11.25F);
            UrlLink_Label.Location = new Point(13, 419);
            UrlLink_Label.Name = "UrlLink_Label";
            UrlLink_Label.Size = new Size(228, 20);
            UrlLink_Label.TabIndex = 15;
            UrlLink_Label.Text = "The source code can be found at:";
            // 
            // Url_Link
            // 
            Url_Link.AutoSize = true;
            Url_Link.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Url_Link.Location = new Point(247, 419);
            Url_Link.Name = "Url_Link";
            Url_Link.Size = new Size(42, 20);
            Url_Link.TabIndex = 16;
            Url_Link.TabStop = true;
            Url_Link.Text = "[link]";
            Url_Link.LinkClicked += linkLabel1_LinkClicked;
            // 
            // DisctributionNote_Label
            // 
            DisctributionNote_Label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisctributionNote_Label.Location = new Point(12, 264);
            DisctributionNote_Label.Name = "DisctributionNote_Label";
            DisctributionNote_Label.Size = new Size(394, 84);
            DisctributionNote_Label.TabIndex = 18;
            DisctributionNote_Label.Text = "This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.";
            // 
            // Close
            // 
            Close.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close.Location = new Point(305, 454);
            Close.Name = "Close";
            Close.Size = new Size(101, 34);
            Close.TabIndex = 17;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 501);
            Controls.Add(DisctributionNote_Label);
            Controls.Add(Close);
            Controls.Add(Url_Link);
            Controls.Add(UrlLink_Label);
            Controls.Add(Licensing_Label);
            Controls.Add(Description_Label);
            Controls.Add(Version_Label);
            Controls.Add(Appname_Label);
            Controls.Add(LogoImage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AboutForm";
            Text = "About Base64 clipboard convertor";
            TopMost = true;
            Load += AboutForm_Loaded;
            ((System.ComponentModel.ISupportInitialize)LogoImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox LogoImage;
        private Label Appname_Label;
        private Label Version_Label;
        private Label Description_Label;
        private Label Licensing_Label;
        private Label UrlLink_Label;
        private LinkLabel Url_Link;
        private Label DisctributionNote_Label;
        private Button Close;
    }
}