namespace ITTicketing
{
    partial class FrmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignIn));
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtun = new System.Windows.Forms.TextBox();
            this.txtCoName = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSignIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(142, 129);
            this.txtpw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(148, 26);
            this.txtpw.TabIndex = 56;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(142, 92);
            this.txtun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(148, 26);
            this.txtun.TabIndex = 55;
            // 
            // txtCoName
            // 
            this.txtCoName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCoName.Location = new System.Drawing.Point(142, 54);
            this.txtCoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCoName.Name = "txtCoName";
            this.txtCoName.ReadOnly = true;
            this.txtCoName.Size = new System.Drawing.Size(148, 26);
            this.txtCoName.TabIndex = 54;
            this.txtCoName.Text = "NTMP";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(262, 220);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(104, 35);
            this.cmdCancel.TabIndex = 53;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSignIn
            // 
            this.cmdSignIn.Location = new System.Drawing.Point(142, 220);
            this.cmdSignIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSignIn.Name = "cmdSignIn";
            this.cmdSignIn.Size = new System.Drawing.Size(111, 35);
            this.cmdSignIn.TabIndex = 52;
            this.cmdSignIn.Text = "Sign-In";
            this.cmdSignIn.UseVisualStyleBackColor = true;
            this.cmdSignIn.Click += new System.EventHandler(this.cmdSignIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Company Sign-In Form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Written And Supported By Khoo Sheng Li";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(630, 305);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.txtCoName);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSignIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Ticketing System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.TextBox txtCoName;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSignIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

