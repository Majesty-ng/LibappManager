using libmanagerLibrary;
using libmanagerLibrary.models;

namespace libraryUI
{
    public partial class adminDashboard : Form
    {
        private List<userModel> userStore= GlobalConfig.Connection.getusers_all();
        private List<NewBookmodel> bookstore= GlobalConfig.Connection.getbooks_all();
        private void listlink()
        {
            Userlist.DataSource= userStore;
            Userlist.DisplayMember = "username";
            BookList.DataSource= bookstore;
            BookList.DisplayMember= "Bookname";
        }
        //private void sample()
        //{
        //    userModel model = new();
        //    userStore.Add(new userModel { firstName = "majesty", secondName = "chibuike" });
        //    userStore.Add(new userModel { firstName = "nneoma", secondName = "nnenna" });

        //    bookstore.Add(new NewBookmodel { Bookname = "wesley" });
        //    bookstore.Add(new NewBookmodel { Bookname = "boys from the men! " });
        //    //MessageBox.Show($"The application is about to start!");
        //} 
        private TextBox admincreatefirstname;
        private Label admincreatelastnametag;
        private TextBox admincreatelastname;
        private Label admincreateemailtag;
        private TextBox admincreateemail;
        private Label admincreateagetag;
        private TextBox admincreateage;
        private Label admincreatepasswordtag;
        private TextBox admincreatepassword;
        private Button admincreatenewuserbutton;
        private ListBox Userlist;
        private ListBox BookList;
        private Button adminuserdeletebutton;
        private Button adminbooksdeletebutton;
        private Label admincreatefirstnametag;
        public adminDashboard()
        {
            InitializeComponent();
            //sample();
            
            listlink();
        }
        private void InitializeComponent()
        {
            this.admincreatefirstnametag = new System.Windows.Forms.Label();
            this.admincreatefirstname = new System.Windows.Forms.TextBox();
            this.admincreatelastnametag = new System.Windows.Forms.Label();
            this.admincreatelastname = new System.Windows.Forms.TextBox();
            this.admincreateemailtag = new System.Windows.Forms.Label();
            this.admincreateemail = new System.Windows.Forms.TextBox();
            this.admincreateagetag = new System.Windows.Forms.Label();
            this.admincreateage = new System.Windows.Forms.TextBox();
            this.admincreatepasswordtag = new System.Windows.Forms.Label();
            this.admincreatepassword = new System.Windows.Forms.TextBox();
            this.admincreatenewuserbutton = new System.Windows.Forms.Button();
            this.Userlist = new System.Windows.Forms.ListBox();
            this.BookList = new System.Windows.Forms.ListBox();
            this.adminuserdeletebutton = new System.Windows.Forms.Button();
            this.adminbooksdeletebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admincreatefirstnametag
            // 
            this.admincreatefirstnametag.AutoSize = true;
            this.admincreatefirstnametag.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admincreatefirstnametag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.admincreatefirstnametag.Location = new System.Drawing.Point(316, 105);
            this.admincreatefirstnametag.Name = "admincreatefirstnametag";
            this.admincreatefirstnametag.Size = new System.Drawing.Size(98, 23);
            this.admincreatefirstnametag.TabIndex = 0;
            this.admincreatefirstnametag.Text = "First name: ";
            // 
            // admincreatefirstname
            // 
            this.admincreatefirstname.Location = new System.Drawing.Point(449, 105);
            this.admincreatefirstname.Name = "admincreatefirstname";
            this.admincreatefirstname.Size = new System.Drawing.Size(183, 23);
            this.admincreatefirstname.TabIndex = 1;
            // 
            // admincreatelastnametag
            // 
            this.admincreatelastnametag.AutoSize = true;
            this.admincreatelastnametag.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admincreatelastnametag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.admincreatelastnametag.Location = new System.Drawing.Point(316, 156);
            this.admincreatelastnametag.Name = "admincreatelastnametag";
            this.admincreatelastnametag.Size = new System.Drawing.Size(97, 23);
            this.admincreatelastnametag.TabIndex = 3;
            this.admincreatelastnametag.Text = "Last name: ";
            // 
            // admincreatelastname
            // 
            this.admincreatelastname.Location = new System.Drawing.Point(449, 156);
            this.admincreatelastname.Name = "admincreatelastname";
            this.admincreatelastname.Size = new System.Drawing.Size(183, 23);
            this.admincreatelastname.TabIndex = 4;
            // 
            // admincreateemailtag
            // 
            this.admincreateemailtag.AutoSize = true;
            this.admincreateemailtag.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admincreateemailtag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.admincreateemailtag.Location = new System.Drawing.Point(316, 203);
            this.admincreateemailtag.Name = "admincreateemailtag";
            this.admincreateemailtag.Size = new System.Drawing.Size(123, 23);
            this.admincreateemailtag.TabIndex = 5;
            this.admincreateemailtag.Text = "Email address: ";
            // 
            // admincreateemail
            // 
            this.admincreateemail.Location = new System.Drawing.Point(449, 203);
            this.admincreateemail.Name = "admincreateemail";
            this.admincreateemail.Size = new System.Drawing.Size(183, 23);
            this.admincreateemail.TabIndex = 6;
            // 
            // admincreateagetag
            // 
            this.admincreateagetag.AutoSize = true;
            this.admincreateagetag.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admincreateagetag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.admincreateagetag.Location = new System.Drawing.Point(316, 249);
            this.admincreateagetag.Name = "admincreateagetag";
            this.admincreateagetag.Size = new System.Drawing.Size(49, 23);
            this.admincreateagetag.TabIndex = 7;
            this.admincreateagetag.Text = "Age: ";
            // 
            // admincreateage
            // 
            this.admincreateage.Location = new System.Drawing.Point(449, 249);
            this.admincreateage.Name = "admincreateage";
            this.admincreateage.Size = new System.Drawing.Size(183, 23);
            this.admincreateage.TabIndex = 8;
            // 
            // admincreatepasswordtag
            // 
            this.admincreatepasswordtag.AutoSize = true;
            this.admincreatepasswordtag.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admincreatepasswordtag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.admincreatepasswordtag.Location = new System.Drawing.Point(316, 291);
            this.admincreatepasswordtag.Name = "admincreatepasswordtag";
            this.admincreatepasswordtag.Size = new System.Drawing.Size(89, 23);
            this.admincreatepasswordtag.TabIndex = 9;
            this.admincreatepasswordtag.Text = "Password: ";
            // 
            // admincreatepassword
            // 
            this.admincreatepassword.Location = new System.Drawing.Point(449, 291);
            this.admincreatepassword.Name = "admincreatepassword";
            this.admincreatepassword.Size = new System.Drawing.Size(183, 23);
            this.admincreatepassword.TabIndex = 10;
            // 
            // admincreatenewuserbutton
            // 
            this.admincreatenewuserbutton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admincreatenewuserbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.admincreatenewuserbutton.Location = new System.Drawing.Point(414, 334);
            this.admincreatenewuserbutton.Name = "admincreatenewuserbutton";
            this.admincreatenewuserbutton.Size = new System.Drawing.Size(171, 44);
            this.admincreatenewuserbutton.TabIndex = 11;
            this.admincreatenewuserbutton.Text = "Create new user!";
            this.admincreatenewuserbutton.UseVisualStyleBackColor = true;
            this.admincreatenewuserbutton.Click += new System.EventHandler(this.admincreatenewuserbutton_Click);
            // 
            // Userlist
            // 
            this.Userlist.FormattingEnabled = true;
            this.Userlist.ItemHeight = 15;
            this.Userlist.Location = new System.Drawing.Point(0, 12);
            this.Userlist.Name = "Userlist";
            this.Userlist.Size = new System.Drawing.Size(164, 199);
            this.Userlist.TabIndex = 12;
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.ItemHeight = 15;
            this.BookList.Location = new System.Drawing.Point(0, 263);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(164, 199);
            this.BookList.TabIndex = 13;
            // 
            // adminuserdeletebutton
            // 
            this.adminuserdeletebutton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminuserdeletebutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminuserdeletebutton.Location = new System.Drawing.Point(170, 32);
            this.adminuserdeletebutton.Name = "adminuserdeletebutton";
            this.adminuserdeletebutton.Size = new System.Drawing.Size(171, 44);
            this.adminuserdeletebutton.TabIndex = 14;
            this.adminuserdeletebutton.Text = "Delete selected user";
            this.adminuserdeletebutton.UseVisualStyleBackColor = true;
            // 
            // adminbooksdeletebutton
            // 
            this.adminbooksdeletebutton.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminbooksdeletebutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminbooksdeletebutton.Location = new System.Drawing.Point(170, 386);
            this.adminbooksdeletebutton.Name = "adminbooksdeletebutton";
            this.adminbooksdeletebutton.Size = new System.Drawing.Size(219, 44);
            this.adminbooksdeletebutton.TabIndex = 15;
            this.adminbooksdeletebutton.Text = "Delete selected book(s)";
            this.adminbooksdeletebutton.UseVisualStyleBackColor = true;
            // 
            // adminDashboard
            // 
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(675, 503);
            this.Controls.Add(this.adminbooksdeletebutton);
            this.Controls.Add(this.adminuserdeletebutton);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.Userlist);
            this.Controls.Add(this.admincreatenewuserbutton);
            this.Controls.Add(this.admincreatepassword);
            this.Controls.Add(this.admincreatepasswordtag);
            this.Controls.Add(this.admincreateage);
            this.Controls.Add(this.admincreateagetag);
            this.Controls.Add(this.admincreateemail);
            this.Controls.Add(this.admincreateemailtag);
            this.Controls.Add(this.admincreatelastname);
            this.Controls.Add(this.admincreatelastnametag);
            this.Controls.Add(this.admincreatefirstname);
            this.Controls.Add(this.admincreatefirstnametag);
            this.Name = "adminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /// <summary>
        /// validates the admin user creation form
        /// </summary>
        /// <returns></returns>
        private bool validateusercreationform()
        {
            
            int check = 1;
            bool output = true;
            
            //bool value check for non string input for user firstname
            bool createfirstnamevalid = int.TryParse(admincreatefirstnametag.Text, out check);
            if(createfirstnamevalid== true)
            {
                output = false;
            }

            //bool value check for non string input for user secondname
            bool createsecondnamevalid = int.TryParse(admincreatelastname.Text, out check);
            if(createsecondnamevalid== true)
            {
                output = false;
            }




            //bool value check for non int input for user age
            bool createagevalid = int.TryParse(admincreateage.Text, out check);
            if(createagevalid== false)
            {
                output = false;
            }




            //bool value check for non string input for user password
           



            //bool value check for nonstring input for user email
            bool createemailvalid = int.TryParse(admincreateemail.Text, out check); 
            if(createemailvalid== true)
            {
                output = false;
            }
            return output;
        }


        /// <summary>
        /// creates a new user list, applies the global config.conection.createnewuser method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void admincreatenewuserbutton_Click(object sender, EventArgs e)
        {
            if (validateusercreationform())
            {

                userModel model = new userModel();
                model.firstName = admincreatefirstname.Text;
                model.secondName = admincreatelastname.Text;
                model.emailaddress = admincreateemail.Text;
                model.Password = admincreatepassword.Text;
                model.age = int.Parse(admincreateage.Text);
                
                
                GlobalConfig.Connection.createnewuser(model);
                admincreatefirstname.Text = "";
                admincreatelastname.Text = "";
                admincreateage.Text = "0";
                admincreateemail.Text = "";
                admincreatepassword.Text = "0";

            }
            // throws an error message when form contains an invalid information
            else
            {
                MessageBox.Show("The form has invalid information, Please try again");
            }
        }
    }
}
