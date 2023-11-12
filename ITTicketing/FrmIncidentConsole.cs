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
    public partial class FrmIncidentConsole : Form
    {

        CHW_HK cl_hk = new CHW_HK();
        DataTable tblIncident = new DataTable();
        FrmIncidentTicket frmIncidentTicket = new FrmIncidentTicket();
        string role = ""; 
        public FrmIncidentConsole()
        {
            InitializeComponent();
            gv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);

            role = cl_hk.GetUserRecord(CModule.cc, CModule.un);
            initiate(); 
        }

        public void initiate()
        {
            if (role == "IT ADMIN")
            {
                tblIncident = cl_hk.GettblIncidentTicketRecordAssign(CModule.cc);
                gv.DataSource = null;
                gv.AutoGenerateColumns = false;
                gv.DataSource = tblIncident;
            }

            DataTable tblIncident2 = cl_hk.GettblIncidentTicketRecordSubmit(CModule.cc, CModule.un);
            gv2.DataSource = null;
            gv2.AutoGenerateColumns = false;
            gv2.DataSource = tblIncident2;
        }


        private void gv_DoubleClick(object sender, EventArgs e)
        {
            int i = gv.CurrentRow.Index;
            if(i >= 0)
            {
                
                DataTransfer(gv.Rows[i].Cells[0].Value.ToString(), gv.Rows[i].Cells[3].Value.ToString()); 

                DialogResult res = frmIncidentTicket.ShowDialog(this);

                if(res == DialogResult.OK || res == DialogResult.Cancel)
                {
                    CModule.ticketNo = ""; CModule.ticketNoStatus = "";
                    initiate(); 
                }

            }
        }

        private void DataTransfer(string ticketNo, string ticketNoStatus)
        {
            CModule.ticketNo = ticketNo; 
            CModule.ticketNoStatus = ticketNoStatus;

        }

        private void gv2_DoubleClick(object sender, EventArgs e)
        {
            int i = gv2.CurrentRow.Index;

            if(i >= 0 )
            {
                DataTransfer(gv2.Rows[i].Cells[0].Value.ToString(), gv2.Rows[i].Cells[3].Value.ToString());
                DialogResult res = frmIncidentTicket.ShowDialog(this);
                if (res == DialogResult.OK || res == DialogResult.Cancel)
                {
                    CModule.ticketNo = ""; CModule.ticketNoStatus = "";
                    initiate();
                }
            }
        }

     
    }
}
