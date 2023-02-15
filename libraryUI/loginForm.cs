namespace libraryUI
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

     

        private void loginLink_Click(object sender, EventArgs e)
        {
            if (validateform())
            {

            }
        }

        private void orTag_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void userpasswordbox_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validateform()
        {
            int nn = 0;
            bool output = true;
            bool namevalid = int.TryParse(Firstname.Text, out nn);
            if (namevalid == true)
            {
                output = false;
            }
            if (Firstname.Text.Length == 0)
            {
                output = false;
            }

            if(userPassword.Text.Length == 0)
            {
                output = false;
            }
            bool passwordvalid = int.TryParse(userPassword.Text,out nn);
            if(passwordvalid == false)
            {
                output = false;
            }
            return output;
        }

        private void signupLinkTag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}