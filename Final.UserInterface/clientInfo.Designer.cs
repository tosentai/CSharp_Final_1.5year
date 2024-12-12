namespace Final.UserInterface
{
    partial class clientInfo
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
            panel1 = new Panel();
            close = new Label();
            panel7 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            client_clearBtn = new Button();
            client_bookBtn = new Button();
            client_gender = new ComboBox();
            client_address = new TextBox();
            client_contact = new TextBox();
            client_email = new TextBox();
            client_fullName = new TextBox();
            label7 = new Label();
            client_bookID = new Label();
            label9 = new Label();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 18);
            panel1.Controls.Add(close);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 68);
            panel1.TabIndex = 6;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            close.ForeColor = Color.White;
            close.Location = new Point(854, 10);
            close.Margin = new Padding(5, 0, 5, 0);
            close.Name = "close";
            close.Size = new Size(23, 22);
            close.TabIndex = 16;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(230, 68);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(1255, 738);
            panel7.TabIndex = 8;
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
            label1.Size = new Size(119, 22);
            label1.TabIndex = 15;
            label1.Text = "Client's Info";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(client_clearBtn);
            panel2.Controls.Add(client_bookBtn);
            panel2.Controls.Add(client_gender);
            panel2.Controls.Add(client_address);
            panel2.Controls.Add(client_contact);
            panel2.Controls.Add(client_email);
            panel2.Controls.Add(client_fullName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(client_bookID);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(20, 87);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 346);
            panel2.TabIndex = 7;
            // 
            // client_clearBtn
            // 
            client_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            client_clearBtn.FlatAppearance.BorderSize = 0;
            client_clearBtn.FlatStyle = FlatStyle.Flat;
            client_clearBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            client_clearBtn.ForeColor = Color.White;
            client_clearBtn.Location = new Point(481, 261);
            client_clearBtn.Margin = new Padding(4, 3, 4, 3);
            client_clearBtn.Name = "client_clearBtn";
            client_clearBtn.Size = new Size(259, 60);
            client_clearBtn.TabIndex = 19;
            client_clearBtn.Text = "Clear";
            client_clearBtn.UseVisualStyleBackColor = false;
            client_clearBtn.Click += client_clearBtn_Click;
            // 
            // client_bookBtn
            // 
            client_bookBtn.BackColor = Color.FromArgb(3, 14, 28);
            client_bookBtn.FlatAppearance.BorderSize = 0;
            client_bookBtn.FlatStyle = FlatStyle.Flat;
            client_bookBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            client_bookBtn.ForeColor = Color.White;
            client_bookBtn.Location = new Point(124, 261);
            client_bookBtn.Margin = new Padding(4, 3, 4, 3);
            client_bookBtn.Name = "client_bookBtn";
            client_bookBtn.Size = new Size(259, 60);
            client_bookBtn.TabIndex = 19;
            client_bookBtn.Text = "Book Now";
            client_bookBtn.UseVisualStyleBackColor = false;
            client_bookBtn.Click += client_bookBtn_Click;
            // 
            // client_gender
            // 
            client_gender.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            client_gender.FormattingEnabled = true;
            client_gender.Items.AddRange(new object[] { "Male", "Female" });
            client_gender.Location = new Point(604, 72);
            client_gender.Margin = new Padding(4, 3, 4, 3);
            client_gender.Name = "client_gender";
            client_gender.Size = new Size(230, 24);
            client_gender.TabIndex = 3;
            // 
            // client_address
            // 
            client_address.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            client_address.Location = new Point(604, 129);
            client_address.Margin = new Padding(4, 3, 4, 3);
            client_address.Multiline = true;
            client_address.Name = "client_address";
            client_address.Size = new Size(230, 81);
            client_address.TabIndex = 2;
            // 
            // client_contact
            // 
            client_contact.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            client_contact.Location = new Point(169, 186);
            client_contact.Margin = new Padding(4, 3, 4, 3);
            client_contact.Name = "client_contact";
            client_contact.Size = new Size(258, 22);
            client_contact.TabIndex = 2;
            // 
            // client_email
            // 
            client_email.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            client_email.Location = new Point(169, 126);
            client_email.Margin = new Padding(4, 3, 4, 3);
            client_email.Name = "client_email";
            client_email.Size = new Size(258, 22);
            client_email.TabIndex = 2;
            // 
            // client_fullName
            // 
            client_fullName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            client_fullName.Location = new Point(169, 72);
            client_fullName.Margin = new Padding(4, 3, 4, 3);
            client_fullName.Name = "client_fullName";
            client_fullName.Size = new Size(258, 22);
            client_fullName.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(21, 189);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 16);
            label7.TabIndex = 0;
            label7.Text = "Contact Number:";
            // 
            // client_bookID
            // 
            client_bookID.AutoSize = true;
            client_bookID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            client_bookID.Location = new Point(166, 30);
            client_bookID.Margin = new Padding(4, 0, 4, 0);
            client_bookID.Name = "client_bookID";
            client_bookID.Size = new Size(66, 16);
            client_bookID.TabIndex = 1;
            client_bookID.Text = "Book ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(517, 129);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 16);
            label9.TabIndex = 0;
            label9.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(42, 129);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 16);
            label6.TabIndex = 0;
            label6.Text = "Email Adress:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(68, 75);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 16);
            label8.TabIndex = 0;
            label8.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(525, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 16);
            label5.TabIndex = 0;
            label5.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(85, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 16);
            label3.TabIndex = 0;
            label3.Text = "Book ID:";
            // 
            // clientInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "clientInfo";
            Size = new Size(895, 451);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button client_clearBtn;
        private Button client_bookBtn;
        private ComboBox client_gender;
        private TextBox client_address;
        private TextBox client_contact;
        private TextBox client_email;
        private TextBox client_fullName;
        private Label label7;
        private Label client_bookID;
        private Label label9;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label close;
        private Panel panel7;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
    }
}
