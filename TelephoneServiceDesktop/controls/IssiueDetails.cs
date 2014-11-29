using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Templates.templates;
using TelephoneServiceDesktop.forms;

namespace TelephoneServiceDesktop.controls
{
    public partial class IssiueDetails : UserControl
    {
        private int issiueID;
        PhoneServiceDataContext tableContext;
        ProcedureTemplateDataContext procedureContext;

        public IssiueDetails()
        {
            InitializeComponent();
            tableContext = new PhoneServiceDataContext();
        }

        public IssiueDetails(int issiueID):this()
        {            
            this.issiueID = issiueID;
        }
        private void reloadData()
        {
            var issiueSelected = (from issiue in tableContext.Issiues where issiue.Issiue_ID == issiueID select issiue).FirstOrDefault();
            tbIssiueID.Text = issiueSelected.Issiue_ID.ToString();
            tbClientId.Text = issiueSelected.Client.Client_Name;
            tbPhoneID.Text = issiueSelected.Phone.Phone_ID.ToString();
            tbPriority.Text = issiueSelected.Priority.ToString();

            dgvHistory.DataSource = issiueSelected.Issiue_Histories;
        }
        private void IssiueDetails_Load(object sender, EventArgs e)
        {
            reloadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeStatus form = new ChangeStatus(issiueID);
            form.Show();
            reloadData();

        }

       
    }
}
