
namespace FrmGoldTekLabel
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dVTLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enhancementTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enhancementConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productionToolStripMenuItem,
            this.consoleToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.userManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.signOutToolStripMenuItem.Text = "Sign-Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dVTLabelToolStripMenuItem,
            this.enhancementTicketToolStripMenuItem});
            this.productionToolStripMenuItem.Enabled = false;
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.productionToolStripMenuItem.Text = "Request Ticket";
            // 
            // dVTLabelToolStripMenuItem
            // 
            this.dVTLabelToolStripMenuItem.Name = "dVTLabelToolStripMenuItem";
            this.dVTLabelToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dVTLabelToolStripMenuItem.Text = "Incident Ticket";
            this.dVTLabelToolStripMenuItem.Click += new System.EventHandler(this.dVTLabelToolStripMenuItem_Click);
            // 
            // enhancementTicketToolStripMenuItem
            // 
            this.enhancementTicketToolStripMenuItem.Name = "enhancementTicketToolStripMenuItem";
            this.enhancementTicketToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.enhancementTicketToolStripMenuItem.Text = "Enhancement Ticket";
            this.enhancementTicketToolStripMenuItem.Click += new System.EventHandler(this.enhancementTicketToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentConsoleToolStripMenuItem,
            this.enhancementConsoleToolStripMenuItem});
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.consoleToolStripMenuItem.Text = "Console";
            // 
            // incidentConsoleToolStripMenuItem
            // 
            this.incidentConsoleToolStripMenuItem.Name = "incidentConsoleToolStripMenuItem";
            this.incidentConsoleToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.incidentConsoleToolStripMenuItem.Text = "Incident Console";
            this.incidentConsoleToolStripMenuItem.Click += new System.EventHandler(this.incidentConsoleToolStripMenuItem_Click);
            // 
            // enhancementConsoleToolStripMenuItem
            // 
            this.enhancementConsoleToolStripMenuItem.Name = "enhancementConsoleToolStripMenuItem";
            this.enhancementConsoleToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.enhancementConsoleToolStripMenuItem.Text = "Enhancement Console";
            this.enhancementConsoleToolStripMenuItem.Click += new System.EventHandler(this.enhancementConsoleToolStripMenuItem_Click);
            // 
            // tabForms
            // 
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForms.Location = new System.Drawing.Point(0, 35);
            this.tabForms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(1200, 38);
            this.tabForms.TabIndex = 8;
            this.tabForms.Visible = false;
            this.tabForms.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged_1);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // userManagerToolStripMenuItem
            // 
            this.userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
            this.userManagerToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.userManagerToolStripMenuItem.Text = "User Manager";
            this.userManagerToolStripMenuItem.Click += new System.EventHandler(this.userManagerToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "IT Ticketing System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.FrmMain_MdiChildActivate_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dVTLabelToolStripMenuItem;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.ToolStripMenuItem enhancementTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enhancementConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagerToolStripMenuItem;
    }
}