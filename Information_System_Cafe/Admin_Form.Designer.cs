namespace Information_System_Cafe
{
    partial class Admin_Form
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
            this.Button_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_work_shift = new System.Windows.Forms.RadioButton();
            this.radioButton_order = new System.Windows.Forms.RadioButton();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.button_change_status = new System.Windows.Forms.Button();
            this.button_create_new_users = new System.Windows.Forms.Button();
            this.button_work_shift = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(587, 323);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(211, 23);
            this.Button_Exit.TabIndex = 0;
            this.Button_Exit.Text = " Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_work_shift);
            this.groupBox1.Controls.Add(this.radioButton_order);
            this.groupBox1.Controls.Add(this.radioButton_user);
            this.groupBox1.Location = new System.Drawing.Point(611, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отобразить информацию";
            // 
            // radioButton_work_shift
            // 
            this.radioButton_work_shift.AutoSize = true;
            this.radioButton_work_shift.Location = new System.Drawing.Point(6, 76);
            this.radioButton_work_shift.Name = "radioButton_work_shift";
            this.radioButton_work_shift.Size = new System.Drawing.Size(58, 17);
            this.radioButton_work_shift.TabIndex = 4;
            this.radioButton_work_shift.TabStop = true;
            this.radioButton_work_shift.Text = "Смена";
            this.radioButton_work_shift.UseVisualStyleBackColor = true;
            this.radioButton_work_shift.CheckedChanged += new System.EventHandler(this.radioButton_work_shift_CheckedChanged);
            // 
            // radioButton_order
            // 
            this.radioButton_order.AutoSize = true;
            this.radioButton_order.Location = new System.Drawing.Point(6, 30);
            this.radioButton_order.Name = "radioButton_order";
            this.radioButton_order.Size = new System.Drawing.Size(64, 17);
            this.radioButton_order.TabIndex = 2;
            this.radioButton_order.TabStop = true;
            this.radioButton_order.Text = "Заказы";
            this.radioButton_order.UseVisualStyleBackColor = true;
            this.radioButton_order.CheckedChanged += new System.EventHandler(this.radioButton_order_CheckedChanged_1);
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Location = new System.Drawing.Point(6, 53);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(84, 17);
            this.radioButton_user.TabIndex = 1;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "Сотрудники";
            this.radioButton_user.UseVisualStyleBackColor = true;
            this.radioButton_user.CheckedChanged += new System.EventHandler(this.radioButton_user_CheckedChanged);
            // 
            // button_change_status
            // 
            this.button_change_status.Location = new System.Drawing.Point(585, 157);
            this.button_change_status.Name = "button_change_status";
            this.button_change_status.Size = new System.Drawing.Size(213, 23);
            this.button_change_status.TabIndex = 6;
            this.button_change_status.Text = "Изменить статус сотрудника";
            this.button_change_status.UseVisualStyleBackColor = true;
            this.button_change_status.Visible = false;
            this.button_change_status.Click += new System.EventHandler(this.button_change_status_Click);
            // 
            // button_create_new_users
            // 
            this.button_create_new_users.Location = new System.Drawing.Point(585, 128);
            this.button_create_new_users.Name = "button_create_new_users";
            this.button_create_new_users.Size = new System.Drawing.Size(213, 23);
            this.button_create_new_users.TabIndex = 7;
            this.button_create_new_users.Text = "Регистрация сотрудника";
            this.button_create_new_users.UseVisualStyleBackColor = true;
            this.button_create_new_users.Visible = false;
            this.button_create_new_users.Click += new System.EventHandler(this.button_create_new_users_Click);
            // 
            // button_work_shift
            // 
            this.button_work_shift.Location = new System.Drawing.Point(585, 186);
            this.button_work_shift.Name = "button_work_shift";
            this.button_work_shift.Size = new System.Drawing.Size(213, 23);
            this.button_work_shift.TabIndex = 8;
            this.button_work_shift.Text = "Сформировать смены";
            this.button_work_shift.UseVisualStyleBackColor = true;
            this.button_work_shift.Visible = false;
            this.button_work_shift.Click += new System.EventHandler(this.button_work_shift_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 333);
            this.dataGridView1.TabIndex = 9;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(813, 353);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_work_shift);
            this.Controls.Add(this.button_create_new_users);
            this.Controls.Add(this.button_change_status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Button_Exit);
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_work_shift;
        private System.Windows.Forms.RadioButton radioButton_order;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.Button button_change_status;
        private System.Windows.Forms.Button button_create_new_users;
        private System.Windows.Forms.Button button_work_shift;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}