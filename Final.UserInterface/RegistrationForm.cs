using Final.Core.Context;
using Final.Core.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace Final.UserInterface
{
    public partial class RegistrationForm : Form
    {
        private readonly FinalContext _context;

        public RegistrationForm(FinalContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_sgininBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(_context);
            loginForm.Show();

            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register__cpassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(register_username.Text) ||
        string.IsNullOrWhiteSpace(register_password.Text) ||
        string.IsNullOrWhiteSpace(register__cpassword.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var existingUser = _context.Users
                    .FirstOrDefault(u => u.Username == register_username.Text.Trim());

                if (existingUser != null)
                {
                    string tempEmail = char.ToUpper(register_username.Text[0]) + register_username.Text.Substring(1);
                    MessageBox.Show($"{tempEmail} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (register_password.Text.Length < 8)
                {
                    MessageBox.Show("Invalid password. Must be at least 8 characters long.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (register_password.Text != register__cpassword.Text)
                {
                    MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newUser = new Users
                {
                    Username = register_username.Text.Trim(),
                    Password = register_password.Text.Trim(),
                    Role = "Staff",
                    Status = "Active",
                    DateRegister = DateTime.Today
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();

                MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginForm loginForm = new LoginForm(_context);
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
