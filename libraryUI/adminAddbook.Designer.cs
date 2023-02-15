namespace libraryUI
{
    partial class adminAddbook
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
            this.authornametag = new System.Windows.Forms.Label();
            this.authorname = new System.Windows.Forms.TextBox();
            this.numberofpagestag = new System.Windows.Forms.Label();
            this.numberofpages = new System.Windows.Forms.TextBox();
            this.categorytag = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.booknametag = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.TextBox();
            this.createanewbook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authornametag
            // 
            this.authornametag.AutoSize = true;
            this.authornametag.Location = new System.Drawing.Point(46, 43);
            this.authornametag.Name = "authornametag";
            this.authornametag.Size = new System.Drawing.Size(198, 40);
            this.authornametag.TabIndex = 0;
            this.authornametag.Text = "Author Name: ";
            this.authornametag.Click += new System.EventHandler(this.authornametag_Click);
            // 
            // authorname
            // 
            this.authorname.Location = new System.Drawing.Point(303, 43);
            this.authorname.Name = "authorname";
            this.authorname.Size = new System.Drawing.Size(334, 46);
            this.authorname.TabIndex = 1;
            this.authorname.TextChanged += new System.EventHandler(this.authorname_TextChanged);
            // 
            // numberofpagestag
            // 
            this.numberofpagestag.AutoSize = true;
            this.numberofpagestag.Location = new System.Drawing.Point(46, 121);
            this.numberofpagestag.Name = "numberofpagestag";
            this.numberofpagestag.Size = new System.Drawing.Size(244, 40);
            this.numberofpagestag.TabIndex = 2;
            this.numberofpagestag.Text = "Number of pages: ";
            this.numberofpagestag.Click += new System.EventHandler(this.numberofpagestag_Click);
            // 
            // numberofpages
            // 
            this.numberofpages.Location = new System.Drawing.Point(303, 121);
            this.numberofpages.Name = "numberofpages";
            this.numberofpages.Size = new System.Drawing.Size(334, 46);
            this.numberofpages.TabIndex = 3;
            this.numberofpages.TextChanged += new System.EventHandler(this.numberofpages_TextChanged);
            // 
            // categorytag
            // 
            this.categorytag.AutoSize = true;
            this.categorytag.Location = new System.Drawing.Point(46, 190);
            this.categorytag.Name = "categorytag";
            this.categorytag.Size = new System.Drawing.Size(144, 40);
            this.categorytag.TabIndex = 4;
            this.categorytag.Text = "Category: ";
            this.categorytag.Click += new System.EventHandler(this.categorytag_Click);
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(303, 184);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(334, 46);
            this.category.TabIndex = 5;
            this.category.TextChanged += new System.EventHandler(this.category_TextChanged);
            // 
            // booknametag
            // 
            this.booknametag.AutoSize = true;
            this.booknametag.Location = new System.Drawing.Point(46, 249);
            this.booknametag.Name = "booknametag";
            this.booknametag.Size = new System.Drawing.Size(169, 40);
            this.booknametag.TabIndex = 6;
            this.booknametag.Text = "Book name: ";
            this.booknametag.Click += new System.EventHandler(this.booknametag_Click);
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(303, 243);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(334, 46);
            this.bookname.TabIndex = 7;
            this.bookname.TextChanged += new System.EventHandler(this.bookname_TextChanged);
            // 
            // createanewbook
            // 
            this.createanewbook.Location = new System.Drawing.Point(234, 366);
            this.createanewbook.Name = "createanewbook";
            this.createanewbook.Size = new System.Drawing.Size(162, 81);
            this.createanewbook.TabIndex = 8;
            this.createanewbook.Text = "Create";
            this.createanewbook.UseVisualStyleBackColor = true;
            this.createanewbook.Click += new System.EventHandler(this.createanewbook_Click);
            // 
            // adminAddbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(705, 459);
            this.Controls.Add(this.createanewbook);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.booknametag);
            this.Controls.Add(this.category);
            this.Controls.Add(this.categorytag);
            this.Controls.Add(this.numberofpages);
            this.Controls.Add(this.numberofpagestag);
            this.Controls.Add(this.authorname);
            this.Controls.Add(this.authornametag);
            this.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "adminAddbook";
            this.Text = "Admin_Dashboard - Add books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label authornametag;
        private TextBox authorname;
        private Label numberofpagestag;
        private TextBox numberofpages;
        private Label categorytag;
        private TextBox category;
        private Label booknametag;
        private TextBox bookname;
        private Button createanewbook;
    }
}