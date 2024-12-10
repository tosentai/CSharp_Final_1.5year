using Final.Core.Context;

namespace Final.UserInterface
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            dashboard_btn = new Button();
            addUser_Btn = new Button();
            rooms_btn = new Button();
            customers_btn = new Button();
            logout_btn = new Button();
            panel2 = new Panel();
            admin_customers1 = new admin_customers();
            admin_rooms1 = new admin_rooms();
            admin_addUser1 = new admin_addUser();
            close = new Label();
            label1 = new Label();
            panel1 = new Panel();
            admin_dashboard1 = new admin_dashboard();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_отель_4_звезды_100;
            pictureBox1.Location = new Point(1121, 7);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(52, 110, 138);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(303, 40);
            dashboard_btn.Margin = new Padding(4, 3, 4, 3);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(194, 40);
            dashboard_btn.TabIndex = 17;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // addUser_Btn
            // 
            addUser_Btn.BackColor = Color.FromArgb(52, 110, 138);
            addUser_Btn.Cursor = Cursors.Hand;
            addUser_Btn.FlatAppearance.BorderSize = 0;
            addUser_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            addUser_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            addUser_Btn.FlatStyle = FlatStyle.Flat;
            addUser_Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addUser_Btn.ForeColor = Color.White;
            addUser_Btn.Location = new Point(504, 40);
            addUser_Btn.Margin = new Padding(4, 3, 4, 3);
            addUser_Btn.Name = "addUser_Btn";
            addUser_Btn.Size = new Size(194, 40);
            addUser_Btn.TabIndex = 17;
            addUser_Btn.Text = "Add User";
            addUser_Btn.UseVisualStyleBackColor = false;
            addUser_Btn.Click += addUser_Btn_Click;
            // 
            // rooms_btn
            // 
            rooms_btn.BackColor = Color.FromArgb(52, 110, 138);
            rooms_btn.Cursor = Cursors.Hand;
            rooms_btn.FlatAppearance.BorderSize = 0;
            rooms_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            rooms_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            rooms_btn.FlatStyle = FlatStyle.Flat;
            rooms_btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rooms_btn.ForeColor = Color.White;
            rooms_btn.Location = new Point(705, 40);
            rooms_btn.Margin = new Padding(4, 3, 4, 3);
            rooms_btn.Name = "rooms_btn";
            rooms_btn.Size = new Size(194, 40);
            rooms_btn.TabIndex = 19;
            rooms_btn.Text = "Rooms";
            rooms_btn.UseVisualStyleBackColor = false;
            rooms_btn.Click += rooms_btn_Click;
            // 
            // customers_btn
            // 
            customers_btn.BackColor = Color.FromArgb(52, 110, 138);
            customers_btn.Cursor = Cursors.Hand;
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            customers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            customers_btn.ForeColor = Color.White;
            customers_btn.Location = new Point(905, 40);
            customers_btn.Margin = new Padding(4, 3, 4, 3);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(194, 40);
            customers_btn.TabIndex = 18;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = false;
            customers_btn.Click += customers_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(52, 110, 138);
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            logout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(54, 40);
            logout_btn.Margin = new Padding(4, 3, 4, 3);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(194, 40);
            logout_btn.TabIndex = 20;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 110, 138);
            panel2.Controls.Add(admin_dashboard1);
            panel2.Controls.Add(admin_customers1);
            panel2.Controls.Add(admin_rooms1);
            panel2.Controls.Add(admin_addUser1);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(rooms_btn);
            panel2.Controls.Add(addUser_Btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1252, 856);
            panel2.TabIndex = 1;
            // 
            // admin_customers1
            // 
            admin_customers1.Location = new Point(0, 118);
            admin_customers1.Margin = new Padding(4, 3, 4, 3);
            admin_customers1.Name = "admin_customers1";
            admin_customers1.Size = new Size(1255, 738);
            admin_customers1.TabIndex = 23;
            // 
            // admin_rooms1
            // 
            admin_rooms1.Location = new Point(0, 118);
            admin_rooms1.Margin = new Padding(4, 3, 4, 3);
            admin_rooms1.Name = "admin_rooms1";
            admin_rooms1.Size = new Size(1252, 738);
            admin_rooms1.TabIndex = 22;
            // 
            // admin_addUser1
            // 
            admin_addUser1.Location = new Point(0, 118);
            admin_addUser1.Margin = new Padding(4, 3, 4, 3);
            admin_addUser1.Name = "admin_addUser1";
            admin_addUser1.Size = new Size(1252, 738);
            admin_addUser1.TabIndex = 21;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            close.ForeColor = Color.White;
            close.Location = new Point(1210, 10);
            close.Margin = new Padding(5, 0, 5, 0);
            close.Name = "close";
            close.Size = new Size(23, 22);
            close.TabIndex = 15;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 22);
            label1.TabIndex = 15;
            label1.Text = "Hotel Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 18);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 68);
            panel1.TabIndex = 0;
            // 
            // admin_dashboard1
            // 
            admin_dashboard1.Location = new Point(0, 118);
            admin_dashboard1.Margin = new Padding(4, 3, 4, 3);
            admin_dashboard1.Name = "admin_dashboard1";
            admin_dashboard1.Size = new Size(1252, 738);
            admin_dashboard1.TabIndex = 24;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 924);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button logout_btn;
        private Button customers_btn;
        private Button rooms_btn;
        private Button addUser_Btn;
        private Button dashboard_btn;
        private PictureBox pictureBox1;
        private Label label1;
        private Label close;
        private Panel panel1;
        private admin_addUser admin_addUser1;
        private admin_rooms admin_rooms1;
        private admin_customers admin_customers1;
        private admin_dashboard admin_dashboard1;
    }
}