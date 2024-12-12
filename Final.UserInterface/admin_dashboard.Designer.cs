namespace Final.UserInterface
{
    partial class admin_dashboard
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
            totalStaff = new Label();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            AvailableRooms = new Label();
            label4 = new Label();
            profitToday = new Label();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            panel8 = new Panel();
            pictureBox3 = new PictureBox();
            totalProfit = new Label();
            label8 = new Label();
            panel9 = new Panel();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            admin_dashboard_GenUserRep = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            admin_dashboard_GenRoomRep = new Button();
            admin_dashboard_GenCustomerRep = new Button();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // totalStaff
            // 
            totalStaff.AutoSize = true;
            totalStaff.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            totalStaff.ForeColor = Color.White;
            totalStaff.Location = new Point(131, 23);
            totalStaff.Margin = new Padding(4, 0, 4, 0);
            totalStaff.Name = "totalStaff";
            totalStaff.Size = new Size(21, 22);
            totalStaff.TabIndex = 1;
            totalStaff.Text = "0";
            totalStaff.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 110, 138);
            panel6.Controls.Add(totalStaff);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(16, 16);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(276, 182);
            panel6.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 1;
            label1.Text = "Total Staff";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_группа_пользователей_100;
            pictureBox1.Location = new Point(7, 23);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AvailableRooms
            // 
            AvailableRooms.AutoSize = true;
            AvailableRooms.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AvailableRooms.ForeColor = Color.White;
            AvailableRooms.Location = new Point(127, 23);
            AvailableRooms.Margin = new Padding(4, 0, 4, 0);
            AvailableRooms.Name = "AvailableRooms";
            AvailableRooms.Size = new Size(21, 22);
            AvailableRooms.TabIndex = 2;
            AvailableRooms.Text = "0";
            AvailableRooms.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 142);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 22);
            label4.TabIndex = 3;
            label4.Text = "Available Rooms";
            // 
            // profitToday
            // 
            profitToday.AutoSize = true;
            profitToday.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            profitToday.ForeColor = Color.White;
            profitToday.Location = new Point(127, 23);
            profitToday.Margin = new Padding(4, 0, 4, 0);
            profitToday.Name = "profitToday";
            profitToday.Size = new Size(59, 22);
            profitToday.TabIndex = 4;
            profitToday.Text = "$0.00";
            profitToday.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 110, 138);
            panel7.Controls.Add(AvailableRooms);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(315, 16);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(276, 182);
            panel7.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_rooms_100;
            pictureBox2.Location = new Point(4, 23);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(4, 142);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 22);
            label6.TabIndex = 5;
            label6.Text = "Today's Profit";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(52, 110, 138);
            panel8.Controls.Add(profitToday);
            panel8.Controls.Add(pictureBox3);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(616, 16);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(276, 182);
            panel8.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_мужчина_с_мешками_денег_100;
            pictureBox3.Location = new Point(4, 23);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // totalProfit
            // 
            totalProfit.AutoSize = true;
            totalProfit.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            totalProfit.ForeColor = Color.White;
            totalProfit.Location = new Point(127, 23);
            totalProfit.Margin = new Padding(4, 0, 4, 0);
            totalProfit.Name = "totalProfit";
            totalProfit.Size = new Size(59, 22);
            totalProfit.TabIndex = 6;
            totalProfit.Text = "$0.00";
            totalProfit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.White;
            label8.Location = new Point(4, 142);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 22);
            label8.TabIndex = 7;
            label8.Text = "Total Income";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(52, 110, 138);
            panel9.Controls.Add(totalProfit);
            panel9.Controls.Add(pictureBox4);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(918, 16);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(276, 182);
            panel9.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_сумка_денег_100;
            pictureBox4.Location = new Point(4, 23);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(admin_dashboard_GenCustomerRep);
            panel5.Controls.Add(admin_dashboard_GenRoomRep);
            panel5.Controls.Add(admin_dashboard_GenUserRep);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(18, 243);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1216, 478);
            panel5.TabIndex = 9;
            // 
            // admin_dashboard_GenUserRep
            // 
            admin_dashboard_GenUserRep.BackColor = Color.FromArgb(3, 14, 28);
            admin_dashboard_GenUserRep.FlatAppearance.BorderSize = 0;
            admin_dashboard_GenUserRep.FlatStyle = FlatStyle.Flat;
            admin_dashboard_GenUserRep.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            admin_dashboard_GenUserRep.ForeColor = Color.White;
            admin_dashboard_GenUserRep.Location = new Point(16, 416);
            admin_dashboard_GenUserRep.Margin = new Padding(4, 3, 4, 3);
            admin_dashboard_GenUserRep.Name = "admin_dashboard_GenUserRep";
            admin_dashboard_GenUserRep.Size = new Size(271, 47);
            admin_dashboard_GenUserRep.TabIndex = 10;
            admin_dashboard_GenUserRep.Text = "Generate User Report";
            admin_dashboard_GenUserRep.UseVisualStyleBackColor = false;
            admin_dashboard_GenUserRep.Click += admin_dashboard_GenUserRep_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 13);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 20;
            label5.Text = "All Rooms";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 38);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1178, 361);
            dataGridView1.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(18, 18);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1216, 218);
            panel4.TabIndex = 8;
            // 
            // admin_dashboard_GenRoomRep
            // 
            admin_dashboard_GenRoomRep.BackColor = Color.FromArgb(3, 14, 28);
            admin_dashboard_GenRoomRep.FlatAppearance.BorderSize = 0;
            admin_dashboard_GenRoomRep.FlatStyle = FlatStyle.Flat;
            admin_dashboard_GenRoomRep.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            admin_dashboard_GenRoomRep.ForeColor = Color.White;
            admin_dashboard_GenRoomRep.Location = new Point(488, 416);
            admin_dashboard_GenRoomRep.Margin = new Padding(4, 3, 4, 3);
            admin_dashboard_GenRoomRep.Name = "admin_dashboard_GenRoomRep";
            admin_dashboard_GenRoomRep.Size = new Size(271, 47);
            admin_dashboard_GenRoomRep.TabIndex = 10;
            admin_dashboard_GenRoomRep.Text = "Generate Room Report";
            admin_dashboard_GenRoomRep.UseVisualStyleBackColor = false;
            admin_dashboard_GenRoomRep.Click += admin_dashboard_GenRoomRep_Click;
            // 
            // admin_dashboard_GenCustomerRep
            // 
            admin_dashboard_GenCustomerRep.BackColor = Color.FromArgb(3, 14, 28);
            admin_dashboard_GenCustomerRep.FlatAppearance.BorderSize = 0;
            admin_dashboard_GenCustomerRep.FlatStyle = FlatStyle.Flat;
            admin_dashboard_GenCustomerRep.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            admin_dashboard_GenCustomerRep.ForeColor = Color.White;
            admin_dashboard_GenCustomerRep.Location = new Point(923, 416);
            admin_dashboard_GenCustomerRep.Margin = new Padding(4, 3, 4, 3);
            admin_dashboard_GenCustomerRep.Name = "admin_dashboard_GenCustomerRep";
            admin_dashboard_GenCustomerRep.Size = new Size(271, 47);
            admin_dashboard_GenCustomerRep.TabIndex = 10;
            admin_dashboard_GenCustomerRep.Text = "Generate Customer Report";
            admin_dashboard_GenCustomerRep.UseVisualStyleBackColor = false;
            admin_dashboard_GenCustomerRep.Click += admin_dashboard_GenCustomerRep_Click;
            // 
            // admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Margin = new Padding(4, 3, 4, 3);
            Name = "admin_dashboard";
            Size = new Size(1252, 738);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel9;
        private Label totalProfit;
        private PictureBox pictureBox4;
        private Label label8;
        private Panel panel8;
        private Label profitToday;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel7;
        private Label AvailableRooms;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel6;
        private Label totalStaff;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Button admin_dashboard_GenUserRep;
        private Button admin_dashboard_GenCustomerRep;
        private Button admin_dashboard_GenRoomRep;
    }
}
