using System.Drawing.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartBusProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserName.Text != "Username" && UserName.Text != "" && Password.Text != "Password" && Password.Text != "")
            {
                bool found = false;
                foreach (SmartBusProject.User user in Program.users)
                {
                    if (user.getName().Equals(UserName.Text))
                    {
                        if (user.getPassword().Equals(Password.Text))
                        {
                            found = true;
                            Program.userInstance = user;
                            break;
                        }
                    }
                }


                if (!found)
                {
                    MessageBox.Show("Could not find a user with this username");
                    return;
                }

                MessageBox.Show("Logged in.\nWelcome back, " + Program.userInstance.getName() + "!");

                if (Program.userInstance.getType() == UserType.Passenger)
                {
                    new PassengersMainForm().Show();
                }
                else
                {
                    new DriverMainForm().Show();
                }

                this.Hide();

                return;
            }

            MessageBox.Show("Please enter your credentials!");
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //new HelpForm().Show();
            //this.Hide();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
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
