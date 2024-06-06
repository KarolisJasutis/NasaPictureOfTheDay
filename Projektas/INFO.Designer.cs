namespace Projektas
{
    partial class INFO
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
            this.lblExpl = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lbllink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblExpl
            // 
            this.lblExpl.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpl.Location = new System.Drawing.Point(12, 47);
            this.lblExpl.Name = "lblExpl";
            this.lblExpl.Size = new System.Drawing.Size(776, 334);
            this.lblExpl.TabIndex = 11;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(12, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(581, 29);
            this.lblType.TabIndex = 12;
            // 
            // lbllink
            // 
            this.lbllink.Location = new System.Drawing.Point(13, 417);
            this.lbllink.Name = "lbllink";
            this.lbllink.Size = new System.Drawing.Size(748, 23);
            this.lbllink.TabIndex = 14;
            this.lbllink.TabStop = true;
            this.lbllink.Text = "Open picture/video in browser";
            this.lbllink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbllink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllink_LinkClicked);
            // 
            // INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllink);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblExpl);
            this.Name = "INFO";
            this.Text = "INFO";
            this.Load += new System.EventHandler(this.INFO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExpl;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.LinkLabel lbllink;
    }
}