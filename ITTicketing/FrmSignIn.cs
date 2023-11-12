using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmCOFLabel.API;
using FrmGoldTekLabel;
using luvo.erp.ngerp1;

namespace ITTicketing
{
    public partial class FrmSignIn : Form
    {
        CHW_HK cl_hk = new CHW_HK();
        public DataTable tblUserRecord; 

        public FrmSignIn()
        {
            InitializeComponent();
            tblUserRecord = cl_hk.GetUserRecord(CModule.cc);
        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            if(tblUserRecord != null && tblUserRecord.Rows.Count > 0)
            {
                string un = txtun.Text.Trim(), pw = txtpw.Text.Trim();
                CModule.un = un;

                var dat1 = tblUserRecord.AsEnumerable().Where(row => row["Un"].ToString().Trim() == un.Trim());
                var dat2 = tblUserRecord.AsEnumerable().Where(row => row["Pw"].ToString().Trim() == pw.Trim()); 

                if(dat1 != null && dat1.Any() && dat2 != null && dat2.Any() && CModule.cc == "NTMP")
                {
                    this.Hide();
                    FrmMain frm1 = new FrmMain();
                    frm1.Show(); 
                }else
                {
                    MessageBox.Show("Wrong username or password");
                    return; 
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
