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
    public partial class admin_dashboard : UserControl
    {
        private FinalContext _context;

        public admin_dashboard()
        {
            InitializeComponent();
        }

        public admin_dashboard(FinalContext context)
        {
            InitializeComponent();
            _context = context;
            LoadDashboardData();
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
                LoadDashboardData();
            }
        }

        public void LoadDashboardData()
        {
            if (_context == null)
            {
                MessageBox.Show("Context is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DisplayTotalStaff();
            DisplayAvailableRooms();
            DisplayProfitToday();
            DisplayProfitTotal();
            DisplayAllRooms();
        }

        public void DisplayTotalStaff()
        {
            if (_context != null)
            {
                int totalStaffCount = _context.Users.Count(u => u.Role == "STAFF");
                totalStaff.Text = totalStaffCount.ToString();
            }
        }

        public void DisplayAvailableRooms()
        {
            if (_context != null)
            {
                int availableRoomsCount = _context.Rooms.Count(r => r.Status == "Active" || r.Status == "Available");
                AvailableRooms.Text = availableRoomsCount.ToString();
            }
        }

        public void DisplayProfitToday()
        {
            if (_context != null)
            {
                DateTime today = DateTime.Today;

                decimal profitTodayValue = _context.Customers
                    .Where(c => c.DateBook.HasValue && c.DateBook.Value.Date == today)
                    .Sum(c => (decimal?)c.Price) ?? 0;

                profitToday.Text = $"${profitTodayValue:F2}";
            }
        }


        public void DisplayProfitTotal()
        {
            if (_context != null)
            {
                decimal totalProfitValue = _context.Customers.Sum(c => (decimal?)c.Price) ?? 0;
                totalProfit.Text = $"${totalProfitValue:F2}";
            }
        }

        public void DisplayAllRooms()
        {
            if (_context != null)
            {
                var rooms = _context.Rooms.ToList();
                dataGridView1.DataSource = rooms;
            }
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            LoadDashboardData();
        }

        private void admin_dashboard_GenUserRep_Click(object sender, EventArgs e)

        {
            ReportGenerator reportGenerator = new ReportGenerator(_context);
            reportGenerator.GenerateUserReport();
        }

        private void admin_dashboard_GenRoomRep_Click(object sender, EventArgs e)
        {
            ReportGenerator reportGenerator = new ReportGenerator(_context);
            reportGenerator.GenerateRoomReport();
        }

        private void admin_dashboard_GenCustomerRep_Click(object sender, EventArgs e)
        {
            ReportGenerator reportGenerator = new ReportGenerator(_context);
            reportGenerator.GenerateCustomerReport();
        }
    }

}
