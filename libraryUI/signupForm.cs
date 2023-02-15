using libmanagerLibrary;
using libmanagerLibrary.DataAccess;
using libmanagerLibrary.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryUI
{
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateSignform())
            {
                userModel model = new userModel();
                model.firstName = userfirstname.Text;
                model.secondName = userSecondname.Text;
                model.age = int.Parse(userage.Text);
                model.emailaddress = useremail.Text;
                model.Password = userpassword.Text;
                GlobalConfig.Connection.createnewuser(model);
                userfirstname.Text = "";
                userSecondname.Text = "";
                userage.Text = "0";
                useremail.Text = "";
                userpassword.Text = "0";

            }
            else
            {
                MessageBox.Show("The form has invalid information, Please try again");
            }
        }

        private void signupForm_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateSignform()
        {
            bool output = true;
            int age = 0;
            bool agevalid = int.TryParse((userage.Text).TrimStart(), out age);
            if (agevalid == false)
            {
                output = false;
            }
            if(age < 18)
            {
                output = false;
            }
            if(userage.Text.Length == 0)
            {
                output = false;
            }




            int nn = 0;
            bool firstnamevalid = int.TryParse(userfirstname.Text, out nn);
            if (firstnamevalid == true)
            {
                output = false;
            }

            
            bool secondnamevalid = int.TryParse(userSecondname.Text, out nn);
            if (secondnamevalid == true)
            {
                output = false;
            }
            if (userSecondname.Text.Length == 0)
            {
                output = false;
            }


            
            bool emailvalid = int.TryParse(useremail.Text, out nn);
            if (emailvalid == true)
            {
                output = false;
            }
            if (useremail.Text.Length == 0)
            {
                output = false;
            }



            
            bool passwordvalid = int.TryParse(userpassword.Text, out nn);
            if (userpassword.Text.Length == 0)
            {
                output = false;
            }
            if(passwordvalid == false)
            {
                output = false;
            }
            return output;
        }

        private void inputboxforusername_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// method to checkif the correct email is put in 
        /// </summary>
        /// <returns></returns>
        //private bool checkemail()
        //{
        //    string email = useremail.Text;
        //    bool output = true;
        //    //@gmail.com
        //    return true;
        //}

        private void inputboxforuserlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void userfirstnametag_Click(object sender, EventArgs e)
        {

        }

        private void userpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
