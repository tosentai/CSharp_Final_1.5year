using Final.Core.Context;
using Final.Core.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Final.UserInterface
{
    public partial class admin_addUser : UserControl
    {
        private FinalContext _context;

        public admin_addUser()
        {
            InitializeComponent();
        }

        public admin_addUser(FinalContext context)
        {
            InitializeComponent();
            _context = context;
            displayData();
        }

        public void SetContext(FinalContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context), "Context cannot be null.");
            }

            _context = context;

            if (!DesignMode)
            {
                displayData();
            }
        }

        public void displayData()
        {
            if (_context == null || DesignMode) return;

            var users = _context.Users.ToList();
            dataGridView1.DataSource = users;
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayData();
        }


        private void addUser_addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUser_username.Text) || string.IsNullOrWhiteSpace(addUser_password.Text)
                || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingUser = _context.Users
                .FirstOrDefault(u => u.Username == addUser_username.Text.Trim());

            if (existingUser != null)
            {
                string tempUsern = addUser_username.Text.Substring(0, 1).ToUpper() + addUser_username.Text.Substring(1);
                MessageBox.Show($"{tempUsern} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addUser_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = new Users
            {
                Username = addUser_username.Text.Trim(),
                Password = addUser_password.Text.Trim(),
                Role = addUser_role.SelectedItem.ToString(),
                Status = addUser_status.SelectedItem.ToString(),
                DateRegister = DateTime.Today
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            clearFields();
            displayData();

            MessageBox.Show("User added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void clearFields()
        {
            addUser_username.Text = "";
            addUser_password.Text = "";
            addUser_role.SelectedIndex = -1;
            addUser_status.SelectedIndex = -1;
        }

        private void addUser_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUser_updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUser_username.Text) || string.IsNullOrWhiteSpace(addUser_password.Text)
                || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this user?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var userToUpdate = _context.Users
                    .FirstOrDefault(u => u.Username == addUser_username.Text.Trim());

                if (userToUpdate != null)
                {
                    userToUpdate.Password = addUser_password.Text.Trim();
                    userToUpdate.Role = addUser_role.SelectedItem.ToString();
                    userToUpdate.Status = addUser_status.SelectedItem.ToString();

                    _context.SaveChanges();

                    displayData();
                    MessageBox.Show("User updated successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int getID;

        private void addUser_deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUser_username.Text) || string.IsNullOrWhiteSpace(addUser_password.Text)
                || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var userToDelete = _context.Users
                    .FirstOrDefault(u => u.Username == addUser_username.Text.Trim());

                if (userToDelete != null)
                {
                    _context.Users.Remove(userToDelete);
                    _context.SaveChanges();

                    displayData();
                    MessageBox.Show("User deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addUser_username.Text = row.Cells[1].Value.ToString();
                addUser_password.Text = row.Cells[2].Value.ToString();
                addUser_role.Text = row.Cells[3].Value.ToString();
                addUser_status.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
