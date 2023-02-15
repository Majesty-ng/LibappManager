namespace libraryUI
{
    partial class userdashboard
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
            this.userprofileLink = new System.Windows.Forms.LinkLabel();
            this.bookdropdownlist = new System.Windows.Forms.ComboBox();
            this.borrowbooksbutton = new System.Windows.Forms.Button();
            this.BorrowedBooksBox = new System.Windows.Forms.ListBox();
            this.bookreturn = new System.Windows.Forms.Button();
            this.bookdetaillsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userprofileLink
            // 
            this.userprofileLink.AutoSize = true;
            this.userprofileLink.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userprofileLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.userprofileLink.Location = new System.Drawing.Point(606, 9);
            this.userprofileLink.Name = "userprofileLink";
            this.userprofileLink.Size = new System.Drawing.Size(55, 23);
            this.userprofileLink.TabIndex = 0;
            this.userprofileLink.TabStop = true;
            this.userprofileLink.Text = "Profile";
            // 
            // bookdropdownlist
            // 
            this.bookdropdownlist.Font = new System.Drawing.Font("Segoe UI Light", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookdropdownlist.FormattingEnabled = true;
            this.bookdropdownlist.Location = new System.Drawing.Point(12, 89);
            this.bookdropdownlist.Name = "bookdropdownlist";
            this.bookdropdownlist.Size = new System.Drawing.Size(260, 63);
            this.bookdropdownlist.TabIndex = 8;
            this.bookdropdownlist.Text = "Books";
            // 
            // borrowbooksbutton
            // 
            this.borrowbooksbutton.Font = new System.Drawing.Font("Segoe UI Light", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowbooksbutton.Location = new System.Drawing.Point(3, 206);
            this.borrowbooksbutton.Name = "borrowbooksbutton";
            this.borrowbooksbutton.Size = new System.Drawing.Size(185, 32);
            this.borrowbooksbutton.TabIndex = 9;
            this.borrowbooksbutton.Text = "Add book to borrow list";
            this.borrowbooksbutton.UseVisualStyleBackColor = true;
            this.borrowbooksbutton.Click += new System.EventHandler(this.borrowbooksbutton_Click);
            // 
            // BorrowedBooksBox
            // 
            this.BorrowedBooksBox.FormattingEnabled = true;
            this.BorrowedBooksBox.ItemHeight = 40;
            this.BorrowedBooksBox.Location = new System.Drawing.Point(425, 41);
            this.BorrowedBooksBox.Name = "BorrowedBooksBox";
            this.BorrowedBooksBox.Size = new System.Drawing.Size(253, 404);
            this.BorrowedBooksBox.TabIndex = 10;
            // 
            // bookreturn
            // 
            this.bookreturn.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookreturn.Location = new System.Drawing.Point(425, 457);
            this.bookreturn.Name = "bookreturn";
            this.bookreturn.Size = new System.Drawing.Size(221, 32);
            this.bookreturn.TabIndex = 12;
            this.bookreturn.Text = "Return selected pending";
            this.bookreturn.UseVisualStyleBackColor = true;
            // 
            // bookdetaillsbutton
            // 
            this.bookdetaillsbutton.Font = new System.Drawing.Font("Segoe UI Light", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookdetaillsbutton.Location = new System.Drawing.Point(204, 206);
            this.bookdetaillsbutton.Name = "bookdetaillsbutton";
            this.bookdetaillsbutton.Size = new System.Drawing.Size(185, 32);
            this.bookdetaillsbutton.TabIndex = 13;
            this.bookdetaillsbutton.Text = "Show book details";
            this.bookdetaillsbutton.UseVisualStyleBackColor = true;
            // 
            // userdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(690, 515);
            this.Controls.Add(this.bookdetaillsbutton);
            this.Controls.Add(this.bookreturn);
            this.Controls.Add(this.BorrowedBooksBox);
            this.Controls.Add(this.borrowbooksbutton);
            this.Controls.Add(this.bookdropdownlist);
            this.Controls.Add(this.userprofileLink);
            this.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "userdashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel userprofileLink;
        private ComboBox bookdropdownlist;
        private Button borrowbooksbutton;
        private ListBox BorrowedBooksBox;
        private Button bookreturn;
        private Button bookdetaillsbutton;
    }
}