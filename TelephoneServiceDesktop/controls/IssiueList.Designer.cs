namespace TelephoneServiceDesktop.controls
{
    partial class IssiueList
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
            this.dgvIssiueList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssiueList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIssiueList
            // 
            this.dgvIssiueList.AllowUserToAddRows = false;
            this.dgvIssiueList.AllowUserToDeleteRows = false;
            this.dgvIssiueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssiueList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssiueList.Location = new System.Drawing.Point(0, 0);
            this.dgvIssiueList.Name = "dgvIssiueList";
            this.dgvIssiueList.ReadOnly = true;
            this.dgvIssiueList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssiueList.Size = new System.Drawing.Size(648, 399);
            this.dgvIssiueList.TabIndex = 0;
            this.dgvIssiueList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssiueList_CellDoubleClick);
            // 
            // IssiueList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvIssiueList);
            this.Name = "IssiueList";
            this.Size = new System.Drawing.Size(648, 399);
            this.Load += new System.EventHandler(this.IssiueList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssiueList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIssiueList;
    }
}
