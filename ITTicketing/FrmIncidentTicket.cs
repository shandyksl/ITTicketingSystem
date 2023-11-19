using FrmCOFLabel.API;
using luvo.erp.ngerp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITTicketing
{
    public partial class FrmIncidentTicket : Form
    {
        CHW_HK cl_hk = new CHW_HK();
        DataTable tblInc = new DataTable();
        DataTable tblLocation = new DataTable();
        DataTable tblShift = new DataTable();

        public string priority { get; set; }

        public DateTime createdDate { get; set; }
        public string status { get; set; }

        public string title { get; set; }
        public string description { get; set; }

        public string chat {  get; set; }

        public string type {  get; set; }

        public string location { get; set; }

        public string shift { get; set; }

        public string role = ""; 

        public FrmIncidentTicket()
        {
            InitializeComponent();

            DataNew();
            cmbStatus.SelectedIndex = 0;
            dtCreated.Format = DateTimePickerFormat.Custom;
            dtCreated.CustomFormat = "yyyy-MM-dd";
            tblInc = cl_hk.GetLastRecordTblIncident(CModule.cc);
            role = cl_hk.GetUserRecord(CModule.cc, CModule.un);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataNew(); 
        }

        private void DataNew()
        {
            cmbPriority.SelectedIndex = -1;  txtDescription.Text = ""; cmbType.SelectedIndex = -1; cmbLocation.SelectedIndex  = -1;
            cmbShift.SelectedIndex = -1; txtTypeChat.Text = ""; dtCreated.Value = DateTime.Now;txtTitle.Text = "";  txtChatHistory.Text = "";
            txtSolution.Text = ""; dtSolve.Value = DateTime.Now;txtSolveBy.Text = ""; txtComment.Text = ""; dtClose.Value = DateTime.Now;txtClosedBy.Text = "";
            btnEnter.Enabled = true; txtTypeChat.Enabled = true; btnSubmit.Enabled = true;
            tblLocation = cl_hk.GetLocationRecord(CModule.cc); 
            cmbLocation.DataSource = tblLocation;
            cmbLocation.DisplayMember = "location";
            cmbLocation.ValueMember = "location";

            tblShift = cl_hk.GetShiftRecord(CModule.cc);
            cmbShift.DataSource = tblShift;
            cmbShift.DisplayMember = "shift";
            cmbShift.ValueMember = "shift";

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string content = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + CModule.un + " : " + txtTypeChat.Text;
            if(txtChatHistory.Text == "")
            {
                txtChatHistory.Text += content;
                
            }else
            {
                txtChatHistory.AppendText(Environment.NewLine + content);
            }

            txtTypeChat.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if(CModule.ticketNo == "" || CModule.ticketNo == null)
            {
                string createdDate = dtCreated.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                string ticketNo = "";

                if (cmbPriority.Text == "")
                {
                    MessageBox.Show("Priority cannot be blank");
                    return;
                }
                if (txtTitle.Text == "")
                {
                    MessageBox.Show("Title cannot be blank");
                    return;
                }
                if (cmbType.Text == "")
                {
                    MessageBox.Show("Type cannot be blank");
                    return;
                }
                if (cmbLocation.Text == "")
                {
                    MessageBox.Show("Location cannot be blank");
                    return;
                }
                if (cmbShift.Text == "")
                {
                    MessageBox.Show("Shift cannot be blank");
                    return;
                }

                if (tblInc.Rows.Count == 0)
                {
                    ticketNo = "INC" + "-" + DateTime.Now.ToString("yyyyMMdd") + "-" + "0001";

                }
                else
                {
                    ticketNo = tblInc.Rows[0]["ticketNo"].ToString();
                    string count = ticketNo.Substring(13, 4);
                    int tempcount = int.Parse(count);
                    tempcount += 1;
                    count = tempcount.ToString("D4");
                    ticketNo = "INC" + "-" + DateTime.Now.ToString("yyyyMMdd") + "-" + count;
                }


                string id2 = cl_hk.insertTblIncidentTicket(CModule.cc, ticketNo, cmbPriority.Text, txtTitle.Text, cmbStatus.Text, txtDescription.Text, cmbType.Text, cmbLocation.Text, txtAssign.Text, cmbShift.Text, txtChatHistory.Text, CModule.un, CModule.un, createdDate, createdDate);

                if (id2 != "")
                {
                    MessageBox.Show("Successfully Submitted Incident Ticket and ticket number is " + ticketNo);
                    DataNew();
                    return;
                }
                else
                {
                    MessageBox.Show("Failed Incident Ticket Submission  ");
                    return;
                }
            }else
            {
                string dtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                cl_hk.UpdtblIncidentChat(CModule.cc, CModule.ticketNo, txtChatHistory.Text, dtNow, CModule.un);

                MessageBox.Show("Update Successful");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void DataPopulate(DataTable tblInc)
        {
            foreach(DataRow row in tblInc.Rows)
            {
                cmbPriority.Text = row["priority"].ToString();
                dtCreated.Value = Convert.ToDateTime(row["createdDate"]);
                cmbStatus.Text = row["status"].ToString();  
                txtTitle.Text = row["title"].ToString();    
                txtDescription.Text = row["description"].ToString();
                txtChatHistory.Text = row["chat"].ToString(); 
                cmbType.Text = row["type"].ToString();
                cmbLocation.Text = row["location"].ToString();
                cmbShift.Text  = row["shift"].ToString();
                txtSolution.Text = row["solution"].ToString();
                txtComment.Text= row["comment"].ToString();
                if (!string.IsNullOrWhiteSpace(row["solveDate"].ToString()))
                {
                    dtSolve.Value = Convert.ToDateTime(row["solveDate"].ToString());
                }
                if (!string.IsNullOrWhiteSpace(row["closeDate"].ToString()))
                {
                    dtClose.Value = Convert.ToDateTime(row["closeDate"].ToString());
                }
            }
        }

        private void FrmIncidentTicket_Load(object sender, EventArgs e)
        {
            DataNew(); 

            if (role == "IT ADMIN")
            {
                txtSolution.Enabled = true; dtSolve.Enabled = true; txtSolveBy.Enabled = true; btnUpdateSolve.Enabled = true;
                txtComment.Enabled = true; dtClose.Enabled = true; txtClosedBy.Enabled = true; btnUpdateClosed.Enabled = true;

                cmbPriority.Enabled = false; dtCreated.Enabled = false; txtTitle.Enabled = false;
                txtDescription.Enabled = false; cmbType.Enabled = false; cmbLocation.Enabled = false; txtAssign.Enabled = false;
                cmbShift.Enabled = false;btnNew.Enabled = false;btnSubmit.Enabled = false;txtSolveBy.Text = CModule.un; txtClosedBy.Text=CModule.un;

                tblInc = cl_hk.GetRecordByUsingTicketNo(CModule.cc, CModule.ticketNo);
                DataPopulate(tblInc);
            }
            else if (role != "IT ADMIN" && CModule.ticketNoStatus == "" || CModule.ticketNoStatus == null)
            {
                DataNew(); 
            }
            else if (role != "IT ADMIN" && CModule.ticketNoStatus != "CLOSED")
            {
                cmbPriority.Enabled = false;dtCreated.Enabled = false; cmbStatus.Enabled = false;  txtTitle.Enabled = false; txtDescription.Enabled=false;
                cmbType.Enabled = false;cmbLocation.Enabled = false;cmbShift.Enabled = false;btnNew.Enabled = false;
                btnSubmit.Text = "Update"; 
                tblInc = cl_hk.GetRecordByUsingTicketNo(CModule.cc, CModule.ticketNo);
                DataPopulate(tblInc);

            }
            else if (role != "IT ADMIN" && CModule.ticketNoStatus == "CLOSED")
            {
                cmbPriority.Enabled = false; dtCreated.Enabled = false; cmbStatus.Enabled = false; txtTitle.Enabled = false; txtDescription.Enabled = false;
                cmbType.Enabled = false; cmbLocation.Enabled = false; cmbShift.Enabled = false; btnNew.Enabled = false;btnSubmit.Enabled = false;btnEnter.Enabled = false;txtTypeChat.Enabled = false; txtAssign.Enabled = false;
                tblInc = cl_hk.GetRecordByUsingTicketNo(CModule.cc, CModule.ticketNo);
                DataPopulate(tblInc);
            }
        }

        private void btnUpdateSolve_Click(object sender, EventArgs e)
        {
            string dtSolved = dtSolve.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            cl_hk.UpdtblIncidentSolution(CModule.cc, CModule.ticketNo, cmbStatus.Text, txtChatHistory.Text, txtSolution.Text, txtComment.Text, dtSolved, txtSolveBy.Text);
            MessageBox.Show("Update Successful");
            DataNew(); 
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

        private void btnUpdateClosed_Click(object sender, EventArgs e)
        {
            string dtClosed = dtClose.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            cl_hk.UpdtblIncidentClose(CModule.cc, CModule.ticketNo, cmbStatus.Text, txtChatHistory.Text, txtSolution.Text, txtComment.Text, dtClosed, txtClosedBy.Text);
            MessageBox.Show("Update Successful");
            DataNew(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
