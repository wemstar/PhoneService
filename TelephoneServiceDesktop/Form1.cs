using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TelephoneServiceDesktop.controls;

namespace TelephoneServiceDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addTab("New Issiue",new NewIssiueControl());
        }

        private void tsbNewClient_Click(object sender, EventArgs e)
        {
            addTab("New Client",new NewClient());
        }

        private void tsbNewPhone_Click(object sender, EventArgs e)
        {
            addTab("New Phone",new NewPhone());
        }

        private void tsbIssiueList_Click(object sender, EventArgs e)
        {
            addTab("IssiueList",new IssiueList(this));
        }

        private void tsbPrintBill_Click(object sender, EventArgs e)
        {
            addTab("Print Bill", new PrintBill());
        }

        public void addTab(string title,UserControl control)
        {
            var tabCon = new TabPage(title);
            tabCon.Dock = DockStyle.Fill;
            tabCon.Controls.Add(control);
            tcMain.TabPages.Add(tabCon);
            tcMain.SelectedTab=tabCon;
        }
    }
}
