using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartBusProject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //new HelpForm().Show();
            //this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            foreach (SmartBusProject.User users in Program.users)
            {
                if (users.getName().Equals(UserName.Text))
                {
                    MessageBox.Show("This User already exists");
                    return;
                }
            }

            if (UserName.Text == "" || Password.Text == "") return;

            SmartBusProject.User user = new SmartBusProject.User(UserName.Text, Password.Text, UserType.Passenger);
            Program.users.Add(user);

            MessageBox.Show("You have successfully registered!\nPlease now log-in!");

            new LoginForm().Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            if (UserName.Text == null) return;
            if (UserName.Text != "Username") return;
            UserName.Text = "";
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text == null) return;
            if (Password.Text != "Password") return;
            Password.Text = "";
        }
    }
}
