namespace Final.UserInterface
{
    partial class admin_rooms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            rooms_ClearBtn = new Button();
            rooms_deleteBtn = new Button();
            rooms_updateBtn = new Button();
            rooms_addBtn = new Button();
            rooms_importBtn = new Button();
            panel3 = new Panel();
            rooms_picture = new PictureBox();
            rooms_status = new ComboBox();
            label6 = new Label();
            rooms_price = new TextBox();
            label4 = new Label();
            rooms_roomName = new TextBox();
            label3 = new Label();
            rooms_type = new ComboBox();
            rooms_roomID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rooms_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rooms_ClearBtn);
            panel2.Controls.Add(rooms_deleteBtn);
            panel2.Controls.Add(rooms_updateBtn);
            panel2.Controls.Add(rooms_addBtn);
            panel2.Controls.Add(rooms_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(rooms_status);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(rooms_price);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(rooms_roomName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rooms_type);
            panel2.Controls.Add(rooms_roomID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(20, 455);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1211, 268);
            panel2.TabIndex = 1;
            // 
            // rooms_ClearBtn
            // 
            rooms_ClearBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_ClearBtn.FlatAppearance.BorderSize = 0;
            rooms_ClearBtn.FlatStyle = FlatStyle.Flat;
            rooms_ClearBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rooms_ClearBtn.ForeColor = Color.White;
            rooms_ClearBtn.Location = new Point(897, 193);
            rooms_ClearBtn.Margin = new Padding(4, 3, 4, 3);
            rooms_ClearBtn.Name = "rooms_ClearBtn";
            rooms_ClearBtn.Size = new Size(271, 47);
            rooms_ClearBtn.TabIndex = 20;
            rooms_ClearBtn.Text = "Clear";
            rooms_ClearBtn.UseVisualStyleBackColor = false;
            rooms_ClearBtn.Click += rooms_ClearBtn_Click;
            // 
            // rooms_deleteBtn
            // 
            rooms_deleteBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            rooms_deleteBtn.FlatStyle = FlatStyle.Flat;
            rooms_deleteBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rooms_deleteBtn.ForeColor = Color.White;
            rooms_deleteBtn.Location = new Point(897, 138);
            rooms_deleteBtn.Margin = new Padding(4, 3, 4, 3);
            rooms_deleteBtn.Name = "rooms_deleteBtn";
            rooms_deleteBtn.Size = new Size(271, 47);
            rooms_deleteBtn.TabIndex = 19;
            rooms_deleteBtn.Text = "Delete";
            rooms_deleteBtn.UseVisualStyleBackColor = false;
            rooms_deleteBtn.Click += rooms_deleteBtn_Click;
            // 
            // rooms_updateBtn
            // 
            rooms_updateBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_updateBtn.FlatAppearance.BorderSize = 0;
            rooms_updateBtn.FlatStyle = FlatStyle.Flat;
            rooms_updateBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rooms_updateBtn.ForeColor = Color.White;
            rooms_updateBtn.Location = new Point(897, 84);
            rooms_updateBtn.Margin = new Padding(4, 3, 4, 3);
            rooms_updateBtn.Name = "rooms_updateBtn";
            rooms_updateBtn.Size = new Size(271, 47);
            rooms_updateBtn.TabIndex = 18;
            rooms_updateBtn.Text = "Update";
            rooms_updateBtn.UseVisualStyleBackColor = false;
            rooms_updateBtn.Click += rooms_updateBtn_Click;
            // 
            // rooms_addBtn
            // 
            rooms_addBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_addBtn.FlatAppearance.BorderSize = 0;
            rooms_addBtn.FlatStyle = FlatStyle.Flat;
            rooms_addBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rooms_addBtn.ForeColor = Color.White;
            rooms_addBtn.Location = new Point(897, 30);
            rooms_addBtn.Margin = new Padding(4, 3, 4, 3);
            rooms_addBtn.Name = "rooms_addBtn";
            rooms_addBtn.Size = new Size(271, 47);
            rooms_addBtn.TabIndex = 17;
            rooms_addBtn.Text = "Add";
            rooms_addBtn.UseVisualStyleBackColor = false;
            rooms_addBtn.Click += rooms_addBtn_Click;
            // 
            // rooms_importBtn
            // 
            rooms_importBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_importBtn.FlatAppearance.BorderSize = 0;
            rooms_importBtn.FlatStyle = FlatStyle.Flat;
            rooms_importBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rooms_importBtn.ForeColor = Color.White;
            rooms_importBtn.Location = new Point(639, 209);
            rooms_importBtn.Margin = new Padding(4, 3, 4, 3);
            rooms_importBtn.Name = "rooms_importBtn";
            rooms_importBtn.Size = new Size(187, 43);
            rooms_importBtn.TabIndex = 16;
            rooms_importBtn.Text = "Import";
            rooms_importBtn.UseVisualStyleBackColor = false;
            rooms_importBtn.Click += rooms_importBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(rooms_picture);
            panel3.Location = new Point(639, 17);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 185);
            panel3.TabIndex = 15;
            // 
            // rooms_picture
            // 
            rooms_picture.Location = new Point(0, 0);
            rooms_picture.Margin = new Padding(4, 3, 4, 3);
            rooms_picture.Name = "rooms_picture";
            rooms_picture.Size = new Size(187, 185);
            rooms_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            rooms_picture.TabIndex = 0;
            rooms_picture.TabStop = false;
            // 
            // rooms_status
            // 
            rooms_status.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rooms_status.FormattingEnabled = true;
            rooms_status.Items.AddRange(new object[] { "Active", "Inactive", "Occupied" });
            rooms_status.Location = new Point(449, 108);
            rooms_status.Margin = new Padding(4, 3, 4, 3);
            rooms_status.Name = "rooms_status";
            rooms_status.Size = new Size(140, 26);
            rooms_status.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(376, 113);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 18);
            label6.TabIndex = 13;
            label6.Text = "Status:";
            label6.UseWaitCursor = true;
            // 
            // rooms_price
            // 
            rooms_price.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rooms_price.Location = new Point(450, 63);
            rooms_price.Margin = new Padding(4, 3, 4, 3);
            rooms_price.Name = "rooms_price";
            rooms_price.Size = new Size(140, 26);
            rooms_price.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(359, 69);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 11;
            label4.Text = "Price ($):";
            // 
            // rooms_roomName
            // 
            rooms_roomName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rooms_roomName.Location = new Point(142, 151);
            rooms_roomName.Margin = new Padding(4, 3, 4, 3);
            rooms_roomName.Name = "rooms_roomName";
            rooms_roomName.Size = new Size(140, 26);
            rooms_roomName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(22, 157);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 18);
            label3.TabIndex = 9;
            label3.Text = "Room Name:";
            // 
            // rooms_type
            // 
            rooms_type.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rooms_type.FormattingEnabled = true;
            rooms_type.Items.AddRange(new object[] { "Single Room", "Double Room" });
            rooms_type.Location = new Point(142, 108);
            rooms_type.Margin = new Padding(4, 3, 4, 3);
            rooms_type.Name = "rooms_type";
            rooms_type.Size = new Size(140, 26);
            rooms_type.TabIndex = 8;
            // 
            // rooms_roomID
            // 
            rooms_roomID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rooms_roomID.Location = new Point(142, 63);
            rooms_roomID.Margin = new Padding(4, 3, 4, 3);
            rooms_roomID.Name = "rooms_roomID";
            rooms_roomID.Size = new Size(140, 26);
            rooms_roomID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(82, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 6;
            label2.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(51, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 6;
            label1.Text = "Room ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(15, 62);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(1178, 332);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(10, 16);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 19);
            label5.TabIndex = 5;
            label5.Text = "Room's Data";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(20, 17);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 414);
            panel1.TabIndex = 0;
            // 
            // admin_rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "admin_rooms";
            Size = new Size(1252, 738);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rooms_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private DataGridView dataGridView1;
        private Button rooms_ClearBtn;
        private Button rooms_deleteBtn;
        private Button rooms_updateBtn;
        private Button rooms_addBtn;
        private Button rooms_importBtn;
        private Panel panel3;
        private PictureBox rooms_picture;
        private ComboBox rooms_status;
        private Label label6;
        private TextBox rooms_price;
        private Label label4;
        private TextBox rooms_roomName;
        private Label label3;
        private ComboBox rooms_type;
        private TextBox rooms_roomID;
        private Label label2;
        private Label label1;
        private Panel panel2;
    }
}
