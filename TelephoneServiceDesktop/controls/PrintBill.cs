using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Templates.templates;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace TelephoneServiceDesktop.controls
{
    public partial class PrintBill : UserControl
    {
        PhoneServiceDataContext tableContext;
        ProcedureTemplateDataContext procedureContext;

        public PrintBill()
        {
            InitializeComponent();
            tableContext = new PhoneServiceDataContext();
            procedureContext = new ProcedureTemplateDataContext();
        }

        private void bBill_Click(object sender, EventArgs e)
        {
            XElement xml=null;
            int issiueIDRow = dgvIssiues.SelectedCells[0].RowIndex;


            DataGridViewRow selectedIssiue = dgvIssiues.Rows[issiueIDRow];


            int issiueID = Convert.ToInt32(selectedIssiue.Cells["Issiue_ID"].Value);

            procedureContext.GenerateBill(issiueID, ref xml);
            rtbResult.Text = xml.ToString();

        }

        private void PrintBill_Load(object sender, EventArgs e)
        {
            dgvIssiues.DataSource=from issiue in tableContext.Issiues select issiue; 
        }
    }
}
