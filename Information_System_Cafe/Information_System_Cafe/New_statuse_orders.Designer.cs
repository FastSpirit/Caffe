namespace Information_System_Cafe
{
    partial class New_statuse_orders
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
            this.button_new_status = new System.Windows.Forms.Button();
            this.label_number_order = new System.Windows.Forms.Label();
            this.label_number_table = new System.Windows.Forms.Label();
            this.label_order_status = new System.Windows.Forms.Label();
            this.textBox_number_order = new System.Windows.Forms.TextBox();
            this.textBox_number_table = new System.Windows.Forms.TextBox();
            this.comboBox_status_order = new System.Windows.Forms.ComboBox();
            this.label_number_dish = new System.Windows.Forms.Label();
            this.textBox_number_dish = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(13, 154);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_new_status
            // 
            this.button_new_status.Location = new System.Drawing.Point(210, 154);
            this.button_new_status.Name = "button_new_status";
            this.button_new_status.Size = new System.Drawing.Size(75, 23);
            this.button_new_status.TabIndex = 1;
            this.button_new_status.Text = "Изменить";
            this.button_new_status.UseVisualStyleBackColor = true;
            this.button_new_status.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_number_order
            // 
            this.label_number_order.AutoSize = true;
            this.label_number_order.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_order.Location = new System.Drawing.Point(9, 22);
            this.label_number_order.Name = "label_number_order";
            this.label_number_order.Size = new System.Drawing.Size(117, 21);
            this.label_number_order.TabIndex = 2;
            this.label_number_order.Text = "Номер заказа";
            // 
            // label_number_table
            // 
            this.label_number_table.AutoSize = true;
            this.label_number_table.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_table.Location = new System.Drawing.Point(9, 56);
            this.label_number_table.Name = "label_number_table";
            this.label_number_table.Size = new System.Drawing.Size(131, 21);
            this.label_number_table.TabIndex = 3;
            this.label_number_table.Text = "Номер столика";
            // 
            // label_order_status
            // 
            this.label_order_status.AutoSize = true;
            this.label_order_status.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_order_status.Location = new System.Drawing.Point(7, 116);
            this.label_order_status.Name = "label_order_status";
            this.label_order_status.Size = new System.Drawing.Size(119, 21);
            this.label_order_status.TabIndex = 4;
            this.label_order_status.Text = "Статус заказа";
            // 
            // textBox_number_order
            // 
            this.textBox_number_order.Location = new System.Drawing.Point(164, 22);
            this.textBox_number_order.Name = "textBox_number_order";
            this.textBox_number_order.Size = new System.Drawing.Size(121, 20);
            this.textBox_number_order.TabIndex = 5;
            // 
            // textBox_number_table
            // 
            this.textBox_number_table.Location = new System.Drawing.Point(164, 56);
            this.textBox_number_table.Name = "textBox_number_table";
            this.textBox_number_table.Size = new System.Drawing.Size(121, 20);
            this.textBox_number_table.TabIndex = 6;
            // 
            // comboBox_status_order
            // 
            this.comboBox_status_order.FormattingEnabled = true;
            this.comboBox_status_order.Items.AddRange(new object[] {
            "В процессе приготовления",
            "Готов к выдаче"});
            this.comboBox_status_order.Location = new System.Drawing.Point(164, 116);
            this.comboBox_status_order.Name = "comboBox_status_order";
            this.comboBox_status_order.Size = new System.Drawing.Size(121, 21);
            this.comboBox_status_order.TabIndex = 7;
            // 
            // label_number_dish
            // 
            this.label_number_dish.AutoSize = true;
            this.label_number_dish.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_dish.Location = new System.Drawing.Point(9, 86);
            this.label_number_dish.Name = "label_number_dish";
            this.label_number_dish.Size = new System.Drawing.Size(118, 21);
            this.label_number_dish.TabIndex = 8;
            this.label_number_dish.Text = "Номер блюда";
            // 
            // textBox_number_dish
            // 
            this.textBox_number_dish.Location = new System.Drawing.Point(164, 88);
            this.textBox_number_dish.Name = "textBox_number_dish";
            this.textBox_number_dish.Size = new System.Drawing.Size(121, 20);
            this.textBox_number_dish.TabIndex = 9;
            // 
            // New_statuse_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(311, 191);
            this.Controls.Add(this.textBox_number_dish);
            this.Controls.Add(this.label_number_dish);
            this.Controls.Add(this.comboBox_status_order);
            this.Controls.Add(this.textBox_number_table);
            this.Controls.Add(this.textBox_number_order);
            this.Controls.Add(this.label_order_status);
            this.Controls.Add(this.label_number_table);
            this.Controls.Add(this.label_number_order);
            this.Controls.Add(this.button_new_status);
            this.Controls.Add(this.button_Exit);
            this.Name = "New_statuse_orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_statuse_orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_new_status;
        private System.Windows.Forms.Label label_number_order;
        private System.Windows.Forms.Label label_number_table;
        private System.Windows.Forms.Label label_order_status;
        private System.Windows.Forms.TextBox textBox_number_order;
        private System.Windows.Forms.TextBox textBox_number_table;
        private System.Windows.Forms.ComboBox comboBox_status_order;
        private System.Windows.Forms.Label label_number_dish;
        private System.Windows.Forms.TextBox textBox_number_dish;
    }
}