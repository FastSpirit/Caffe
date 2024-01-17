namespace Information_System_Cafe
{
    partial class Form_Authorization
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.Button_Enter_Authorization = new System.Windows.Forms.Button();
            this.label_text_Authorization = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Login.Location = new System.Drawing.Point(29, 114);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(53, 21);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Login";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(29, 194);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(84, 21);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(119, 106);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(100, 29);
            this.textBox_Login.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.Location = new System.Drawing.Point(119, 186);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 29);
            this.textBox_Password.TabIndex = 3;
            // 
            // Button_Enter_Authorization
            // 
            this.Button_Enter_Authorization.Location = new System.Drawing.Point(138, 268);
            this.Button_Enter_Authorization.Name = "Button_Enter_Authorization";
            this.Button_Enter_Authorization.Size = new System.Drawing.Size(81, 28);
            this.Button_Enter_Authorization.TabIndex = 5;
            this.Button_Enter_Authorization.Text = "Enter";
            this.Button_Enter_Authorization.UseVisualStyleBackColor = true;
            this.Button_Enter_Authorization.Click += new System.EventHandler(this.Button_Enter_Authorization_Click_1);
            // 
            // label_text_Authorization
            // 
            this.label_text_Authorization.AutoSize = true;
            this.label_text_Authorization.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text_Authorization.Location = new System.Drawing.Point(68, 45);
            this.label_text_Authorization.Name = "label_text_Authorization";
            this.label_text_Authorization.Size = new System.Drawing.Size(115, 21);
            this.label_text_Authorization.TabIndex = 6;
            this.label_text_Authorization.Text = "Авторизация";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(33, 268);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(81, 28);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Form_Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(243, 314);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label_text_Authorization);
            this.Controls.Add(this.Button_Enter_Authorization);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button Button_Enter_Authorization;
        private System.Windows.Forms.Label label_text_Authorization;
        private System.Windows.Forms.Button button_Exit;
    }
}

