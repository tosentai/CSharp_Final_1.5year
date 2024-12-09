namespace Final.UserInterface
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            login_registerBtn = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            close = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            label4 = new Label();
            login_password = new TextBox();
            login_btn = new Button();
            login_showPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 18);
            panel1.Controls.Add(login_registerBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 548);
            panel1.TabIndex = 0;
            // 
            // login_registerBtn
            // 
            login_registerBtn.BackColor = Color.FromArgb(3, 14, 28);
            login_registerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            login_registerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            login_registerBtn.FlatStyle = FlatStyle.Flat;
            login_registerBtn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            login_registerBtn.ForeColor = Color.White;
            login_registerBtn.Location = new Point(30, 483);
            login_registerBtn.Name = "login_registerBtn";
            login_registerBtn.Size = new Size(358, 35);
            login_registerBtn.TabIndex = 4;
            login_registerBtn.Text = "Register";
            login_registerBtn.UseVisualStyleBackColor = false;
            login_registerBtn.Click += login_registerBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_отель_4_звезды_100;
            pictureBox1.Location = new Point(146, 97);
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
            label6.Location = new Point(103, 441);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(210, 24);
            label6.TabIndex = 1;
            label6.Text = "Create new account";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 207);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(364, 32);
            label5.TabIndex = 1;
            label5.Text = "Hotel Management System";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            close.Location = new Point(824, 9);
            close.Margin = new Padding(4, 0, 4, 0);
            close.Name = "close";
            close.Size = new Size(16, 16);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(478, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(282, 32);
            label2.TabIndex = 1;
            label2.Text = "Welcome back, User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(424, 186);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // login_username
            // 
            login_username.Location = new Point(427, 207);
            login_username.Margin = new Padding(4, 5, 4, 5);
            login_username.Name = "login_username";
            login_username.Size = new Size(403, 26);
            login_username.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(424, 253);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // login_password
            // 
            login_password.Location = new Point(427, 274);
            login_password.Margin = new Padding(4, 5, 4, 5);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(403, 26);
            login_password.TabIndex = 2;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(3, 14, 28);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(540, 361);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(190, 35);
            login_btn.TabIndex = 3;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            login_showPass.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            login_showPass.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            login_showPass.Location = new Point(427, 318);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(153, 23);
            login_showPass.TabIndex = 4;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 548);
            Controls.Add(login_showPass);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(close);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button login_registerBtn;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private CheckBox login_showPass;
        private Button login_btn;
        private TextBox login_password;
        private TextBox login_username;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label close;
    }
}
