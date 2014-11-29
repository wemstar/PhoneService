namespace TelephoneServiceDesktop.forms
{
    partial class ChangeStatus
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.bSubbmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Destroyed",
            "Closed",
            "Resolved",
            "Open"});
            this.cbStatus.Location = new System.Drawing.Point(12, 12);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 0;
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(12, 51);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(229, 196);
            this.rtbComment.TabIndex = 1;
            this.rtbComment.Text = "";
            // 
            // bSubbmit
            // 
            this.bSubbmit.Location = new System.Drawing.Point(12, 280);
            this.bSubbmit.Name = "bSubbmit";
            this.bSubbmit.Size = new System.Drawing.Size(75, 23);
            this.bSubbmit.TabIndex = 2;
            this.bSubbmit.Text = "Subbmit";
            this.bSubbmit.UseVisualStyleBackColor = true;
            this.bSubbmit.Click += new System.EventHandler(this.bSubbmit_Click);
            // 
            // ChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 394);
            this.Controls.Add(this.bSubbmit);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.cbStatus);
            this.Name = "ChangeStatus";
            this.Text = "ChangeStatus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Button bSubbmit;
    }
}