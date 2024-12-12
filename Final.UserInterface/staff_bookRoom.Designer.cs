namespace Final.UserInterface
{
    partial class staff_bookRoom
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel4 = new Panel();
            panel6 = new Panel();
            bookRoom_imageView = new PictureBox();
            panel5 = new Panel();
            bookRoom_to = new DateTimePicker();
            bookRoom_from = new DateTimePicker();
            bookRoom_scheduleBtn = new Button();
            bookRoom_bookBtn = new Button();
            bookRoom_clearBtn = new Button();
            bookRoom_total = new Label();
            label14 = new Label();
            label13 = new Label();
            bookRoom_regPrice = new Label();
            bookRoom_status = new Label();
            label12 = new Label();
            label1 = new Label();
            label9 = new Label();
            bookRoom_roomName = new Label();
            label11 = new Label();
            bookRoom_roomType = new Label();
            label7 = new Label();
            bookRoom_roomID = new Label();
            label3 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookRoom_imageView).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(19, 449);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(752, 267);
            panel4.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(bookRoom_imageView);
            panel6.Location = new Point(13, 14);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(722, 240);
            panel6.TabIndex = 0;
            // 
            // bookRoom_imageView
            // 
            bookRoom_imageView.Location = new Point(0, 0);
            bookRoom_imageView.Margin = new Padding(4, 3, 4, 3);
            bookRoom_imageView.Name = "bookRoom_imageView";
            bookRoom_imageView.Size = new Size(722, 240);
            bookRoom_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            bookRoom_imageView.TabIndex = 0;
            bookRoom_imageView.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(bookRoom_to);
            panel5.Controls.Add(bookRoom_from);
            panel5.Controls.Add(bookRoom_scheduleBtn);
            panel5.Controls.Add(bookRoom_bookBtn);
            panel5.Controls.Add(bookRoom_clearBtn);
            panel5.Controls.Add(bookRoom_total);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(bookRoom_regPrice);
            panel5.Controls.Add(bookRoom_status);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(bookRoom_roomName);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(bookRoom_roomType);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(bookRoom_roomID);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(796, 24);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(441, 691);
            panel5.TabIndex = 9;
            // 
            // bookRoom_to
            // 
            bookRoom_to.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_to.Location = new Point(183, 305);
            bookRoom_to.Margin = new Padding(4, 3, 4, 3);
            bookRoom_to.Name = "bookRoom_to";
            bookRoom_to.Size = new Size(233, 23);
            bookRoom_to.TabIndex = 19;
            // 
            // bookRoom_from
            // 
            bookRoom_from.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_from.Location = new Point(183, 262);
            bookRoom_from.Margin = new Padding(4, 3, 4, 3);
            bookRoom_from.Name = "bookRoom_from";
            bookRoom_from.Size = new Size(233, 23);
            bookRoom_from.TabIndex = 19;
            // 
            // bookRoom_scheduleBtn
            // 
            bookRoom_scheduleBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookRoom_scheduleBtn.FlatAppearance.BorderSize = 0;
            bookRoom_scheduleBtn.FlatStyle = FlatStyle.Flat;
            bookRoom_scheduleBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_scheduleBtn.ForeColor = Color.White;
            bookRoom_scheduleBtn.Location = new Point(27, 346);
            bookRoom_scheduleBtn.Margin = new Padding(4, 3, 4, 3);
            bookRoom_scheduleBtn.Name = "bookRoom_scheduleBtn";
            bookRoom_scheduleBtn.Size = new Size(390, 60);
            bookRoom_scheduleBtn.TabIndex = 18;
            bookRoom_scheduleBtn.Text = "Schedule Now";
            bookRoom_scheduleBtn.UseVisualStyleBackColor = false;
            bookRoom_scheduleBtn.Click += bookRoom_scheduleBtn_Click;
            // 
            // bookRoom_bookBtn
            // 
            bookRoom_bookBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookRoom_bookBtn.FlatAppearance.BorderSize = 0;
            bookRoom_bookBtn.FlatStyle = FlatStyle.Flat;
            bookRoom_bookBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_bookBtn.ForeColor = Color.White;
            bookRoom_bookBtn.Location = new Point(27, 509);
            bookRoom_bookBtn.Margin = new Padding(4, 3, 4, 3);
            bookRoom_bookBtn.Name = "bookRoom_bookBtn";
            bookRoom_bookBtn.Size = new Size(390, 60);
            bookRoom_bookBtn.TabIndex = 18;
            bookRoom_bookBtn.Text = "Book";
            bookRoom_bookBtn.UseVisualStyleBackColor = false;
            bookRoom_bookBtn.Click += bookRoom_bookBtn_Click;
            // 
            // bookRoom_clearBtn
            // 
            bookRoom_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookRoom_clearBtn.FlatAppearance.BorderSize = 0;
            bookRoom_clearBtn.FlatStyle = FlatStyle.Flat;
            bookRoom_clearBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_clearBtn.ForeColor = Color.White;
            bookRoom_clearBtn.Location = new Point(27, 591);
            bookRoom_clearBtn.Margin = new Padding(4, 3, 4, 3);
            bookRoom_clearBtn.Name = "bookRoom_clearBtn";
            bookRoom_clearBtn.Size = new Size(390, 60);
            bookRoom_clearBtn.TabIndex = 18;
            bookRoom_clearBtn.Text = "Clear";
            bookRoom_clearBtn.UseVisualStyleBackColor = false;
            // 
            // bookRoom_total
            // 
            bookRoom_total.AutoSize = true;
            bookRoom_total.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_total.Location = new Point(253, 423);
            bookRoom_total.Margin = new Padding(4, 0, 4, 0);
            bookRoom_total.Name = "bookRoom_total";
            bookRoom_total.Size = new Size(49, 24);
            bookRoom_total.TabIndex = 7;
            bookRoom_total.Text = "0.00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(62, 423);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(147, 24);
            label14.TabIndex = 6;
            label14.Text = "Total Price ($):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(55, 309);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(99, 16);
            label13.TabIndex = 6;
            label13.Text = "To Schedule:";
            // 
            // bookRoom_regPrice
            // 
            bookRoom_regPrice.AutoSize = true;
            bookRoom_regPrice.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_regPrice.Location = new Point(254, 209);
            bookRoom_regPrice.Margin = new Padding(4, 0, 4, 0);
            bookRoom_regPrice.Name = "bookRoom_regPrice";
            bookRoom_regPrice.Size = new Size(35, 16);
            bookRoom_regPrice.TabIndex = 7;
            bookRoom_regPrice.Text = "0.00";
            // 
            // bookRoom_status
            // 
            bookRoom_status.AutoSize = true;
            bookRoom_status.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_status.Location = new Point(254, 165);
            bookRoom_status.Margin = new Padding(4, 0, 4, 0);
            bookRoom_status.Name = "bookRoom_status";
            bookRoom_status.Size = new Size(72, 16);
            bookRoom_status.TabIndex = 7;
            bookRoom_status.Text = "-------------";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(38, 262);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(115, 16);
            label12.TabIndex = 6;
            label12.Text = "From Schedule:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(98, 209);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 16);
            label1.TabIndex = 6;
            label1.Text = "Regular Price ($):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(184, 165);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 16);
            label9.TabIndex = 6;
            label9.Text = "Status:";
            // 
            // bookRoom_roomName
            // 
            bookRoom_roomName.AutoSize = true;
            bookRoom_roomName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_roomName.Location = new Point(254, 117);
            bookRoom_roomName.Margin = new Padding(4, 0, 4, 0);
            bookRoom_roomName.Name = "bookRoom_roomName";
            bookRoom_roomName.Size = new Size(72, 16);
            bookRoom_roomName.TabIndex = 5;
            bookRoom_roomName.Text = "-------------";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(134, 117);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(97, 16);
            label11.TabIndex = 4;
            label11.Text = "Room Name:";
            // 
            // bookRoom_roomType
            // 
            bookRoom_roomType.AutoSize = true;
            bookRoom_roomType.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_roomType.Location = new Point(254, 60);
            bookRoom_roomType.Margin = new Padding(4, 0, 4, 0);
            bookRoom_roomType.Name = "bookRoom_roomType";
            bookRoom_roomType.Size = new Size(72, 16);
            bookRoom_roomType.TabIndex = 3;
            bookRoom_roomType.Text = "-------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(140, 60);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 16);
            label7.TabIndex = 2;
            label7.Text = "Room Type:";
            // 
            // bookRoom_roomID
            // 
            bookRoom_roomID.AutoSize = true;
            bookRoom_roomID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bookRoom_roomID.Location = new Point(254, 12);
            bookRoom_roomID.Margin = new Padding(4, 0, 4, 0);
            bookRoom_roomID.Name = "bookRoom_roomID";
            bookRoom_roomID.Size = new Size(72, 16);
            bookRoom_roomID.TabIndex = 1;
            bookRoom_roomID.Text = "-------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(150, 12);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 0;
            label3.Text = "Room ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(19, 24);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(752, 406);
            panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 33);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(722, 354);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(8, 8);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 19);
            label5.TabIndex = 16;
            label5.Text = "Available Rooms";
            // 
            // staff_bookRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Margin = new Padding(4, 3, 4, 3);
            Name = "staff_bookRoom";
            Size = new Size(1255, 738);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookRoom_imageView).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DateTimePicker bookRoom_to;
        private DateTimePicker bookRoom_from;
        private Button bookRoom_scheduleBtn;
        private Button bookRoom_bookBtn;
        private Button bookRoom_clearBtn;
        private Label bookRoom_total;
        private Label label14;
        private Label label13;
        private Label bookRoom_regPrice;
        private PictureBox bookRoom_imageView;
        private Label bookRoom_status;
        private Label label12;
        private Label label1;
        private Label label9;
        private Label bookRoom_roomName;
        private Label label11;
        private Label bookRoom_roomType;
        private Label label7;
        private Label bookRoom_roomID;
        private Label label3;
        private Panel panel6;
        private Panel panel4;
        private Panel panel5;
    }
}
