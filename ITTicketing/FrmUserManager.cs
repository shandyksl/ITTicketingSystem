using FrmCOFLabel.API;
using luvo.erp.ngerp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITTicketing
{
    public partial class FrmUserManager : Form
    {
        CHW_HK cl_hk = new CHW_HK();
        public FrmUserManager()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtun.Text == "")
            {
                MessageBox.Show("Username cannot be blank");
                return;
            }
            if (txtpw.Text == "")
            {
                MessageBox.Show("Password cannot be blank");
                return;
            }
            if (cmbrole.Text == "")
            {
                MessageBox.Show("Role cannot be blank");
                return;
            }
            if (txtdept.Text == "")
            {
                MessageBox.Show("Department cannot be blank");
                return;
            }

            int chkun = cl_hk.GetUserRecordName(CModule.cc, txtun.Text); 

            if(chkun == 1)
            {
                MessageBox.Show("username already exist. please create a new username");
                return;
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataNew(); 
        }


        private void DataNew()
        {
            txtun.Text = ""; txtpw.Text = ""; txtmobile.Text = ""; txtdept.Text = ""; cmbrole.SelectedIndex = 0;

        }
    }
}
