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
    public partial class Сook_Form : Form
    {
        public Сook_Form()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true; // close create new colum and line
                                           // Создайте соединение с базой данных
            Data_Base_Class db = new Data_Base_Class("Data Source=PC_Amal;Initial Catalog=Cafe;Integrated Security=True");
            db.OpenConnection();

            // Создайте новый SQL-запрос
            SqlCommand command = new SqlCommand("SELECT * FROM Orders", db.GetConnection());

            // Загрузите данные в DataTable
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            // Установите DataTable в качестве источника данных для DataGridView
            dataGridView1.DataSource = table;

            // Закройте соединение с базой данных
            db.CloseConnection();
        }

        private void button_new_status_Click(object sender, EventArgs e)
        {
            New_order_status new_Order_Status = new New_order_status();
            new_Order_Status.ShowDialog();
        }
    }
}
