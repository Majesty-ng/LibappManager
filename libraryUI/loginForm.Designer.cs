namespace libraryUI
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstnameTag = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.Label();
            this.userpasswordbox = new System.Windows.Forms.TextBox();
            this.orTag = new System.Windows.Forms.Label();
            this.loginLink = new System.Windows.Forms.Button();
            this.signupLinkTag = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstnameTag
            // 
            this.firstnameTag.AutoSize = true;
            this.firstnameTag.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameTag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.firstnameTag.Location = new System.Drawing.Point(70, 119);
            this.firstnameTag.Name = "firstnameTag";
            this.firstnameTag.Size = new System.Drawing.Size(124, 30);
            this.firstnameTag.TabIndex = 1;
            this.firstnameTag.Text = "First Name : ";
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(222, 103);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(312, 46);
            this.Firstname.TabIndex = 4;
            this.Firstname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // userPassword
            // 
            this.userPassword.AutoSize = true;
            this.userPassword.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userPassword.Location = new System.Drawing.Point(70, 185);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(111, 30);
            this.userPassword.TabIndex = 6;
            this.userPassword.Text = "Password : ";
            this.userPassword.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // userpasswordbox
            // 
            this.userpasswordbox.Location = new System.Drawing.Point(222, 185);
            this.userpasswordbox.Name = "userpasswordbox";
            this.userpasswordbox.Size = new System.Drawing.Size(312, 46);
            this.userpasswordbox.TabIndex = 7;
            this.userpasswordbox.TextChanged += new System.EventHandler(this.userpasswordbox_TextChanged);
            // 
            // orTag
            // 
            this.orTag.AutoSize = true;
            this.orTag.Font = new System.Drawing.Font("Segoe UI Light", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orTag.ForeColor = System.Drawing.SystemColors.WindowText;
            this.orTag.Location = new System.Drawing.Point(324, 278);
            this.orTag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.orTag.Name = "orTag";
            this.orTag.Size = new System.Drawing.Size(75, 31);
            this.orTag.TabIndex = 8;
            this.orTag.Text = "- OR -";
            this.orTag.Click += new System.EventHandler(this.orTag_Click);
            // 
            // loginLink
            // 
            this.loginLink.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loginLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loginLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loginLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLink.Location = new System.Drawing.Point(266, 25);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(201, 51);
            this.loginLink.TabIndex = 10;
            this.loginLink.Text = "Login";
            this.loginLink.UseVisualStyleBackColor = true;
            this.loginLink.Click += new System.EventHandler(this.loginLink_Click);
            // 
            // signupLinkTag
            // 
            this.signupLinkTag.AutoSize = true;
            this.signupLinkTag.Location = new System.Drawing.Point(309, 339);
            this.signupLinkTag.Name = "signupLinkTag";
            this.signupLinkTag.Size = new System.Drawing.Size(113, 40);
            this.signupLinkTag.TabIndex = 11;
            this.signupLinkTag.TabStop = true;
            this.signupLinkTag.Text = "Sign-up";
            this.signupLinkTag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLinkTag_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(221, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "User name is the same as your first name!";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(705, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupLinkTag);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.orTag);
            this.Controls.Add(this.userpasswordbox);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.firstnameTag);
            this.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "loginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label firstnameTag;
        private TextBox Firstname;
        private Label userPassword;
        private TextBox userpasswordbox;
        private Label orTag;
        private Button loginLink;
        private LinkLabel signupLinkTag;
        private Label label1;
    }
}