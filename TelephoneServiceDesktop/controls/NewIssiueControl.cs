using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Templates.templates;

namespace TelephoneServiceDesktop.controls
{
    public partial class NewIssiueControl : UserControl
    {
        PhoneServiceDataContext tableContext;
        ProcedureTemplateDataContext procedureContext;
        public NewIssiueControl()
        {
            InitializeComponent();
            tableContext = new PhoneServiceDataContext();
            procedureContext = new ProcedureTemplateDataContext();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.Dock = DockStyle.Fill;
            var querryClients = from client in tableContext.Clients select client;
            var querryPhone = from phone in tableContext.Phones select phone;
            dgvClientList.DataSource = querryClients;
            dgvPhones.DataSource = querryPhone;

        }

        private void bSubmmit_Click(object sender, EventArgs e)
        {
            if(dgvClientList.SelectedCells.Count > 0 && dgvClientList.SelectedCells.Count > 0)
            {
                int clientIndex = dgvClientList.SelectedCells[0].RowIndex;
                int phoneIndex = dgvPhones.SelectedCells[0].RowIndex;

                DataGridViewRow selectedClient = dgvClientList.Rows[clientIndex];
                DataGridViewRow selectedPhone = dgvPhones.Rows[phoneIndex];

                int clientID = Convert.ToInt32(selectedClient.Cells["Client_ID"].Value);
                int phoneID = Convert.ToInt32(selectedPhone.Cells["Phone_ID"].Value);
                procedureContext.NewIssiue(clientID, phoneID,20,tbComment.Text);
            }
        }
    }
}
