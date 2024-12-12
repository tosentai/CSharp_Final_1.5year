﻿using Final.Core.Context;
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
    public partial class AdminMainForm : Form
    {
        private readonly FinalContext _context;

        public AdminMainForm(FinalContext context)
        {
            InitializeComponent();
            _context = context;
            admin_addUser1.SetContext(_context);
            admin_rooms1.SetContext(_context);
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
            admin_addUser1.Visible = true;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = false;

            admin_addUser adUser = admin_addUser1 as admin_addUser;

            if (adUser != null)
            {
                adUser.RefreshData();
            }
        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_addUser1.Visible = false;
            admin_rooms1.Visible = true;
            admin_customers1.Visible = false;

            admin_rooms adRooms = admin_rooms1 as admin_rooms;

            if (adRooms != null)
            {
                adRooms.RefreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_addUser1.Visible = false;
            admin_rooms1.Visible = false;
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
            admin_addUser1.Visible = false;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = false;

            admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;

            if (adDashboard != null)
            {
                adDashboard.LoadDashboardData();
            }
        }
    }
}
