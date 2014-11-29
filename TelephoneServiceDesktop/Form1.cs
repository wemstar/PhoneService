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
            var tabCon = new TabPage("New Issiue");
            tabCon.Controls.Add(new NewIssiueControl());
            tcMain.TabPages.Add(tabCon);
        }
    }
}
