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
        PhoneServiceDataContext temp;
        public NewIssiueControl()
        {
            InitializeComponent();
            temp = new PhoneServiceDataContext();
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var querry = from client in temp.Clients select client;
            dgvClientList.DataSource = querry;
        }
    }
}
