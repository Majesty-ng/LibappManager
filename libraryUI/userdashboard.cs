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
    public partial class userdashboard : Form
    {
        private List<NewBookmodel> selectedbooks= GlobalConfig.Connection.getbooks_all();
        private List<NewBookmodel> pendingBooks = new();
        private void userlistlink()
        {
            NewBookmodel model = new();
            bookdropdownlist.DataSource = selectedbooks;
            bookdropdownlist.DisplayMember= "Bookname";

            BorrowedBooksBox.DataSource= pendingBooks;
            BorrowedBooksBox.DisplayMember = "Bookname";
            //MessageBox.Show($"{model.Bookname}");
        }
        public userdashboard()
        {
            InitializeComponent();
            userlistlink();

        }

        private void borrowbooksbutton_Click(object sender, EventArgs e)
        {
            NewBookmodel p = (NewBookmodel)bookdropdownlist.SelectedItem;
            selectedbooks.Remove(p);
            pendingBooks.Add(p);
            userlistlink();
        }
    }
}
