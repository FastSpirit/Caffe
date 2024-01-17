namespace Information_System_Cafe
{
    partial class New_Statuse
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
            this.button_new_statuse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_number_user = new System.Windows.Forms.TextBox();
            this.textBox_name_user = new System.Windows.Forms.TextBox();
            this.comboBox_statuse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(25, 146);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_new_statuse
            // 
            this.button_new_statuse.Location = new System.Drawing.Point(284, 146);
            this.button_new_statuse.Name = "button_new_statuse";
            this.button_new_statuse.Size = new System.Drawing.Size(75, 23);
            this.button_new_statuse.TabIndex = 1;
            this.button_new_statuse.Text = "Изменить";
            this.button_new_statuse.UseVisualStyleBackColor = true;
            this.button_new_statuse.Click += new System.EventHandler(this.button_new_statuse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Статус в системе";
            // 
            // textBox_number_user
            // 
            this.textBox_number_user.Location = new System.Drawing.Point(222, 19);
            this.textBox_number_user.Name = "textBox_number_user";
            this.textBox_number_user.Size = new System.Drawing.Size(137, 20);
            this.textBox_number_user.TabIndex = 5;
            // 
            // textBox_name_user
            // 
            this.textBox_name_user.Location = new System.Drawing.Point(222, 56);
            this.textBox_name_user.Name = "textBox_name_user";
            this.textBox_name_user.Size = new System.Drawing.Size(137, 20);
            this.textBox_name_user.TabIndex = 6;
            // 
            // comboBox_statuse
            // 
            this.comboBox_statuse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_statuse.FormattingEnabled = true;
            this.comboBox_statuse.Items.AddRange(new object[] {
            "Работает",
            "Уволен"});
            this.comboBox_statuse.Location = new System.Drawing.Point(216, 95);
            this.comboBox_statuse.Name = "comboBox_statuse";
            this.comboBox_statuse.Size = new System.Drawing.Size(143, 29);
            this.comboBox_statuse.TabIndex = 7;
            // 
            // New_Statuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(389, 177);
            this.Controls.Add(this.comboBox_statuse);
            this.Controls.Add(this.textBox_name_user);
            this.Controls.Add(this.textBox_number_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_new_statuse);
            this.Controls.Add(this.button_Exit);
            this.Name = "New_Statuse";
            this.Text = "New_Statuse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_new_statuse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_number_user;
        private System.Windows.Forms.TextBox textBox_name_user;
        private System.Windows.Forms.ComboBox comboBox_statuse;
    }
}