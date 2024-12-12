using Final.Core.Context;
using Final.Core.Models;
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
    public partial class admin_rooms : UserControl
    {
        private FinalContext _context;

        public admin_rooms()
        {
            InitializeComponent();
        }

        public admin_rooms(FinalContext context)
        {
            InitializeComponent();
            _context = context;
            displayRoomsData();
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
                displayRoomsData();
            }
        }

        public void displayRoomsData()
        {
            if (_context == null)
            {
                MessageBox.Show("Context is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rooms = _context.Rooms.Where(r => r.DateDelete == null).ToList();
            dataGridView1.DataSource = rooms;
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayRoomsData();
        }


        private void rooms_addBtn_Click(object sender, EventArgs e)
        {
            if (_context == null)
            {
                MessageBox.Show("Context is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(rooms_roomID.Text) || string.IsNullOrWhiteSpace(rooms_roomName.Text)
                || rooms_type.SelectedIndex == -1 || string.IsNullOrWhiteSpace(rooms_price.Text)
                || rooms_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingRoom = _context.Rooms
                .FirstOrDefault(r => r.RoomId == rooms_roomID.Text.Trim());

            if (existingRoom != null)
            {
                MessageBox.Show("Room ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(rooms_price.Text.Trim(), out double price))
            {
                MessageBox.Show("Please enter a valid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newRoom = new Rooms
            {
                RoomId = rooms_roomID.Text.Trim(),
                RoomName = rooms_roomName.Text.Trim(),
                Type = rooms_type.SelectedItem.ToString(),
                Price = price,
                Status = rooms_status.SelectedItem.ToString(),
                DateRegister = DateTime.Today,
                ImagePath = rooms_picture.ImageLocation
            };

            _context.Rooms.Add(newRoom);
            _context.SaveChanges();

            clearFields();
            displayRoomsData();

            MessageBox.Show("Room added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        public bool isEmpty()
        {
            return string.IsNullOrEmpty(rooms_roomID.Text) || string.IsNullOrEmpty(rooms_roomName.Text)
                || rooms_type.SelectedIndex == -1 || string.IsNullOrEmpty(rooms_price.Text)
                || rooms_status.SelectedIndex == -1 || rooms_picture.Image == null;
        }

        public void clearFields()
        {
            rooms_roomID.Text = "";
            rooms_roomName.Text = "";
            rooms_type.SelectedIndex = -1;
            rooms_price.Text = "";
            rooms_status.SelectedIndex = -1;
            rooms_picture.Image = null;
        }

        private void rooms_updateBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var roomToUpdate = _context.Rooms
                    .FirstOrDefault(r => r.RoomId == rooms_roomID.Text.Trim());

                if (roomToUpdate != null)
                {
                    roomToUpdate.RoomName = rooms_roomName.Text.Trim();
                    roomToUpdate.Type = rooms_type.SelectedItem.ToString();
                    roomToUpdate.Price = double.Parse(rooms_price.Text.Trim());
                    roomToUpdate.Status = rooms_status.SelectedItem.ToString();
                    roomToUpdate.DateUpdate = DateTime.Today;

                    _context.SaveChanges();

                    displayRoomsData();
                    MessageBox.Show("Room updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rooms_deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rooms_roomID.Text))
            {
                MessageBox.Show("Please select a room first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var roomToDelete = _context.Rooms
                    .FirstOrDefault(r => r.RoomId == rooms_roomID.Text.Trim());

                if (roomToDelete != null)
                {
                    roomToDelete.DateDelete = DateTime.Now;

                    _context.SaveChanges();

                    displayRoomsData();

                    MessageBox.Show("Room marked as deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private int selectedRoomID;

        private void rooms_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.png; *.avif)|*.jpg;*.png; *.avif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    rooms_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rooms_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedRoomID = (int)row.Cells[0].Value;
                rooms_roomID.Text = row.Cells[1].Value.ToString(); 

                rooms_roomName.Text = row.Cells[3].Value.ToString(); 

                string roomType = row.Cells[2].Value.ToString();
                if (rooms_type.Items.Contains(roomType))
                {
                    rooms_type.SelectedItem = roomType;
                }

                string roomStatus = row.Cells[6].Value.ToString();
                if (rooms_status.Items.Contains(roomStatus))
                {
                    rooms_status.SelectedItem = roomStatus; 
                }

                
                rooms_price.Text = row.Cells[4].Value.ToString(); 

                string imagePath = row.Cells[5].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    rooms_picture.ImageLocation = imagePath;
                }
                else
                {
                    rooms_picture.Image = null;
                }
            }
        }


    }
}
