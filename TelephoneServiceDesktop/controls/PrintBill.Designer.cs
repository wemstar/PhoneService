namespace TelephoneServiceDesktop.controls
{
    partial class PrintBill
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
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.dgvIssiues = new System.Windows.Forms.DataGridView();
            this.bBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssiues)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(3, 172);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(489, 201);
            this.rtbResult.TabIndex = 0;
            this.rtbResult.Text = "";
            // 
            // dgvIssiues
            // 
            this.dgvIssiues.AllowUserToAddRows = false;
            this.dgvIssiues.AllowUserToDeleteRows = false;
            this.dgvIssiues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssiues.Location = new System.Drawing.Point(3, 3);
            this.dgvIssiues.Name = "dgvIssiues";
            this.dgvIssiues.ReadOnly = true;
            this.dgvIssiues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssiues.Size = new System.Drawing.Size(489, 150);
            this.dgvIssiues.TabIndex = 1;
            // 
            // bBill
            // 
            this.bBill.Location = new System.Drawing.Point(417, 379);
            this.bBill.Name = "bBill";
            this.bBill.Size = new System.Drawing.Size(75, 23);
            this.bBill.TabIndex = 2;
            this.bBill.Text = "Bill";
            this.bBill.UseVisualStyleBackColor = true;
            this.bBill.Click += new System.EventHandler(this.bBill_Click);
            // 
            // PrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bBill);
            this.Controls.Add(this.dgvIssiues);
            this.Controls.Add(this.rtbResult);
            this.Name = "PrintBill";
            this.Size = new System.Drawing.Size(495, 405);
            this.Load += new System.EventHandler(this.PrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssiues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.DataGridView dgvIssiues;
        private System.Windows.Forms.Button bBill;
    }
}
