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
    public partial class New_Orders : Form
    {
        public New_Orders()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_orders_Click(object sender, EventArgs e)
        {
            Data_Base_Class db = new Data_Base_Class("Data Source=PC_Amal;Initial Catalog=Cafe;Integrated Security=True");
            db.OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Orders (Номер_заказа, Имя_сотрудника, номер_блюда, количество_порций, Номер_столика,  Дата_заказа) VALUES (@Номер_заказа, @Имя_сотрудника, @Номер_блюда, @количество_порций, @Номер_столика,  @Дата_заказа)", db.GetConnection());
            command.Parameters.AddWithValue("@Номер_заказа", textBox_number_order.Text);
            command.Parameters.AddWithValue("@Имя_сотрудника", textBox_name_user.Text);
            command.Parameters.AddWithValue("@Номер_блюда", textBox_number_dish.Text);
            command.Parameters.AddWithValue("@Количество_порций", textBox_number_portion.Text);
            command.Parameters.AddWithValue("@Номер_столика", textBox_number_table.Text);
            command.Parameters.AddWithValue("@Дата_заказа", dateTimePicker1.Value.Date.ToString());
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
