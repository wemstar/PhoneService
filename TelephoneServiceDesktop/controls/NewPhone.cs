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
    public partial class NewPhone : UserControl
    {
        PhoneServiceDataContext tableContext;
        public NewPhone()
        {
            InitializeComponent();
            tableContext = new PhoneServiceDataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableContext.Phones.InsertOnSubmit(
                new Phone() 
                {   Serial_Sumber=tbSerialNumber.Text,
                    State=tbState.Text,
                    Color=tbState.Text,
                    Model_Name=tbModelName.Text,
                                      
                });
            tableContext.SubmitChanges();
        }
    }
}
