namespace DBMembershipAuditer
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.lblCopyright = new MetroFramework.Controls.MetroLabel();
            this.pbLogomain = new System.Windows.Forms.PictureBox();
            this.gbSeparator = new System.Windows.Forms.GroupBox();
            this.lblAppTitle = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogomain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblVersion.Location = new System.Drawing.Point(314, 211);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(59, 15);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 1.0";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCopyright.Location = new System.Drawing.Point(314, 237);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(81, 15);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright 2015";
            // 
            // pbLogomain
            // 
            this.pbLogomain.Image = ((System.Drawing.Image)(resources.GetObject("pbLogomain.Image")));
            this.pbLogomain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogomain.InitialImage")));
            this.pbLogomain.Location = new System.Drawing.Point(333, 12);
            this.pbLogomain.Name = "pbLogomain";
            this.pbLogomain.Size = new System.Drawing.Size(170, 140);
            this.pbLogomain.TabIndex = 3;
            this.pbLogomain.TabStop = false;
            // 
            // gbSeparator
            // 
            this.gbSeparator.Location = new System.Drawing.Point(22, 175);
            this.gbSeparator.MaximumSize = new System.Drawing.Size(500, 5);
            this.gbSeparator.Name = "gbSeparator";
            this.gbSeparator.Size = new System.Drawing.Size(450, 2);
            this.gbSeparator.TabIndex = 4;
            this.gbSeparator.TabStop = false;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAppTitle.Location = new System.Drawing.Point(22, 132);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(194, 25);
            this.lblAppTitle.TabIndex = 5;
            this.lblAppTitle.Text = "DB Membership Auditer";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.ControlBox = false;
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.gbSeparator);
            this.Controls.Add(this.pbLogomain);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblVersion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogomain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblVersion;
        private MetroFramework.Controls.MetroLabel lblCopyright;
        private System.Windows.Forms.PictureBox pbLogomain;
        private System.Windows.Forms.GroupBox gbSeparator;
        private MetroFramework.Controls.MetroLabel lblAppTitle;
    }
}