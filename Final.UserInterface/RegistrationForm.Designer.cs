namespace Final.UserInterface
{
    partial class RegistrationForm
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
            register_btn = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            register_sgininBtn = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            register_showPass = new CheckBox();
            label7 = new Label();
            register__cpassword = new TextBox();
            close = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(3, 14, 28);
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            register_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(134, 481);
            register_btn.Margin = new Padding(4, 3, 4, 3);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(222, 40);
            register_btn.TabIndex = 5;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_password
            // 
            register_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            register_password.Location = new Point(28, 306);
            register_password.Margin = new Padding(5, 6, 5, 6);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(469, 26);
            register_password.TabIndex = 2;
            // 
            // register_username
            // 
            register_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            register_username.Location = new Point(28, 233);
            register_username.Margin = new Padding(5, 6, 5, 6);
            register_username.Name = "register_username";
            register_username.Size = new Size(469, 26);
            register_username.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(24, 282);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(141, 98);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 7;
            label2.Text = "Registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(24, 209);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 18);
            panel1.Controls.Add(register_sgininBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(524, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 632);
            panel1.TabIndex = 5;
            // 
            // register_sgininBtn
            // 
            register_sgininBtn.BackColor = Color.FromArgb(3, 14, 28);
            register_sgininBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            register_sgininBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            register_sgininBtn.FlatStyle = FlatStyle.Flat;
            register_sgininBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            register_sgininBtn.ForeColor = Color.White;
            register_sgininBtn.Location = new Point(21, 562);
            register_sgininBtn.Margin = new Padding(4, 3, 4, 3);
            register_sgininBtn.Name = "register_sgininBtn";
            register_sgininBtn.Size = new Size(432, 40);
            register_sgininBtn.TabIndex = 6;
            register_sgininBtn.Text = "Sign In";
            register_sgininBtn.UseVisualStyleBackColor = false;
            register_sgininBtn.Click += register_sgininBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_отель_4_звезды_100;
            pictureBox1.Location = new Point(176, 159);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(106, 517);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(220, 24);
            label6.TabIndex = 1;
            label6.Text = "Sign In your Account";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 282);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(364, 32);
            label5.TabIndex = 1;
            label5.Text = "Hotel Management System";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            register_showPass.Location = new Point(28, 430);
            register_showPass.Margin = new Padding(4, 3, 4, 3);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(153, 23);
            register_showPass.TabIndex = 4;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(24, 354);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 16);
            label7.TabIndex = 6;
            label7.Text = "Confirm Password";
            // 
            // register__cpassword
            // 
            register__cpassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            register__cpassword.Location = new Point(28, 391);
            register__cpassword.Margin = new Padding(5, 6, 5, 6);
            register__cpassword.Name = "register__cpassword";
            register__cpassword.PasswordChar = '*';
            register__cpassword.Size = new Size(469, 26);
            register__cpassword.TabIndex = 3;
            // 
            // close
            // 
            close.AutoSize = true;
            close.BackColor = Color.FromArgb(3, 14, 18);
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            close.ForeColor = Color.White;
            close.Location = new Point(961, 10);
            close.Margin = new Padding(5, 0, 5, 0);
            close.Name = "close";
            close.Size = new Size(16, 16);
            close.TabIndex = 14;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(995, 632);
            Controls.Add(close);
            Controls.Add(register_btn);
            Controls.Add(register__cpassword);
            Controls.Add(register_password);
            Controls.Add(label7);
            Controls.Add(register_username);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(register_showPass);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button register_btn;
        private TextBox register_password;
        private TextBox register_username;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button register_sgininBtn;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label close;
        private TextBox register__cpassword;
        private Label label7;
        private CheckBox register_showPass;
    }
}