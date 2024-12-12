using Final.Core.Context;
using Final.Core.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.UserInterface
{
    public partial class clientInfo : UserControl
    {
        private readonly FinalContext _context;

        public clientInfo(FinalContext context)
        {
            InitializeComponent();
            _context = context;
            DisplayBookID();
        }

        private void close_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent as Form;
            if (parentForm != null)
            {
                parentForm.DialogResult = DialogResult.Cancel;
                parentForm.Close();
            }
        }

        public void DisplayBookID()
        {
            int getBookID = _context.Customers.Count() + 1;
            client_bookID.Text = $"BID - {getBookID}";
        }

        private void client_bookBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to book now?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(client_fullName.Text) ||
                    client_gender.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(client_address.Text) ||
                    string.IsNullOrWhiteSpace(client_email.Text) ||
                    string.IsNullOrWhiteSpace(client_contact.Text) ||
                    string.IsNullOrWhiteSpace(hotelData.roomID))
                {
                    MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    var newCustomer = new Customers
                    {
                        BookId = client_bookID.Text,
                        FullName = client_fullName.Text,
                        Email = client_email.Text,
                        Contact = client_contact.Text,
                        Gender = client_gender.SelectedItem.ToString(),
                        Address = client_address.Text,
                        RoomID = hotelData.roomID,
                        Price = decimal.Parse(hotelData.price),
                        StatusPayment = "Paid",
                        Status = "Checked In",
                        DateFrom = hotelData.fromDate,
                        DateTo = hotelData.toDate,
                        DateBook = DateTime.Today
                    };

                    _context.Customers.Add(newCustomer);
                    var room = _context.Rooms.FirstOrDefault(r => r.RoomId == hotelData.roomID);
                    if (room != null)
                    {
                        room.Status = "Unavailable";
                    }

                    _context.SaveChanges();

                    var notificationService = new BookingNotificationService(_context);
                    notificationService.SendBookingNotification(newCustomer.Id);

                    MessageBox.Show("Room Booked and SMS Notification Sent", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var parentForm = this.Parent as Form;
                    if (parentForm != null)
                    {
                        parentForm.DialogResult = DialogResult.OK;
                        parentForm.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateRoomStatus(string roomID)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.RoomId == roomID);

            if (room != null)
            {
                room.Status = "Unavailable";
                _context.SaveChanges();
            }
        }

        private void client_clearBtn_Click(object sender, EventArgs e)
        {
            client_fullName.Text = "";
            client_email.Text = "";
            client_contact.Text = "";
            client_address.Text = "";
            client_gender.SelectedIndex = -1;
        }
    }
}
