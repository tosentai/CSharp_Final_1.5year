namespace Final.UserInterface
{
    partial class admin_customers
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
            label5 = new Label();
            dataGridView1 = new DataGridView();
            admin_rooms_deleteBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(admin_rooms_deleteBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(15, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 704);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(19, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 19;
            label5.Text = "All Customers";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 59);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1174, 558);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // admin_rooms_deleteBtn
            // 
            admin_rooms_deleteBtn.BackColor = Color.FromArgb(3, 14, 28);
            admin_rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            admin_rooms_deleteBtn.FlatStyle = FlatStyle.Flat;
            admin_rooms_deleteBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            admin_rooms_deleteBtn.ForeColor = Color.White;
            admin_rooms_deleteBtn.Location = new Point(23, 638);
            admin_rooms_deleteBtn.Margin = new Padding(4, 3, 4, 3);
            admin_rooms_deleteBtn.Name = "admin_rooms_deleteBtn";
            admin_rooms_deleteBtn.Size = new Size(271, 47);
            admin_rooms_deleteBtn.TabIndex = 20;
            admin_rooms_deleteBtn.Text = "Delete";
            admin_rooms_deleteBtn.UseVisualStyleBackColor = false;
            admin_rooms_deleteBtn.Click += admin_rooms_deleteBtn_Click;
            // 
            // admin_customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "admin_customers";
            Size = new Size(1255, 738);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button admin_rooms_deleteBtn;
    }
}
