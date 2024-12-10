using Final.Core.Context;

namespace Final.UserInterface
{
    public partial class LoginForm : Form
    {
        private readonly FinalContext _context;

        public LoginForm(FinalContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm(_context);
            regForm.Show();

            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_username.Text) || string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.Username == login_username.Text.Trim()
                                         && u.Password == login_password.Text.Trim()
                                         && u.Status == "Active");

                if (user != null)
                {
                    MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (user.Role == "Admin")
                    {
                        AdminMainForm adminForm = new AdminMainForm(_context);
                        adminForm.Show();

                        this.Hide();
                    }
                    else if (user.Role == "Staff")
                    {
                        staffMainForm staffForm = new staffMainForm(_context);
                        staffForm.Show();

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
