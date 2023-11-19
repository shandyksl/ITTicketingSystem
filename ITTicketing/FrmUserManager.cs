using FrmCOFLabel.API;
using luvo.erp.ngerp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITTicketing
{
    public partial class FrmUserManager : Form
    {
        CHW_HK cl_hk = new CHW_HK();

        DataTable tblUser = new DataTable();

        string id2 = ""; string pid = ""; 

        

        public FrmUserManager()
        {
            InitializeComponent();
            DataNew(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string createdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            if (txtun.Text == "")
            {
                MessageBox.Show("Username cannot be blank");
                return;
            }

            int chkun = cl_hk.GetUserRecordName(CModule.cc, txtun.Text);


            if (btnAdd.Text == "Add")
            {
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

                if (chkun == 1)
                {
                    MessageBox.Show("username already exist. please create a new username");
                    return;
                }

                id2 = cl_hk.insertTblUser(CModule.cc, txtun.Text, txtpw.Text, txtdept.Text, cmbrole.Text, txtmobile.Text, createdDate, CModule.un);

                if (!string.IsNullOrEmpty(id2))
                {
                    MessageBox.Show("Successfully insert into database");
                    DataNew();
                    return;

                }
                else
                {
                    MessageBox.Show("Failed insert into database");
                    DataNew();
                    return;
                }
            }else
            {
                if (chkun == 0)
                {
                    MessageBox.Show("Could not find the username in the database");
                    return;
                }

                bool success = cl_hk.updateTblUser(CModule.cc, txtun.Text, txtpw.Text,txtdept.Text, cmbrole.Text,txtmobile.Text,createdDate, CModule.un);

                if (success)
                {
                    MessageBox.Show("Update successfully");
                    DataNew();
                    return;
                }else
                {
                    MessageBox.Show("Update failed");
                    DataNew();
                    return;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataNew();
        }

        private void DataNew()
        {
            txtun.Text = ""; txtpw.Text = ""; txtmobile.Text = ""; txtdept.Text = ""; cmbrole.SelectedIndex = 0; id2 = ""; pid = ""; btnAdd.Text = "Add"; btnDelete.Enabled = false;
            tblUser = cl_hk.GetUserRecord(CModule.cc);
            gv.DataSource = null;
            gv.Columns.Clear();
            gv.AutoGenerateColumns = true;
            gv.DataSource = tblUser;
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            int i = gv.CurrentRow.Index;
            if (i >= 0)
            {
                DataPopulate(gv.Rows[i].Cells[2].Value.ToString(), gv.Rows[i].Cells[3].Value.ToString(), gv.Rows[i].Cells[4].Value.ToString(), gv.Rows[i].Cells[5].Value.ToString(), gv.Rows[i].Cells[6].Value.ToString()); 
            }

            if(pid != "")
            {
                btnAdd.Text = "Update"; btnDelete.Enabled = true; 

            }
        }


        private void DataPopulate(string un, string pw, string dept, string role, string mobile)
        {
            pid = "1"; 
            txtun.Text = un; txtpw.Text = pw; txtdept.Text = dept ; txtmobile.Text = mobile; cmbrole.Text = role ;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool success = cl_hk.deleteTblUser(txtun.Text, CModule.cc);

            if (result == DialogResult.Yes)
            {

                if (success)
                {
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataNew();
                    return;

                }
                else
                {
                    MessageBox.Show("Failed to delete the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataNew();
                    return;
                }

            }else
            {
                MessageBox.Show("Delete operation canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }
    }
}
