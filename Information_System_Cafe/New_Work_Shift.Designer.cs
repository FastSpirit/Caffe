namespace Information_System_Cafe
{
    partial class New_work_shift
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_add_new_work_shift = new System.Windows.Forms.Button();
            this.label_number_work_shift = new System.Windows.Forms.Label();
            this.label_date_work_shift = new System.Windows.Forms.Label();
            this.label_number_order = new System.Windows.Forms.Label();
            this.label_name_user = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_number_work_shift = new System.Windows.Forms.TextBox();
            this.textBox_namber_user = new System.Windows.Forms.TextBox();
            this.textBox_name_user = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(17, 208);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_add_new_work_shift
            // 
            this.button_add_new_work_shift.Location = new System.Drawing.Point(255, 208);
            this.button_add_new_work_shift.Name = "button_add_new_work_shift";
            this.button_add_new_work_shift.Size = new System.Drawing.Size(75, 23);
            this.button_add_new_work_shift.TabIndex = 1;
            this.button_add_new_work_shift.Text = "Добавить";
            this.button_add_new_work_shift.UseVisualStyleBackColor = true;
            this.button_add_new_work_shift.Click += new System.EventHandler(this.button_add_new_work_shift_Click);
            // 
            // label_number_work_shift
            // 
            this.label_number_work_shift.AutoSize = true;
            this.label_number_work_shift.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_work_shift.Location = new System.Drawing.Point(13, 13);
            this.label_number_work_shift.Name = "label_number_work_shift";
            this.label_number_work_shift.Size = new System.Drawing.Size(120, 21);
            this.label_number_work_shift.TabIndex = 2;
            this.label_number_work_shift.Text = "Номер смены";
            // 
            // label_date_work_shift
            // 
            this.label_date_work_shift.AutoSize = true;
            this.label_date_work_shift.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date_work_shift.Location = new System.Drawing.Point(13, 41);
            this.label_date_work_shift.Name = "label_date_work_shift";
            this.label_date_work_shift.Size = new System.Drawing.Size(104, 21);
            this.label_date_work_shift.TabIndex = 3;
            this.label_date_work_shift.Text = "Дата смены";
            // 
            // label_number_order
            // 
            this.label_number_order.AutoSize = true;
            this.label_number_order.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_order.Location = new System.Drawing.Point(12, 70);
            this.label_number_order.Name = "label_number_order";
            this.label_number_order.Size = new System.Drawing.Size(160, 21);
            this.label_number_order.TabIndex = 4;
            this.label_number_order.Text = "Номер сотрудника";
            // 
            // label_name_user
            // 
            this.label_name_user.AutoSize = true;
            this.label_name_user.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_user.Location = new System.Drawing.Point(13, 96);
            this.label_name_user.Name = "label_name_user";
            this.label_name_user.Size = new System.Drawing.Size(141, 21);
            this.label_name_user.TabIndex = 5;
            this.label_name_user.Text = "Имя сотрудника";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.Location = new System.Drawing.Point(13, 122);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(65, 21);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "Статус";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Администратор",
            "Повар",
            "Официант"});
            this.comboBox1.Location = new System.Drawing.Point(189, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox_number_work_shift
            // 
            this.textBox_number_work_shift.Location = new System.Drawing.Point(189, 13);
            this.textBox_number_work_shift.Name = "textBox_number_work_shift";
            this.textBox_number_work_shift.Size = new System.Drawing.Size(141, 20);
            this.textBox_number_work_shift.TabIndex = 8;
            // 
            // textBox_namber_user
            // 
            this.textBox_namber_user.Location = new System.Drawing.Point(189, 70);
            this.textBox_namber_user.Name = "textBox_namber_user";
            this.textBox_namber_user.Size = new System.Drawing.Size(141, 20);
            this.textBox_namber_user.TabIndex = 9;
            // 
            // textBox_name_user
            // 
            this.textBox_name_user.Location = new System.Drawing.Point(189, 96);
            this.textBox_name_user.Name = "textBox_name_user";
            this.textBox_name_user.Size = new System.Drawing.Size(141, 20);
            this.textBox_name_user.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // New_work_shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(346, 242);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_name_user);
            this.Controls.Add(this.textBox_namber_user);
            this.Controls.Add(this.textBox_number_work_shift);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_name_user);
            this.Controls.Add(this.label_number_order);
            this.Controls.Add(this.label_date_work_shift);
            this.Controls.Add(this.label_number_work_shift);
            this.Controls.Add(this.button_add_new_work_shift);
            this.Controls.Add(this.button_Exit);
            this.Name = "New_work_shift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_work_shift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_add_new_work_shift;
        private System.Windows.Forms.Label label_number_work_shift;
        private System.Windows.Forms.Label label_date_work_shift;
        private System.Windows.Forms.Label label_number_order;
        private System.Windows.Forms.Label label_name_user;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_number_work_shift;
        private System.Windows.Forms.TextBox textBox_namber_user;
        private System.Windows.Forms.TextBox textBox_name_user;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}