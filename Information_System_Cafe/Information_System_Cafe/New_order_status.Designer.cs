namespace Information_System_Cafe
{
    partial class New_order_status
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
            this.button_change = new System.Windows.Forms.Button();
            this.label_number_order = new System.Windows.Forms.Label();
            this.label_number_dish = new System.Windows.Forms.Label();
            this.label_number_portion = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.textBox_number_order = new System.Windows.Forms.TextBox();
            this.textBox_number_dish = new System.Windows.Forms.TextBox();
            this.textBox_number_portion = new System.Windows.Forms.TextBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(17, 175);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(251, 175);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 1;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
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
            // label_number_dish
            // 
            this.label_number_dish.AutoSize = true;
            this.label_number_dish.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_dish.Location = new System.Drawing.Point(13, 47);
            this.label_number_dish.Name = "label_number_dish";
            this.label_number_dish.Size = new System.Drawing.Size(118, 21);
            this.label_number_dish.TabIndex = 3;
            this.label_number_dish.Text = "Номер блюда";
            // 
            // label_number_portion
            // 
            this.label_number_portion.AutoSize = true;
            this.label_number_portion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_portion.Location = new System.Drawing.Point(13, 78);
            this.label_number_portion.Name = "label_number_portion";
            this.label_number_portion.Size = new System.Drawing.Size(170, 21);
            this.label_number_portion.TabIndex = 4;
            this.label_number_portion.Text = "Количество порций";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.Location = new System.Drawing.Point(13, 107);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(65, 21);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "Статус";
            // 
            // textBox_number_order
            // 
            this.textBox_number_order.Location = new System.Drawing.Point(205, 13);
            this.textBox_number_order.Name = "textBox_number_order";
            this.textBox_number_order.Size = new System.Drawing.Size(121, 20);
            this.textBox_number_order.TabIndex = 6;
            // 
            // textBox_number_dish
            // 
            this.textBox_number_dish.Location = new System.Drawing.Point(205, 49);
            this.textBox_number_dish.Name = "textBox_number_dish";
            this.textBox_number_dish.Size = new System.Drawing.Size(121, 20);
            this.textBox_number_dish.TabIndex = 7;
            // 
            // textBox_number_portion
            // 
            this.textBox_number_portion.Location = new System.Drawing.Point(205, 80);
            this.textBox_number_portion.Name = "textBox_number_portion";
            this.textBox_number_portion.Size = new System.Drawing.Size(121, 20);
            this.textBox_number_portion.TabIndex = 8;
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "В процессе приготовления",
            "Заказ готов"});
            this.comboBox_status.Location = new System.Drawing.Point(205, 106);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_status.TabIndex = 9;
            // 
            // New_order_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(345, 213);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.textBox_number_portion);
            this.Controls.Add(this.textBox_number_dish);
            this.Controls.Add(this.textBox_number_order);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_number_portion);
            this.Controls.Add(this.label_number_dish);
            this.Controls.Add(this.label_number_order);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_Exit);
            this.Name = "New_order_status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_order_status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Label label_number_order;
        private System.Windows.Forms.Label label_number_dish;
        private System.Windows.Forms.Label label_number_portion;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox textBox_number_order;
        private System.Windows.Forms.TextBox textBox_number_dish;
        private System.Windows.Forms.TextBox textBox_number_portion;
        private System.Windows.Forms.ComboBox comboBox_status;
    }
}