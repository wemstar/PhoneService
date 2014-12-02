namespace TelephoneServiceDesktop.controls
{
    partial class NewIssiueControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.bSubmmit = new System.Windows.Forms.Button();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.dgvClientList);
            this.flowLayoutPanel1.Controls.Add(this.dgvPhones);
            this.flowLayoutPanel1.Controls.Add(this.bSubmmit);
            this.flowLayoutPanel1.Controls.Add(this.tbComment);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(714, 487);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // dgvClientList
            // 
            this.dgvClientList.AllowUserToAddRows = false;
            this.dgvClientList.AllowUserToDeleteRows = false;
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClientList.Location = new System.Drawing.Point(0, 3);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.ReadOnly = true;
            this.dgvClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientList.Size = new System.Drawing.Size(711, 178);
            this.dgvClientList.TabIndex = 0;
            // 
            // dgvPhones
            // 
            this.dgvPhones.AllowUserToAddRows = false;
            this.dgvPhones.AllowUserToDeleteRows = false;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPhones.Location = new System.Drawing.Point(3, 187);
            this.dgvPhones.MultiSelect = false;
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.ReadOnly = true;
            this.dgvPhones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhones.Size = new System.Drawing.Size(708, 150);
            this.dgvPhones.TabIndex = 1;
            // 
            // bSubmmit
            // 
            this.bSubmmit.Location = new System.Drawing.Point(597, 343);
            this.bSubmmit.Name = "bSubmmit";
            this.bSubmmit.Size = new System.Drawing.Size(114, 23);
            this.bSubmmit.TabIndex = 2;
            this.bSubmmit.Text = "Create Issiue";
            this.bSubmmit.UseVisualStyleBackColor = true;
            this.bSubmmit.Click += new System.EventHandler(this.bSubmmit_Click);
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(310, 343);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(281, 20);
            this.tbComment.TabIndex = 3;
            // 
            // NewIssiueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "NewIssiueControl";
            this.Size = new System.Drawing.Size(714, 487);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvClientList;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.Button bSubmmit;
        private System.Windows.Forms.TextBox tbComment;
    }
}
