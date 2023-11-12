using FrmCOFLabel.API;
using ITTicketing;
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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FrmGoldTekLabel
{
    public partial class FrmMain : Form
    {
        CHW_HK cl_hk = new CHW_HK();
        DateTime dtinitial = new DateTime();
        int year = 0, month = 0, day = 0 ,hour = 0, minute = 0, second = 0;

        public FrmMain()
        {
            InitializeComponent();
            CheckPermission(CModule.cc, CModule.un); 
        }

        private void enhancementTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEnhancementTicket f2 = new FrmEnhancementTicket();
            f2.MdiParent = this;
            f2.Show();
        }

        public void CheckPermission(string cc, string un)
        {
            string permission = cl_hk.GetRoleData(cc, un);
         
                switch (permission)
                {
                    case "USER":
                        productionToolStripMenuItem.Enabled = true;
                        break;

                    default:
                        break;
                }
            
        }

        private void incidentConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncidentConsole f2 = new FrmIncidentConsole(); 
            f2.MdiParent = this;
            f2.Show();
        }

        private void enhancementConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEnhancementConsole f2 = new FrmEnhancementConsole();
            f2.MdiParent = this;
            f2.Show();
        }

        private void dVTLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncidentTicket f2 = new FrmIncidentTicket();
            f2.MdiParent = this;
            f2.Show();
        }


        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSignIn frm1 = new FrmSignIn();
            frm1.Show();
            this.Dispose();
        }

        private void FrmMain_MdiChildActivate_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                tabForms.Visible = false; // If no any child form, hide tabControl
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized; // Child form always maximized

                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible)
                {
                    tabForms.Visible = true;
                }
            }
        }

        private void tabForms_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
            {
                (tabForms.SelectedTab.Tag as Form).Select();
            }
        }

    }
}
