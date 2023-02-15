namespace libraryUI
{
    partial class signupForm
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
            this.userfirstnametag = new System.Windows.Forms.Label();
            this.userpasswordtag = new System.Windows.Forms.Label();
            this.useremailtag = new System.Windows.Forms.Label();
            this.usersecondnametag = new System.Windows.Forms.Label();
            this.agetag = new System.Windows.Forms.Label();
            this.userfirstname = new System.Windows.Forms.TextBox();
            this.userSecondname = new System.Windows.Forms.TextBox();
            this.useremail = new System.Windows.Forms.TextBox();
            this.userpassword = new System.Windows.Forms.TextBox();
            this.userage = new System.Windows.Forms.TextBox();
            this.createnewuserbuttton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userfirstnametag
            // 
            this.userfirstnametag.AutoSize = true;
            this.userfirstnametag.Location = new System.Drawing.Point(12, 56);
            this.userfirstnametag.Name = "userfirstnametag";
            this.userfirstnametag.Size = new System.Drawing.Size(170, 40);
            this.userfirstnametag.TabIndex = 0;
            this.userfirstnametag.Text = "First Name : ";
            this.userfirstnametag.Click += new System.EventHandler(this.userfirstnametag_Click);
            // 
            // userpasswordtag
            // 
            this.userpasswordtag.AutoSize = true;
            this.userpasswordtag.Location = new System.Drawing.Point(12, 299);
            this.userpasswordtag.Name = "userpasswordtag";
            this.userpasswordtag.Size = new System.Drawing.Size(151, 40);
            this.userpasswordtag.TabIndex = 1;
            this.userpasswordtag.Text = "Password : ";
            // 
            // useremailtag
            // 
            this.useremailtag.AutoSize = true;
            this.useremailtag.Location = new System.Drawing.Point(12, 216);
            this.useremailtag.Name = "useremailtag";
            this.useremailtag.Size = new System.Drawing.Size(104, 40);
            this.useremailtag.TabIndex = 2;
            this.useremailtag.Text = "Email : ";
            // 
            // usersecondnametag
            // 
            this.usersecondnametag.AutoSize = true;
            this.usersecondnametag.Location = new System.Drawing.Point(12, 143);
            this.usersecondnametag.Name = "usersecondnametag";
            this.usersecondnametag.Size = new System.Drawing.Size(211, 40);
            this.usersecondnametag.TabIndex = 3;
            this.usersecondnametag.Text = "Second Name : ";
            // 
            // agetag
            // 
            this.agetag.AutoSize = true;
            this.agetag.Location = new System.Drawing.Point(12, 375);
            this.agetag.Name = "agetag";
            this.agetag.Size = new System.Drawing.Size(88, 40);
            this.agetag.TabIndex = 4;
            this.agetag.Text = "Age : ";
            // 
            // userfirstname
            // 
            this.userfirstname.Location = new System.Drawing.Point(271, 50);
            this.userfirstname.Name = "userfirstname";
            this.userfirstname.Size = new System.Drawing.Size(387, 46);
            this.userfirstname.TabIndex = 5;
            this.userfirstname.TextChanged += new System.EventHandler(this.inputboxforusername_TextChanged);
            // 
            // userSecondname
            // 
            this.userSecondname.Location = new System.Drawing.Point(271, 137);
            this.userSecondname.Name = "userSecondname";
            this.userSecondname.Size = new System.Drawing.Size(387, 46);
            this.userSecondname.TabIndex = 6;
            this.userSecondname.TextChanged += new System.EventHandler(this.inputboxforuserlastname_TextChanged);
            // 
            // useremail
            // 
            this.useremail.Location = new System.Drawing.Point(271, 210);
            this.useremail.Name = "useremail";
            this.useremail.Size = new System.Drawing.Size(387, 46);
            this.useremail.TabIndex = 7;
            // 
            // userpassword
            // 
            this.userpassword.Location = new System.Drawing.Point(271, 293);
            this.userpassword.Name = "userpassword";
            this.userpassword.Size = new System.Drawing.Size(387, 46);
            this.userpassword.TabIndex = 8;
            this.userpassword.Text = "0";
            this.userpassword.TextChanged += new System.EventHandler(this.userpassword_TextChanged);
            // 
            // userage
            // 
            this.userage.Location = new System.Drawing.Point(271, 369);
            this.userage.Name = "userage";
            this.userage.Size = new System.Drawing.Size(387, 46);
            this.userage.TabIndex = 9;
            this.userage.Text = "0";
            // 
            // createnewuserbuttton
            // 
            this.createnewuserbuttton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createnewuserbuttton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createnewuserbuttton.Location = new System.Drawing.Point(271, 437);
            this.createnewuserbuttton.Name = "createnewuserbuttton";
            this.createnewuserbuttton.Size = new System.Drawing.Size(183, 70);
            this.createnewuserbuttton.TabIndex = 10;
            this.createnewuserbuttton.Text = "Signup!";
            this.createnewuserbuttton.UseVisualStyleBackColor = true;
            this.createnewuserbuttton.Click += new System.EventHandler(this.button1_Click);
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(699, 510);
            this.Controls.Add(this.createnewuserbuttton);
            this.Controls.Add(this.userage);
            this.Controls.Add(this.userpassword);
            this.Controls.Add(this.useremail);
            this.Controls.Add(this.userSecondname);
            this.Controls.Add(this.userfirstname);
            this.Controls.Add(this.agetag);
            this.Controls.Add(this.usersecondnametag);
            this.Controls.Add(this.useremailtag);
            this.Controls.Add(this.userpasswordtag);
            this.Controls.Add(this.userfirstnametag);
            this.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "signupForm";
            this.Text = "Dashboard - USER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userfirstnametag;
        private Label userpasswordtag;
        private Label useremailtag;
        private Label usersecondnametag;
        private Label agetag;
        private TextBox userfirstname;
        private TextBox userSecondname;
        private TextBox useremail;
        private TextBox userpassword;
        private TextBox userage;
        private Button createnewuserbuttton;
    }
}