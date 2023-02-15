using libmanagerLibrary;
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
    public partial class adminAddbook : Form
    {
        public adminAddbook()
        {
            InitializeComponent();
        }

        private void authorname_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validateform()
        {
            bool output = true;
            int nn = 0;
            bool authornamevalid = int.TryParse(authorname.Text, out nn);
            if (authornamevalid)
            {
                output = false;
            }
            if(authorname.Text.Length == 0)
            {
                output = false;
            }
            

            bool numberofpagesvalid = int.TryParse(numberofpages.Text, out nn);
            if (numberofpagesvalid) 
            {
                output = false;
            }
            if (numberofpages.Text.Length == 0)
            {
                output = false;
            }


            bool categoryvalid = int.TryParse(category.Text, out nn);
            if (categoryvalid)
            {
                output = false;
            }
            if(category.Text.Length == 0)
            {
                output = false;
            }

            bool booknamevalid = int.TryParse(bookname.Text, out nn);
            if (booknamevalid)
            {
                output = false;
            }
            if(bookname.Text.Length == 0)
            {
                output= false;
            }
            return output;
        }

        private void numberofpages_TextChanged(object sender, EventArgs e)
        {

        }

        private void category_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void createanewbook_Click(object sender, EventArgs e)
        {
            if (validateform())
            {
                NewBookmodel model = new NewBookmodel();
                model.AuthorName = authorname.Text;
                model.Bookname = bookname.Text;
                model.Noofpages = numberofpages.Text;
                model.Category = category.Text;
                GlobalConfig.Connection.createnewbook(model);
                authorname.Text = "";
                bookname.Text = "";
                numberofpages.Text = "";
                category.Text = "";
            }
            else
            {
                MessageBox.Show("The form has invalid information, Please try again!");
            }
        }

        private void authornametag_Click(object sender, EventArgs e)
        {

        }

        private void numberofpagestag_Click(object sender, EventArgs e)
        {

        }

        private void categorytag_Click(object sender, EventArgs e)
        {

        }

        private void booknametag_Click(object sender, EventArgs e)
        {

        }
    }
}
