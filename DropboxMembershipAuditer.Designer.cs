namespace DBMembershipAuditer
{
    partial class DropboxMembershipAuditer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropboxMembershipAuditer));
            this.gbHeaderLine = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccessToken = new MetroFramework.Controls.MetroTextBox();
            this.lblAccesstoken = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblExportCsv = new MetroFramework.Controls.MetroLabel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtFilePath = new MetroFramework.Controls.MetroTextBox();
            this.DVGResults = new MetroFramework.Controls.MetroGrid();
            this.txtLimit = new MetroFramework.Controls.MetroTextBox();
            this.lblLimit = new MetroFramework.Controls.MetroLabel();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.pbMemberInformationProgress = new MetroFramework.Controls.MetroProgressBar();
            this.TTLimit = new MetroFramework.Components.MetroToolTip();
            this.label2 = new System.Windows.Forms.Label();
            this.SVCsvSave = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGResults)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHeaderLine
            // 
            this.gbHeaderLine.Location = new System.Drawing.Point(23, 63);
            this.gbHeaderLine.Name = "gbHeaderLine";
            this.gbHeaderLine.Size = new System.Drawing.Size(450, 2);
            this.gbHeaderLine.TabIndex = 0;
            this.gbHeaderLine.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccessToken);
            this.groupBox1.Controls.Add(this.lblAccesstoken);
            this.groupBox1.Location = new System.Drawing.Point(24, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Lines = new string[0];
            this.txtAccessToken.Location = new System.Drawing.Point(19, 38);
            this.txtAccessToken.MaxLength = 32767;
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.PasswordChar = '\0';
            this.txtAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccessToken.SelectedText = "";
            this.txtAccessToken.Size = new System.Drawing.Size(137, 23);
            this.txtAccessToken.TabIndex = 1;
            this.txtAccessToken.UseSelectable = true;
            // 
            // lblAccesstoken
            // 
            this.lblAccesstoken.AutoSize = true;
            this.lblAccesstoken.Location = new System.Drawing.Point(19, 16);
            this.lblAccesstoken.Name = "lblAccesstoken";
            this.lblAccesstoken.Size = new System.Drawing.Size(83, 19);
            this.lblAccesstoken.TabIndex = 0;
            this.lblAccesstoken.Text = "Access token";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblExportCsv);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Controls.Add(this.DVGResults);
            this.groupBox2.Controls.Add(this.txtLimit);
            this.groupBox2.Controls.Add(this.lblLimit);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.pbMemberInformationProgress);
            this.groupBox2.Location = new System.Drawing.Point(24, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 299);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lblExportCsv
            // 
            this.lblExportCsv.AutoSize = true;
            this.lblExportCsv.Location = new System.Drawing.Point(184, 16);
            this.lblExportCsv.Name = "lblExportCsv";
            this.lblExportCsv.Size = new System.Drawing.Size(76, 19);
            this.lblExportCsv.TabIndex = 0;
            this.lblExportCsv.Text = "Export CSV";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(350, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Lines = new string[0];
            this.txtFilePath.Location = new System.Drawing.Point(184, 50);
            this.txtFilePath.MaxLength = 32767;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(150, 23);
            this.txtFilePath.TabIndex = 3;
            this.TTLimit.SetToolTip(this.txtFilePath, "Click browse to specify where you would like the CSV to be saved.");
            this.txtFilePath.UseSelectable = true;
            // 
            // DVGResults
            // 
            this.DVGResults.AllowUserToResizeRows = false;
            this.DVGResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DVGResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DVGResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DVGResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVGResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DVGResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DVGResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.DVGResults.EnableHeadersVisualStyles = false;
            this.DVGResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DVGResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DVGResults.Location = new System.Drawing.Point(19, 166);
            this.DVGResults.Name = "DVGResults";
            this.DVGResults.ReadOnly = true;
            this.DVGResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVGResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DVGResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DVGResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVGResults.Size = new System.Drawing.Size(409, 118);
            this.DVGResults.TabIndex = 0;
            this.DVGResults.TabStop = false;
            // 
            // txtLimit
            // 
            this.txtLimit.Lines = new string[0];
            this.txtLimit.Location = new System.Drawing.Point(19, 50);
            this.txtLimit.MaxLength = 32767;
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.PasswordChar = '\0';
            this.txtLimit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLimit.SelectedText = "";
            this.txtLimit.Size = new System.Drawing.Size(137, 23);
            this.txtLimit.TabIndex = 2;
            this.TTLimit.SetToolTip(this.txtLimit, "This value sets the maximum allowed results which are\r\nreturned from the web serv" +
        "ice. Left unchanged\r\nthe limit is set at 1000, the maximum allowed is 1000.");
            this.txtLimit.UseSelectable = true;
            this.txtLimit.TextChanged += new System.EventHandler(this.txtLimit_TextChanged);
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(19, 16);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(37, 19);
            this.lblLimit.TabIndex = 0;
            this.lblLimit.Text = "Limit";
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(19, 89);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // pbMemberInformationProgress
            // 
            this.pbMemberInformationProgress.Location = new System.Drawing.Point(19, 127);
            this.pbMemberInformationProgress.Name = "pbMemberInformationProgress";
            this.pbMemberInformationProgress.Size = new System.Drawing.Size(409, 23);
            this.pbMemberInformationProgress.TabIndex = 0;
            // 
            // TTLimit
            // 
            this.TTLimit.Style = MetroFramework.MetroColorStyle.Blue;
            this.TTLimit.StyleManager = null;
            this.TTLimit.Tag = "";
            this.TTLimit.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyright 2015";
            // 
            // SVCsvSave
            // 
            this.SVCsvSave.FileOk += new System.ComponentModel.CancelEventHandler(this.SVCsvSave_FileOk);
            // 
            // DropboxMembershipAuditer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(512, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHeaderLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DropboxMembershipAuditer";
            this.Resizable = false;
            this.Text = "DB Membership Auditer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeaderLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtAccessToken;
        private MetroFramework.Controls.MetroLabel lblAccesstoken;
        private MetroFramework.Controls.MetroTextBox txtLimit;
        private MetroFramework.Controls.MetroLabel lblLimit;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroProgressBar pbMemberInformationProgress;
        private MetroFramework.Controls.MetroGrid DVGResults;
        private MetroFramework.Components.MetroToolTip TTLimit;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel lblExportCsv;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtFilePath;
        private System.Windows.Forms.SaveFileDialog SVCsvSave;
    }
}

