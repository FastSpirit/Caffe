namespace Information_System_Cafe
{
    partial class New_Orders
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
            this.button_add_orders = new System.Windows.Forms.Button();
            this.label_number_order = new System.Windows.Forms.Label();
            this.label_name_user = new System.Windows.Forms.Label();
            this.label_number_dish = new System.Windows.Forms.Label();
            this.label_number_portion = new System.Windows.Forms.Label();
            this.label_number_table = new System.Windows.Forms.Label();
            this.label_date_order = new System.Windows.Forms.Label();
            this.textBox_number_order = new System.Windows.Forms.TextBox();
            this.textBox_name_user = new System.Windows.Forms.TextBox();
            this.textBox_number_dish = new System.Windows.Forms.TextBox();
            this.textBox_number_portion = new System.Windows.Forms.TextBox();
            this.textBox_number_table = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(17, 245);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_add_orders
            // 
            this.button_add_orders.Location = new System.Drawing.Point(268, 245);
            this.button_add_orders.Name = "button_add_orders";
            this.button_add_orders.Size = new System.Drawing.Size(75, 23);
            this.button_add_orders.TabIndex = 1;
            this.button_add_orders.Text = "Добавить";
            this.button_add_orders.UseVisualStyleBackColor = true;
            this.button_add_orders.Click += new System.EventHandler(this.button_add_orders_Click);
            // 
            // label_number_order
            // 
            this.label_number_order.AutoSize = true;
            this.label_number_order.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_order.Location = new System.Drawing.Point(13, 13);
            this.label_number_order.Name = "label_number_order";
            this.label_number_order.Size = new System.Drawing.Size(117, 21);
            this.label_number_order.TabIndex = 2;
            this.label_number_order.Text = "Номер заказа";
            // 
            // label_name_user
            // 
            this.label_name_user.AutoSize = true;
            this.label_name_user.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_user.Location = new System.Drawing.Point(12, 42);
            this.label_name_user.Name = "label_name_user";
            this.label_name_user.Size = new System.Drawing.Size(141, 21);
            this.label_name_user.TabIndex = 3;
            this.label_name_user.Text = "Имя сотрудника";
            // 
            // label_number_dish
            // 
            this.label_number_dish.AutoSize = true;
            this.label_number_dish.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_dish.Location = new System.Drawing.Point(12, 78);
            this.label_number_dish.Name = "label_number_dish";
            this.label_number_dish.Size = new System.Drawing.Size(118, 21);
            this.label_number_dish.TabIndex = 4;
            this.label_number_dish.Text = "Номер блюда";
            // 
            // label_number_portion
            // 
            this.label_number_portion.AutoSize = true;
            this.label_number_portion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_portion.Location = new System.Drawing.Point(13, 116);
            this.label_number_portion.Name = "label_number_portion";
            this.label_number_portion.Size = new System.Drawing.Size(170, 21);
            this.label_number_portion.TabIndex = 5;
            this.label_number_portion.Text = "Количество порций";
            // 
            // label_number_table
            // 
            this.label_number_table.AutoSize = true;
            this.label_number_table.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_table.Location = new System.Drawing.Point(13, 152);
            this.label_number_table.Name = "label_number_table";
            this.label_number_table.Size = new System.Drawing.Size(131, 21);
            this.label_number_table.TabIndex = 6;
            this.label_number_table.Text = "Номер столика";
            // 
            // label_date_order
            // 
            this.label_date_order.AutoSize = true;
            this.label_date_order.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date_order.Location = new System.Drawing.Point(13, 192);
            this.label_date_order.Name = "label_date_order";
            this.label_date_order.Size = new System.Drawing.Size(47, 21);
            this.label_date_order.TabIndex = 8;
            this.label_date_order.Text = "Дата";
            // 
            // textBox_number_order
            // 
            this.textBox_number_order.Location = new System.Drawing.Point(204, 13);
            this.textBox_number_order.Name = "textBox_number_order";
            this.textBox_number_order.Size = new System.Drawing.Size(139, 20);
            this.textBox_number_order.TabIndex = 9;
            // 
            // textBox_name_user
            // 
            this.textBox_name_user.Location = new System.Drawing.Point(204, 44);
            this.textBox_name_user.Name = "textBox_name_user";
            this.textBox_name_user.Size = new System.Drawing.Size(139, 20);
            this.textBox_name_user.TabIndex = 10;
            // 
            // textBox_number_dish
            // 
            this.textBox_number_dish.Location = new System.Drawing.Point(204, 80);
            this.textBox_number_dish.Name = "textBox_number_dish";
            this.textBox_number_dish.Size = new System.Drawing.Size(139, 20);
            this.textBox_number_dish.TabIndex = 11;
            // 
            // textBox_number_portion
            // 
            this.textBox_number_portion.Location = new System.Drawing.Point(204, 118);
            this.textBox_number_portion.Name = "textBox_number_portion";
            this.textBox_number_portion.Size = new System.Drawing.Size(139, 20);
            this.textBox_number_portion.TabIndex = 12;
            // 
            // textBox_number_table
            // 
            this.textBox_number_table.Location = new System.Drawing.Point(204, 154);
            this.textBox_number_table.Name = "textBox_number_table";
            this.textBox_number_table.Size = new System.Drawing.Size(139, 20);
            this.textBox_number_table.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // New_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(353, 282);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_number_table);
            this.Controls.Add(this.textBox_number_portion);
            this.Controls.Add(this.textBox_number_dish);
            this.Controls.Add(this.textBox_name_user);
            this.Controls.Add(this.textBox_number_order);
            this.Controls.Add(this.label_date_order);
            this.Controls.Add(this.label_number_table);
            this.Controls.Add(this.label_number_portion);
            this.Controls.Add(this.label_number_dish);
            this.Controls.Add(this.label_name_user);
            this.Controls.Add(this.label_number_order);
            this.Controls.Add(this.button_add_orders);
            this.Controls.Add(this.button_Exit);
            this.Name = "New_Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_add_orders;
        private System.Windows.Forms.Label label_number_order;
        private System.Windows.Forms.Label label_name_user;
        private System.Windows.Forms.Label label_number_dish;
        private System.Windows.Forms.Label label_number_portion;
        private System.Windows.Forms.Label label_number_table;
        private System.Windows.Forms.Label label_date_order;
        private System.Windows.Forms.TextBox textBox_number_order;
        private System.Windows.Forms.TextBox textBox_name_user;
        private System.Windows.Forms.TextBox textBox_number_dish;
        private System.Windows.Forms.TextBox textBox_number_portion;
        private System.Windows.Forms.TextBox textBox_number_table;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}