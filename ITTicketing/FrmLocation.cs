using FrmCOFLabel.API;
using luvo.erp.ngerp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ITTicketing
{
    public partial class FrmLocation : Form
        {
        CHW_HK cl_hk = new CHW_HK();
        DataTable tblLocation = new DataTable();
        string pid = ""; string id2 = "";
        private DataTable dataTable;
        public FrmLocation()
        {
            InitializeComponent();
     
            DataNew(); 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataNew(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string createdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            if (txtlocation.Text == "")
            {
                MessageBox.Show("Location cannot be blank");
                return;
            }

            int chklocation = cl_hk.GetLocationRecordName(CModule.cc, txtlocation.Text);

            if (chklocation == 1)
            {
                MessageBox.Show("Location already exist in database. Please recreate a new location");
                return;
            }

            id2 = cl_hk.insertTblLocation(CModule.cc, txtlocation.Text, createdDate, CModule.un);

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

        }



        private void DataNew()
        {
            txtlocation.Text = "";pid = ""; id2 = ""; 
            tblLocation = cl_hk.GetLocationRecord(CModule.cc);
            gv.DataSource = null;
            //gv.Columns.Clear();
            gv.AutoGenerateColumns = false;
            gv.DataSource = tblLocation;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;

        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            int i = gv.CurrentRow.Index;
            if (i >= 0)
            {
                DataPopulate(gv.Rows[i].Cells[0].Value.ToString());
            }
            if (pid != "")
            {
               btnDelete.Enabled = true;
               btnAdd.Enabled = false;
            }
        }

        private void DataPopulate(string location)
        {
            pid = "1";
            txtlocation.Text = location; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool success = cl_hk.deleteTblLocation(txtlocation.Text, CModule.cc);

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

            }
            else
            {
                MessageBox.Show("Delete operation canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
