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
    public partial class IssiueList : UserControl
    {
        ViewsTemplateDataContext viewContext;
        private Form1 form1;
        public IssiueList()
        {
            viewContext = new ViewsTemplateDataContext();
            InitializeComponent();
        }

        public IssiueList(Form1 form1):this()
        {           
            this.form1 = form1;
        }

        private void IssiueList_Load(object sender, EventArgs e)
        {
            var issiueList = from issiue in viewContext.GetActiveIssiues select issiue;
            dgvIssiueList.DataSource = issiueList;
        }

        private void dgvIssiueList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIssiueList.SelectedCells.Count > 0)
            {
                int issiueIndex = dgvIssiueList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedIssiue = dgvIssiueList.Rows[issiueIndex];
                int issiueID = Convert.ToInt32(selectedIssiue.Cells["Issiue_ID"].Value);
                form1.addTab("Issiue Details", new IssiueDetails(issiueID));
            }
        }
    }
}
