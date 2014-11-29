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
    public partial class NewClient : UserControl
    {
        PhoneServiceDataContext tableContext;
        public NewClient()
        {
            InitializeComponent();
            tableContext = new PhoneServiceDataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client() { Client_Name = tbName.Text, Client_Surname = tbSurname.Text, Client_Telephone = tbPhone.Text, Client_Adress = tbAdres.Text };
            tableContext.Clients.InsertOnSubmit(client);
            tableContext.SubmitChanges();
        }
    }
}
