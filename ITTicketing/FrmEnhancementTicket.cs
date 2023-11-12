using FrmCOFLabel.API;
using luvo.erp.ngerp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ITTicketing
{
    public partial class FrmEnhancementTicket : Form
    {
        CHW_HK cl_hk = new CHW_HK();
        DataTable tblEnc = new DataTable();
        public string role = "";
        public FrmEnhancementTicket()
        {
            InitializeComponent();
            cmbStatus.SelectedIndex = 0;
            dtCreated.Format = DateTimePickerFormat.Custom;
            dtCreated.CustomFormat = "yyyy-MM-dd";
            dtRequired.Format = DateTimePickerFormat.Custom;
            dtRequired.CustomFormat = "yyyy-MM-dd";
            tblEnc = cl_hk.GetLastRecordTblEnhancement(CModule.cc);
            role = cl_hk.GetUserRecord(CModule.cc, CModule.un);
        }

        private void DataNew()
        {
            dtCreated.Value = DateTime.Now; dtRequired.Value = DateTime.Now; cmbType.SelectedIndex = -1; cmbStatus.SelectedIndex = 0;
            txtObjective.Text = ""; txtDescription.Text = ""; txtChatHistory.Text = ""; txtTypeChat.Text = "";
            txtTypeChat.Enabled = true; btnEnter.Enabled = true; btnSubmit.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataNew();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string content = dtCreated.Value.ToString("yyyy-MM-dd HH:mm:ss") + " " + CModule.un + " : " + txtTypeChat.Text;
            if (txtChatHistory.Text == "")
            {
                txtChatHistory.Text += content;

            }
            else
            {
                txtChatHistory.AppendText(Environment.NewLine + content);
            }

            txtTypeChat.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CModule.enhancementticketNo == "" || CModule.enhancementticketNo == null)
            {

                string createdDate = dtCreated.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                string requiredDate = dtRequired.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);


                string ticketNo = "";
                if (cmbType.Text == "")
                {
                    MessageBox.Show("Type cannot be blank");
                    return;
                }
                if (cmbType.Text == "")
                {
                    MessageBox.Show("Type cannot be blank");
                    return;
                }
                if (txtObjective.Text == "")
                {
                    MessageBox.Show("Objective cannot be blank");
                    return;
                }
                if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description cannot be blank");
                    return;
                }

                if (tblEnc.Rows.Count == 0)
                {
                    ticketNo = "ENC" + "-" + DateTime.Now.ToString("yyyyMMdd") + "-" + "0001";
                }
                else
                {
                    ticketNo = tblEnc.Rows[0]["ticketNo"].ToString();
                    string count = ticketNo.Substring(13, 4);
                    int tempcount = int.Parse(count);
                    tempcount += 1;
                    count = tempcount.ToString("D4");
                    ticketNo = "ENC" + "-" + DateTime.Now.ToString("yyyyMMdd") + "-" + count;
                }
                string id2 = cl_hk.insertTblEnhancementTicket(CModule.cc, ticketNo, cmbType.Text, cmbStatus.Text, txtObjective.Text, txtDescription.Text, txtChatHistory.Text, txtAssign.Text, CModule.un, CModule.un, requiredDate, createdDate, createdDate);

                if (id2 != "")
                {
                    MessageBox.Show("Successfully Submitted Enhancement Ticket and ticket number is " + ticketNo);
                    DataNew();
                    return;
                }
                else
                {
                    MessageBox.Show("Failed Incident Enhancement Submission");
                    return;
                }
            } else
            {
                string dtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                cl_hk.UpdtblEnhancementChat(CModule.cc, CModule.enhancementticketNo, txtChatHistory.Text, dtNow, CModule.un);

                MessageBox.Show("Update Successful");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FrmEnhancementTicket_Load(object sender, EventArgs e)
        {
            DataNew();

            if (role == "IT ADMIN")
            {
                dtCreated.Enabled = false; dtRequired.Enabled = false; cmbType.Enabled = false; cmbStatus.Enabled = true;
                txtObjective.Enabled = false; txtDescription.Enabled = false; btnNew.Enabled = false; btnSubmit.Enabled = false;
                txtDeveloping.Enabled = true; txtComplete.Enabled = true; dtEstimate.Enabled = true; btnUpdateDevelop.Enabled = true;
                dtComplete.Enabled = true; btnUpdateComplete.Enabled = true;

                tblEnc = cl_hk.GetRecordByUsingEncTicketNo(CModule.cc, CModule.enhancementticketNo);
                DataPopulate(tblEnc);
            }
            else if (role != "IT ADMIN" && CModule.enhancementticketNo == "" || CModule.enhancementticketNoStatus == null)
            {
                DataNew();
            } else if (role != "IT ADMIN" && CModule.enhancementticketNoStatus != "COMPLETED"  && CModule.enhancementticketNoStatus != "REJECT")
            {
                dtCreated.Enabled = false; dtRequired.Enabled = false; cmbType.Enabled = false; txtObjective.Enabled = false;
                txtDescription.Enabled = false; btnNew.Enabled = false;
                btnSubmit.Text = "Update";
                tblEnc = cl_hk.GetRecordByUsingEncTicketNo(CModule.cc, CModule.enhancementticketNo);
                DataPopulate(tblEnc);
            }
            else if (role != "IT ADMIN" && CModule.enhancementticketNoStatus == "COMPLETED" || CModule.enhancementticketNoStatus == "REJECT")
            {
                dtCreated.Enabled = false; dtRequired.Enabled = false; cmbType.Enabled = false; txtObjective.Enabled = false;
                txtDescription.Enabled = false; btnNew.Enabled = false;btnSubmit.Enabled = false;txtChatHistory.Enabled = false;
                txtTypeChat.Enabled = false;btnEnter.Enabled = false; txtAssign.Enabled = false;
                tblEnc = cl_hk.GetRecordByUsingEncTicketNo(CModule.cc, CModule.enhancementticketNo);
                DataPopulate(tblEnc);
            }


        }

        public void DataPopulate(DataTable tblEnc)
        {
            foreach (DataRow row in tblEnc.Rows)
            {
                if (!string.IsNullOrWhiteSpace(row["createdDate"].ToString()))
                {
                    dtCreated.Value = Convert.ToDateTime(row["createdDate"]);
                }
                if (!string.IsNullOrWhiteSpace(row["requiredDate"].ToString()))
                {
                    dtRequired.Value = Convert.ToDateTime(row["requiredDate"]);
                }
                cmbType.Text = row["type"].ToString();
                cmbStatus.Text = row["status"].ToString();
                txtObjective.Text = row["objective"].ToString();
                txtDescription.Text = row["description"].ToString();
                txtChatHistory.Text = row["chat"].ToString();
                txtDeveloping.Text = row["developing"].ToString();
                txtComplete.Text = row["complete"].ToString();
                if (!string.IsNullOrWhiteSpace(row["estimateDate"].ToString()))
                {
                    dtEstimate.Value = Convert.ToDateTime(row["estimateDate"].ToString());
                }
                if (!string.IsNullOrWhiteSpace(row["completeDate"].ToString()))
                {
                    dtComplete.Value = Convert.ToDateTime(row["completeDate"].ToString());
                }
            }
        }

        private void btnUpdateDevelop_Click(object sender, EventArgs e)
        {
            string dtEstimated = dtEstimate.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            string dtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            cl_hk.UpdtblEnhancementDeveloping(CModule.cc, CModule.enhancementticketNo, cmbStatus.Text, txtChatHistory.Text, txtDeveloping.Text, dtEstimated, dtNow, CModule.un);
            MessageBox.Show("Update Successful");
            DataNew(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUpdateComplete_Click(object sender, EventArgs e)
        {
            string dtCompleted = dtComplete.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            string dtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            cl_hk.UpdtblEnhancementComplete(CModule.cc, CModule.enhancementticketNo, cmbStatus.Text, txtChatHistory.Text, txtDeveloping.Text, dtCompleted, dtNow, CModule.un);
            MessageBox.Show("Update Successful");
            DataNew();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
