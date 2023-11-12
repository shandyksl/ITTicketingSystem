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
    public partial class FrmEnhancementConsole : Form
    {
        string role = "";
        CHW_HK cl_hk = new CHW_HK();
        DataTable tblEnhancement = new DataTable();
        FrmEnhancementTicket frmEnhancementTicket = new FrmEnhancementTicket();
        public FrmEnhancementConsole()
        {
            InitializeComponent();
            role = cl_hk.GetUserRecord(CModule.cc, CModule.un);
            initiate(); 
        }

        public void initiate()
        {
            if (role == "IT ADMIN")
            {
                tblEnhancement = cl_hk.GettblEnhancementTicketRecordAssign(CModule.cc);
                gv.DataSource = null;
                gv.AutoGenerateColumns = false;
                gv.DataSource = tblEnhancement;
            }

            DataTable tblEnhancement2 = cl_hk.GettblEnhancementTicketRecordSubmit(CModule.cc, CModule.un);
            gv2.DataSource = null;
            gv2.AutoGenerateColumns = false;
            gv2.DataSource = tblEnhancement2;
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            int i = gv.CurrentRow.Index;
            if (i >= 0)
            {
                DataTransfer(gv.Rows[i].Cells[0].Value.ToString(), gv.Rows[i].Cells[2].Value.ToString());

                DialogResult res = frmEnhancementTicket.ShowDialog(this);

                if(res == DialogResult.OK || res == DialogResult.Cancel)
                {
                    CModule.enhancementticketNo = ""; CModule.enhancementticketNoStatus = ""; 
                    initiate();
                }
            }
        }

        private void DataTransfer(string ticketNo, string ticketNoStatus)
        {
            CModule.enhancementticketNo = ticketNo;
            CModule.enhancementticketNoStatus = ticketNoStatus;

        }

        private void gv2_DoubleClick(object sender, EventArgs e)
        {
            int i = gv2.CurrentRow.Index;
            if (i >= 0)
            {
                DataTransfer(gv2.Rows[i].Cells[0].Value.ToString(), gv2.Rows[i].Cells[2].Value.ToString());

                DialogResult res = frmEnhancementTicket.ShowDialog(this);

                if (res == DialogResult.OK || res == DialogResult.Cancel)
                {
                    CModule.enhancementticketNo = ""; CModule.enhancementticketNoStatus = "";
                    initiate();
                }
            }
        }
    }


}
