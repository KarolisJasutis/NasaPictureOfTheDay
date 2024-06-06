namespace Projektas
{
    partial class FormPOTD
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Calendar1 = new System.Windows.Forms.MonthCalendar();
            this.pbPOTD = new System.Windows.Forms.PictureBox();
            this.wbVOTD = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnInfoSaved = new System.Windows.Forms.Button();
            this.btnRemoveSaved = new System.Windows.Forms.Button();
            this.wbSaved = new System.Windows.Forms.WebBrowser();
            this.pbSaved = new System.Windows.Forms.PictureBox();
            this.lbSaved = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnNotes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPOTD)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1348, 840);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnInfo);
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.Calendar1);
            this.tabPage1.Controls.Add(this.pbPOTD);
            this.tabPage1.Controls.Add(this.wbVOTD);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1340, 814);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(120, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Add to favorite";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Enabled = false;
            this.btnInfo.Location = new System.Drawing.Point(39, 248);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "More info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(302, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(946, 25);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calendar1
            // 
            this.Calendar1.Location = new System.Drawing.Point(21, 74);
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 8;
            this.Calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar1_DateChanged);
            // 
            // pbPOTD
            // 
            this.pbPOTD.Location = new System.Drawing.Point(302, 31);
            this.pbPOTD.Name = "pbPOTD";
            this.pbPOTD.Size = new System.Drawing.Size(1029, 777);
            this.pbPOTD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPOTD.TabIndex = 7;
            this.pbPOTD.TabStop = false;
            // 
            // wbVOTD
            // 
            this.wbVOTD.Location = new System.Drawing.Point(302, 31);
            this.wbVOTD.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbVOTD.Name = "wbVOTD";
            this.wbVOTD.Size = new System.Drawing.Size(1029, 777);
            this.wbVOTD.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnNotes);
            this.tabPage2.Controls.Add(this.rtbNotes);
            this.tabPage2.Controls.Add(this.btnDownload);
            this.tabPage2.Controls.Add(this.btnInfoSaved);
            this.tabPage2.Controls.Add(this.btnRemoveSaved);
            this.tabPage2.Controls.Add(this.wbSaved);
            this.tabPage2.Controls.Add(this.pbSaved);
            this.tabPage2.Controls.Add(this.lbSaved);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1340, 814);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Favorite";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(169, 377);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(99, 23);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download picture";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnInfoSaved
            // 
            this.btnInfoSaved.Enabled = false;
            this.btnInfoSaved.Location = new System.Drawing.Point(87, 377);
            this.btnInfoSaved.Name = "btnInfoSaved";
            this.btnInfoSaved.Size = new System.Drawing.Size(75, 23);
            this.btnInfoSaved.TabIndex = 10;
            this.btnInfoSaved.Text = "More info";
            this.btnInfoSaved.UseVisualStyleBackColor = true;
            this.btnInfoSaved.Click += new System.EventHandler(this.btnInfoSaved_Click);
            // 
            // btnRemoveSaved
            // 
            this.btnRemoveSaved.Location = new System.Drawing.Point(6, 377);
            this.btnRemoveSaved.Name = "btnRemoveSaved";
            this.btnRemoveSaved.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSaved.TabIndex = 9;
            this.btnRemoveSaved.Text = "Remove";
            this.btnRemoveSaved.UseVisualStyleBackColor = true;
            this.btnRemoveSaved.Click += new System.EventHandler(this.btnRemoveSaved_Click);
            // 
            // wbSaved
            // 
            this.wbSaved.Location = new System.Drawing.Point(364, 6);
            this.wbSaved.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSaved.Name = "wbSaved";
            this.wbSaved.Size = new System.Drawing.Size(967, 777);
            this.wbSaved.TabIndex = 7;
            // 
            // pbSaved
            // 
            this.pbSaved.Location = new System.Drawing.Point(364, 6);
            this.pbSaved.Name = "pbSaved";
            this.pbSaved.Size = new System.Drawing.Size(967, 783);
            this.pbSaved.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSaved.TabIndex = 8;
            this.pbSaved.TabStop = false;
            // 
            // lbSaved
            // 
            this.lbSaved.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaved.FormattingEnabled = true;
            this.lbSaved.ItemHeight = 19;
            this.lbSaved.Location = new System.Drawing.Point(6, 6);
            this.lbSaved.Name = "lbSaved";
            this.lbSaved.Size = new System.Drawing.Size(352, 365);
            this.lbSaved.TabIndex = 0;
            this.lbSaved.SelectedIndexChanged += new System.EventHandler(this.lbSaved_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Enabled = false;
            this.rtbNotes.Location = new System.Drawing.Point(6, 435);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(351, 210);
            this.rtbNotes.TabIndex = 12;
            this.rtbNotes.Text = "";
            // 
            // btnNotes
            // 
            this.btnNotes.Enabled = false;
            this.btnNotes.Location = new System.Drawing.Point(6, 651);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(95, 23);
            this.btnNotes.TabIndex = 13;
            this.btnNotes.Text = "Save notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Notes";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 44);
            this.label2.TabIndex = 14;
            this.label2.Text = "Click on the date to show Nasa \"Picture of The Day\" of that date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPOTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 852);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPOTD";
            this.Text = "NASA Picture of the day";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPOTD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser wbVOTD;
        private System.Windows.Forms.PictureBox pbPOTD;
        private System.Windows.Forms.MonthCalendar Calendar1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInfo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbSaved;
        private System.Windows.Forms.WebBrowser wbSaved;
        private System.Windows.Forms.PictureBox pbSaved;
        private System.Windows.Forms.Button btnInfoSaved;
        private System.Windows.Forms.Button btnRemoveSaved;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label label2;
    }
}

