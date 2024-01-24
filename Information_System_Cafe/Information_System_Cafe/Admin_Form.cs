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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Information_System_Cafe
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void radioButton_order_CheckedChanged_1(object sender, EventArgs e)
        {

            if (radioButton_order.Checked)
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
        }

        private void radioButton_user_CheckedChanged(object sender, EventArgs e)
        {
            button_create_new_users.Visible = true;
            button_change_status.Visible = true;
            button_work_shift.Visible = false;

            
            // Создайте соединение с базой данных
            Data_Base_Class db = new Data_Base_Class("Data Source=PC_Amal;Initial Catalog=Cafe;Integrated Security=True");
            db.OpenConnection();

            // Создайте новый SQL-запрос
            SqlCommand command = new SqlCommand("SELECT * FROM Users", db.GetConnection());

            // Загрузите данные в DataTable
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            // Установите DataTable в качестве источника данных для DataGridView
            dataGridView1.DataSource = table;

            // Закройте соединение с базой данных
            db.CloseConnection();
        }

        private void radioButton_work_shift_CheckedChanged(object sender, EventArgs e)
        {
            button_create_new_users.Visible = false;
            button_change_status.Visible = false;
            button_work_shift.Visible = true;

            // Создайте соединение с базой данных
            Data_Base_Class db = new Data_Base_Class("Data Source=PC_Amal;Initial Catalog=Cafe;Integrated Security=True");
            db.OpenConnection();

            // Создайте новый SQL-запрос
            SqlCommand command = new SqlCommand("SELECT * FROM Work_shift", db.GetConnection());

            // Загрузите данные в DataTable
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            // Установите DataTable в качестве источника данных для DataGridView
            dataGridView1.DataSource = table;

            // Закройте соединение с базой данных
            db.CloseConnection();
        }

        private void button_create_new_users_Click(object sender, EventArgs e)
        {
            New_Users new_Users = new New_Users();
            new_Users.Show();

        }

        private void button_change_status_Click(object sender, EventArgs e)
        {
            New_Statuse new_Statuse = new New_Statuse();
            new_Statuse.Show();
        }

        private void button_work_shift_Click(object sender, EventArgs e)
        {
            New_work_shift new_Work_Shift = new New_work_shift();
            new_Work_Shift.Show();
        }
    }
}
