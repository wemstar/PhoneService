namespace TelephoneServiceDesktop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewIssiue = new System.Windows.Forms.ToolStripButton();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tsbNewClient = new System.Windows.Forms.ToolStripButton();
            this.tsbNewPhone = new System.Windows.Forms.ToolStripButton();
            this.tsbIssiueList = new System.Windows.Forms.ToolStripButton();
            this.tsbPrintBill = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewIssiue,
            this.tsbNewClient,
            this.tsbNewPhone,
            this.tsbIssiueList,
            this.tsbPrintBill});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(623, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewIssiue
            // 
            this.tsbNewIssiue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewIssiue.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewIssiue.Image")));
            this.tsbNewIssiue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewIssiue.Name = "tsbNewIssiue";
            this.tsbNewIssiue.Size = new System.Drawing.Size(23, 22);
            this.tsbNewIssiue.Text = "toolStripButton1";
            this.tsbNewIssiue.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 25);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(623, 460);
            this.tcMain.TabIndex = 1;
            // 
            // tsbNewClient
            // 
            this.tsbNewClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewClient.Image")));
            this.tsbNewClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewClient.Name = "tsbNewClient";
            this.tsbNewClient.Size = new System.Drawing.Size(23, 22);
            this.tsbNewClient.Text = "toolStripButton2";
            this.tsbNewClient.Click += new System.EventHandler(this.tsbNewClient_Click);
            // 
            // tsbNewPhone
            // 
            this.tsbNewPhone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewPhone.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewPhone.Image")));
            this.tsbNewPhone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewPhone.Name = "tsbNewPhone";
            this.tsbNewPhone.Size = new System.Drawing.Size(23, 22);
            this.tsbNewPhone.Text = "toolStripButton3";
            this.tsbNewPhone.Click += new System.EventHandler(this.tsbNewPhone_Click);
            // 
            // tsbIssiueList
            // 
            this.tsbIssiueList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIssiueList.Image = ((System.Drawing.Image)(resources.GetObject("tsbIssiueList.Image")));
            this.tsbIssiueList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIssiueList.Name = "tsbIssiueList";
            this.tsbIssiueList.Size = new System.Drawing.Size(23, 22);
            this.tsbIssiueList.Text = "toolStripButton4";
            this.tsbIssiueList.Click += new System.EventHandler(this.tsbIssiueList_Click);
            // 
            // tsbPrintBill
            // 
            this.tsbPrintBill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrintBill.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintBill.Image")));
            this.tsbPrintBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintBill.Name = "tsbPrintBill";
            this.tsbPrintBill.Size = new System.Drawing.Size(23, 22);
            this.tsbPrintBill.Text = "toolStripButton5";
            this.tsbPrintBill.Click += new System.EventHandler(this.tsbPrintBill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 485);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewIssiue;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ToolStripButton tsbNewClient;
        private System.Windows.Forms.ToolStripButton tsbNewPhone;
        private System.Windows.Forms.ToolStripButton tsbIssiueList;
        private System.Windows.Forms.ToolStripButton tsbPrintBill;
    }
}

