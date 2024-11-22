using Membership;
using System;
using System.Windows.Forms;

namespace WareHouseApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnSignIn(object sender, EventArgs e)
        {
            // MessageBox.Show("Button is Clicked...");
            string userName = this.textBox1.Text;
            string password = this.textBox2.Text;
            bool status = false;
            status = AccountManager.Login(userName, password);
            if (status)
            {
                //MessageBox.Show("Welcome to WareHouse Application");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid user, Please try again");
            }
        }
    }
}
