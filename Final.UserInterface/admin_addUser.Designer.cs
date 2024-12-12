namespace Final.UserInterface
{
    partial class admin_addUser
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
            panel1 = new Panel();
            addUser_clearBtn = new Button();
            addUser_deleteBtn = new Button();
            addUser_updateBtn = new Button();
            addUser_addBtn = new Button();
            addUser_status = new ComboBox();
            label4 = new Label();
            addUser_role = new ComboBox();
            label3 = new Label();
            addUser_password = new TextBox();
            label2 = new Label();
            addUser_username = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addUser_clearBtn);
            panel1.Controls.Add(addUser_deleteBtn);
            panel1.Controls.Add(addUser_updateBtn);
            panel1.Controls.Add(addUser_addBtn);
            panel1.Controls.Add(addUser_status);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addUser_role);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUser_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addUser_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 21);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 698);
            panel1.TabIndex = 4;
            // 
            // addUser_clearBtn
            // 
            addUser_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_clearBtn.FlatAppearance.BorderSize = 0;
            addUser_clearBtn.FlatStyle = FlatStyle.Flat;
            addUser_clearBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addUser_clearBtn.ForeColor = Color.White;
            addUser_clearBtn.Location = new Point(21, 534);
            addUser_clearBtn.Margin = new Padding(4, 3, 4, 3);
            addUser_clearBtn.Name = "addUser_clearBtn";
            addUser_clearBtn.Size = new Size(271, 47);
            addUser_clearBtn.TabIndex = 3;
            addUser_clearBtn.Text = "Clear";
            addUser_clearBtn.UseVisualStyleBackColor = false;
            addUser_clearBtn.Click += addUser_clearBtn_Click;
            // 
            // addUser_deleteBtn
            // 
            addUser_deleteBtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_deleteBtn.FlatAppearance.BorderSize = 0;
            addUser_deleteBtn.FlatStyle = FlatStyle.Flat;
            addUser_deleteBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addUser_deleteBtn.ForeColor = Color.White;
            addUser_deleteBtn.Location = new Point(21, 480);
            addUser_deleteBtn.Margin = new Padding(4, 3, 4, 3);
            addUser_deleteBtn.Name = "addUser_deleteBtn";
            addUser_deleteBtn.Size = new Size(271, 47);
            addUser_deleteBtn.TabIndex = 3;
            addUser_deleteBtn.Text = "Delete";
            addUser_deleteBtn.UseVisualStyleBackColor = false;
            addUser_deleteBtn.Click += addUser_deleteBtn_Click;
            // 
            // addUser_updateBtn
            // 
            addUser_updateBtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_updateBtn.FlatAppearance.BorderSize = 0;
            addUser_updateBtn.FlatStyle = FlatStyle.Flat;
            addUser_updateBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addUser_updateBtn.ForeColor = Color.White;
            addUser_updateBtn.Location = new Point(21, 426);
            addUser_updateBtn.Margin = new Padding(4, 3, 4, 3);
            addUser_updateBtn.Name = "addUser_updateBtn";
            addUser_updateBtn.Size = new Size(271, 47);
            addUser_updateBtn.TabIndex = 3;
            addUser_updateBtn.Text = "Update";
            addUser_updateBtn.UseVisualStyleBackColor = false;
            addUser_updateBtn.Click += addUser_updateBtn_Click;
            // 
            // addUser_addBtn
            // 
            addUser_addBtn.BackColor = Color.FromArgb(3, 14, 28);
            addUser_addBtn.FlatAppearance.BorderSize = 0;
            addUser_addBtn.FlatStyle = FlatStyle.Flat;
            addUser_addBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addUser_addBtn.ForeColor = Color.White;
            addUser_addBtn.Location = new Point(21, 372);
            addUser_addBtn.Margin = new Padding(4, 3, 4, 3);
            addUser_addBtn.Name = "addUser_addBtn";
            addUser_addBtn.Size = new Size(271, 47);
            addUser_addBtn.TabIndex = 3;
            addUser_addBtn.Text = "Add";
            addUser_addBtn.UseVisualStyleBackColor = false;
            addUser_addBtn.Click += addUser_addBtn_Click;
            // 
            // addUser_status
            // 
            addUser_status.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addUser_status.FormattingEnabled = true;
            addUser_status.Items.AddRange(new object[] { "Active", "Inactive" });
            addUser_status.Location = new Point(21, 287);
            addUser_status.Margin = new Padding(4, 3, 4, 3);
            addUser_status.Name = "addUser_status";
            addUser_status.Size = new Size(270, 28);
            addUser_status.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(16, 262);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 0;
            label4.Text = "Status";
            // 
            // addUser_role
            // 
            addUser_role.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addUser_role.FormattingEnabled = true;
            addUser_role.Items.AddRange(new object[] { "Admin", "Staff" });
            addUser_role.Location = new Point(21, 202);
            addUser_role.Margin = new Padding(4, 3, 4, 3);
            addUser_role.Name = "addUser_role";
            addUser_role.Size = new Size(270, 28);
            addUser_role.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(16, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 0;
            label3.Text = "Role";
            // 
            // addUser_password
            // 
            addUser_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addUser_password.Location = new Point(21, 120);
            addUser_password.Margin = new Padding(4, 3, 4, 3);
            addUser_password.Name = "addUser_password";
            addUser_password.Size = new Size(270, 26);
            addUser_password.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(16, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // addUser_username
            // 
            addUser_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addUser_username.Location = new Point(21, 43);
            addUser_username.Margin = new Padding(4, 3, 4, 3);
            addUser_username.Name = "addUser_username";
            addUser_username.Size = new Size(270, 26);
            addUser_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(16, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(363, 21);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(869, 698);
            panel2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(23, 17);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 19);
            label5.TabIndex = 4;
            label5.Text = "User's Data";
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
            dataGridView1.Location = new Point(28, 62);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(808, 607);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // admin_addUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "admin_addUser";
            Size = new Size(1252, 738);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addUser_clearBtn;
        private Button addUser_deleteBtn;
        private Button addUser_updateBtn;
        private Button addUser_addBtn;
        private ComboBox addUser_status;
        private Label label4;
        private ComboBox addUser_role;
        private Label label3;
        private TextBox addUser_password;
        private Label label2;
        private TextBox addUser_username;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private DataGridView dataGridView1;
    }
}
