using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_System_Cafe
{
    public partial class New_order_status : Form
    {
        public New_order_status()
        {
            InitializeComponent();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Data_Base_Class db = new Data_Base_Class("Data Source=PC_Amal;Initial Catalog=Cafe;Integrated Security=True");
            db.OpenConnection();

            SqlCommand command = new SqlCommand("UPDATE orders SET Статус = @Статус WHERE Номер_заказа = @Номер_заказа AND Номер_блюда = @номер_блюда AND количество_порций = @количество_порций", db.GetConnection());
            command.Parameters.AddWithValue("@Статус", comboBox_status.SelectedItem.ToString());
            command.Parameters.AddWithValue("@Номер_заказа", textBox_number_order.Text);
            command.Parameters.AddWithValue("@Номер_блюда", textBox_number_dish.Text);
            command.Parameters.AddWithValue("@Количество_порций", textBox_number_portion.Text);
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
