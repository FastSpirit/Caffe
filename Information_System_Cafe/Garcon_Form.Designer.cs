namespace Information_System_Cafe
{
    partial class Garcon_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_new_order = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(12, 260);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 219);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_new_order
            // 
            this.button_new_order.Location = new System.Drawing.Point(653, 260);
            this.button_new_order.Name = "button_new_order";
            this.button_new_order.Size = new System.Drawing.Size(135, 23);
            this.button_new_order.TabIndex = 2;
            this.button_new_order.Text = "Создать заказ";
            this.button_new_order.UseVisualStyleBackColor = true;
            this.button_new_order.Click += new System.EventHandler(this.button_new_order_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(536, 260);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 3;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Garcon_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(799, 299);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_new_order);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Exit);
            this.Name = "Garcon_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garcon_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_new_order;
        private System.Windows.Forms.Button button_refresh;
    }
}