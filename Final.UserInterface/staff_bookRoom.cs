using Final.Core.Context;
using Final.Core.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.UserInterface
{
    public partial class staff_bookRoom : UserControl
    {
        private FinalContext _context;
        private int getID = 0;
        private decimal regprice = 0;

        public staff_bookRoom()
        {
            InitializeComponent();
        }

        public staff_bookRoom(FinalContext context)
        {
            InitializeComponent();

            if (!DesignMode)
            {
                _context = context;
                DisplayRooms();
            }
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
                DisplayRooms();
            }
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayRooms();
        }

        public void DisplayRooms()
        {
            if (_context == null)
            {
                throw new InvalidOperationException("Context is not set. Use SetContext to initialize it.");
            }

            var rooms = _context.Rooms
                .Select(r => new
                {
                    r.Id,
                    r.RoomId,
                    r.Type,
                    r.RoomName,
                    r.Price,
                    r.ImagePath,
                    r.Status
                })
                .ToList();

            dataGridView1.DataSource = rooms;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells["Id"].Value);
                bookRoom_roomID.Text = row.Cells["RoomId"].Value.ToString();
                bookRoom_roomType.Text = row.Cells["Type"].Value.ToString();
                bookRoom_roomName.Text = row.Cells["RoomName"].Value.ToString();
                bookRoom_regPrice.Text = Convert.ToDecimal(row.Cells["Price"].Value).ToString("0.00");
                regprice = Convert.ToDecimal(row.Cells["Price"].Value);

                bookRoom_imageView.ImageLocation = row.Cells["ImagePath"].Value?.ToString();
                bookRoom_status.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void bookRoom_scheduleBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = bookRoom_from.Value;
            DateTime toDate = bookRoom_to.Value;

            TimeSpan countDays = toDate - fromDate;

            int days = countDays.Days;

            decimal totalPrice = days * regprice;

            if (days <= 0 || totalPrice < 0)
            {
                MessageBox.Show("Invalid date range or pricing data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookRoom_total.Text = "0.00";
            }
            else
            {
                bookRoom_total.Text = totalPrice.ToString("0.00");
            }
        }

        private void bookRoom_bookBtn_Click(object sender, EventArgs e)
        {
            if (regprice == 0 || bookRoom_total.Text == "0.00")
            {
                MessageBox.Show("Please fill in all info correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bookRoom_status.Text != "Active")
            {
                MessageBox.Show("Room is not available", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hotelData.roomID = bookRoom_roomID.Text;
                hotelData.fromDate = bookRoom_from.Value;
                hotelData.toDate = bookRoom_to.Value;
                hotelData.price = bookRoom_total.Text;

                try
                {
                    using (Form formbg = new Form())
                    {
                        formbg.StartPosition = FormStartPosition.CenterScreen;
                        formbg.Size = new System.Drawing.Size(895, 451);
                        formbg.FormBorderStyle = FormBorderStyle.None;
                        formbg.BackColor = System.Drawing.Color.White;

                        clientInfo clientForm = new clientInfo(_context)
                        {
                            Dock = DockStyle.Fill
                        };

                        formbg.Controls.Add(clientForm);

                        if (formbg.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Booking completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayRooms();
                        }
                        else
                        {
                            MessageBox.Show("Booking was canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
