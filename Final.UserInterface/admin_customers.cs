using Final.Core.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.UserInterface
{
    public partial class admin_customers : UserControl
    {
        private FinalContext _context;

        public admin_customers()
        {
            InitializeComponent();
        }

        public admin_customers(FinalContext context)
        {
            InitializeComponent();
            _context = context;
            DisplayCustomers();
        }

        public void SetContext(FinalContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context), "Context cannot be null.");
            }
            _context = context;
            DisplayCustomers();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayCustomers();
        }

        public void DisplayCustomers()
        {
            if (_context == null)
            {
                MessageBox.Show("Context is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var customers = _context.Customers.ToList();

                dataGridView1.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void admin_rooms_deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                var customer = _context.Customers.FirstOrDefault(c => c.Id == selectedId);
                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DisplayCustomers();
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int selectedId;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }
    }
}
