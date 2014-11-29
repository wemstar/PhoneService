using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Templates.templates;

namespace TelephoneServiceDesktop.forms
{
    public partial class ChangeStatus : Form
    {

        ProcedureTemplateDataContext procedure;
        private int issiueID;
        public ChangeStatus()
        {
            InitializeComponent();
            procedure = new ProcedureTemplateDataContext();
        }

        public ChangeStatus(int issiueID):this()
        {
            
            this.issiueID = issiueID;
        }

        private void bSubbmit_Click(object sender, EventArgs e)
        {
            string status=cbStatus.SelectedItem.ToString();
            string comment = rtbComment.Text;

            procedure.UpdateIssiue(issiueID,status,comment);
            this.Close();
        }
    }
}
