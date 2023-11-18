namespace ITTicketing
{
    partial class FrmIncidentTicket
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
            this.txtTypeChat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAssign = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChatHistory = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtCreated = new System.Windows.Forms.DateTimePicker();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.Solution = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtSolve = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.dtClose = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSolveBy = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtClosedBy = new System.Windows.Forms.TextBox();
            this.btnUpdateSolve = new System.Windows.Forms.Button();
            this.btnUpdateClosed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTypeChat
            // 
            this.txtTypeChat.Location = new System.Drawing.Point(728, 305);
            this.txtTypeChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTypeChat.Name = "txtTypeChat";
            this.txtTypeChat.Size = new System.Drawing.Size(388, 26);
            this.txtTypeChat.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 107;
            this.label5.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "Priority";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 102;
            this.label1.Text = "INCIDENT TICKET";
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High ",
            "Medium",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(171, 83);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(187, 28);
            this.cmbPriority.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 123;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 124;
            this.label4.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(171, 163);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(542, 130);
            this.txtDescription.TabIndex = 125;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Enterprise Resource Planning System",
            "Manufacturing Execution System",
            "Manufacturing Packing System"});
            this.cmbType.Location = new System.Drawing.Point(171, 369);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(331, 28);
            this.cmbType.TabIndex = 127;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(28, 374);
            this.Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(43, 20);
            this.Type.TabIndex = 126;
            this.Type.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 128;
            this.label6.Text = "Assign Group";
            // 
            // txtAssign
            // 
            this.txtAssign.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAssign.Enabled = false;
            this.txtAssign.Location = new System.Drawing.Point(728, 371);
            this.txtAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAssign.Name = "txtAssign";
            this.txtAssign.ReadOnly = true;
            this.txtAssign.Size = new System.Drawing.Size(187, 26);
            this.txtAssign.TabIndex = 129;
            this.txtAssign.Text = "IT ADMIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 422);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 130;
            this.label7.Text = "Location";
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Plant 1 Production Module 1",
            "Plant 1 Production Module 2",
            "Plant 2 Production Module 1",
            "Plant 2 Production Module 2",
            "Finish Good Area",
            "Shipping Office",
            "Supply Chain And Management Office",
            "HR Office",
            "Engineering Office",
            "BU Office"});
            this.cmbLocation.Location = new System.Drawing.Point(171, 417);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(331, 28);
            this.cmbLocation.TabIndex = 131;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 429);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 132;
            this.label8.Text = "Shift";
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "Normal",
            "Morning",
            "Night"});
            this.cmbShift.Location = new System.Drawing.Point(728, 417);
            this.cmbShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(187, 28);
            this.cmbShift.TabIndex = 133;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(723, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 134;
            this.label9.Text = "Chat History";
            // 
            // txtChatHistory
            // 
            this.txtChatHistory.Location = new System.Drawing.Point(728, 163);
            this.txtChatHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChatHistory.Multiline = true;
            this.txtChatHistory.Name = "txtChatHistory";
            this.txtChatHistory.ReadOnly = true;
            this.txtChatHistory.Size = new System.Drawing.Size(388, 130);
            this.txtChatHistory.TabIndex = 135;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(513, 509);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 35);
            this.btnNew.TabIndex = 136;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(654, 509);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnSubmit.TabIndex = 137;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1005, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 138;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 88);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 139;
            this.label11.Text = "Date Create";
            // 
            // dtCreated
            // 
            this.dtCreated.Location = new System.Drawing.Point(462, 82);
            this.dtCreated.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtCreated.Name = "dtCreated";
            this.dtCreated.Size = new System.Drawing.Size(252, 26);
            this.dtCreated.TabIndex = 140;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(1126, 305);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(99, 31);
            this.btnEnter.TabIndex = 141;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(171, 126);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(541, 26);
            this.txtTitle.TabIndex = 142;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ACTIVE ",
            "SOLVED",
            "CLOSED"});
            this.cmbStatus.Location = new System.Drawing.Point(799, 85);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(187, 28);
            this.cmbStatus.TabIndex = 143;
            // 
            // Solution
            // 
            this.Solution.AutoSize = true;
            this.Solution.Location = new System.Drawing.Point(31, 586);
            this.Solution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(67, 20);
            this.Solution.TabIndex = 144;
            this.Solution.Text = "Solution";
            // 
            // txtSolution
            // 
            this.txtSolution.Enabled = false;
            this.txtSolution.Location = new System.Drawing.Point(170, 586);
            this.txtSolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(397, 83);
            this.txtSolution.TabIndex = 145;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 679);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 146;
            this.label12.Text = "Date";
            // 
            // dtSolve
            // 
            this.dtSolve.Enabled = false;
            this.dtSolve.Location = new System.Drawing.Point(171, 679);
            this.dtSolve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtSolve.Name = "dtSolve";
            this.dtSolve.Size = new System.Drawing.Size(290, 26);
            this.dtSolve.TabIndex = 147;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(610, 589);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 148;
            this.label13.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Location = new System.Drawing.Point(706, 586);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(397, 83);
            this.txtComment.TabIndex = 149;
            // 
            // dtClose
            // 
            this.dtClose.Enabled = false;
            this.dtClose.Location = new System.Drawing.Point(706, 679);
            this.dtClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtClose.Name = "dtClose";
            this.dtClose.Size = new System.Drawing.Size(290, 26);
            this.dtClose.TabIndex = 150;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 728);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 151;
            this.label14.Text = "Solve By";
            // 
            // txtSolveBy
            // 
            this.txtSolveBy.Enabled = false;
            this.txtSolveBy.Location = new System.Drawing.Point(170, 725);
            this.txtSolveBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSolveBy.Name = "txtSolveBy";
            this.txtSolveBy.ReadOnly = true;
            this.txtSolveBy.Size = new System.Drawing.Size(280, 26);
            this.txtSolveBy.TabIndex = 152;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(610, 684);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 153;
            this.label15.Text = "Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(610, 728);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 154;
            this.label16.Text = "Closed By";
            // 
            // txtClosedBy
            // 
            this.txtClosedBy.Enabled = false;
            this.txtClosedBy.Location = new System.Drawing.Point(706, 725);
            this.txtClosedBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClosedBy.Name = "txtClosedBy";
            this.txtClosedBy.ReadOnly = true;
            this.txtClosedBy.Size = new System.Drawing.Size(280, 26);
            this.txtClosedBy.TabIndex = 155;
     
            // 
            // btnUpdateSolve
            // 
            this.btnUpdateSolve.Enabled = false;
            this.btnUpdateSolve.Location = new System.Drawing.Point(455, 725);
            this.btnUpdateSolve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateSolve.Name = "btnUpdateSolve";
            this.btnUpdateSolve.Size = new System.Drawing.Size(112, 31);
            this.btnUpdateSolve.TabIndex = 156;
            this.btnUpdateSolve.Text = "Update";
            this.btnUpdateSolve.UseVisualStyleBackColor = true;
            this.btnUpdateSolve.Click += new System.EventHandler(this.btnUpdateSolve_Click);
            // 
            // btnUpdateClosed
            // 
            this.btnUpdateClosed.Enabled = false;
            this.btnUpdateClosed.Location = new System.Drawing.Point(994, 720);
            this.btnUpdateClosed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateClosed.Name = "btnUpdateClosed";
            this.btnUpdateClosed.Size = new System.Drawing.Size(112, 31);
            this.btnUpdateClosed.TabIndex = 157;
            this.btnUpdateClosed.Text = "Update";
            this.btnUpdateClosed.UseVisualStyleBackColor = true;
            this.btnUpdateClosed.Click += new System.EventHandler(this.btnUpdateClosed_Click);
            // 
            // FrmIncidentTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1326, 944);
            this.Controls.Add(this.btnUpdateClosed);
            this.Controls.Add(this.btnUpdateSolve);
            this.Controls.Add(this.txtClosedBy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSolveBy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtClose);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtSolve);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSolution);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.dtCreated);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtChatHistory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAssign);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtTypeChat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmIncidentTicket";
            this.ShowIcon = false;
            this.Text = "Incident Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIncidentTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTypeChat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAssign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChatHistory;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtCreated;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label Solution;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtSolve;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.DateTimePicker dtClose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSolveBy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtClosedBy;
        private System.Windows.Forms.Button btnUpdateSolve;
        private System.Windows.Forms.Button btnUpdateClosed;
    }
}