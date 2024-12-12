using Final.Core.Context;
using Microsoft.EntityFrameworkCore;
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
    public partial class staffMainForm : Form
    {
        private readonly FinalContext _context;

        public staffMainForm(FinalContext context)
        {
            InitializeComponent();
            _context = context;
            staff_bookRoom1.SetContext(_context);
            admin_customers1.SetContext(_context);
            admin_dashboard1.SetContext(_context);
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm login = new LoginForm(_context);
                login.Show();

                this.Hide();
            }
        }

        private void addUser_Btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_customers1.Visible = false;
            staff_bookRoom1.Visible = true;

            staff_bookRoom adBookRoom = staff_bookRoom1 as staff_bookRoom;
            if (adBookRoom != null)
            {
                adBookRoom.RefreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            staff_bookRoom1.Visible = false;
            admin_customers1.Visible = true;

            admin_customers adCustomers = admin_customers1 as admin_customers;
            if (adCustomers != null)
            {
                adCustomers.RefreshData();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            staff_bookRoom1.Visible = false;
            admin_customers1.Visible = false;

            admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;

            if (adDashboard != null)
            {
                adDashboard.RefreshData();
            }
        }
    }
}
