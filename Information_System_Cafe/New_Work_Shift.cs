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
    public partial class New_work_shift : Form
    {
        public New_work_shift()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_new_work_shift_Click(object sender, EventArgs e)
        {
            Data_Base_Class db = new Data_Base_Class("Data Source=PC_Amal;Initial Catalog=Cafe;Integrated Security=True");
            db.OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Work_shift (Номер_смены, дата_смены, номер_сотрудника,имя_сотрудника,статус_сотрудника) VALUES (@Номер_смены, @дата_смены, @номер_сотрудника,@имя_сотрудника,@статус_сотрудника)", db.GetConnection());
            command.Parameters.AddWithValue("@Номер_Смены", textBox_number_work_shift.Text);
            command.Parameters.AddWithValue("@дата_смены", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@номер_сотрудника", textBox_namber_user.Text);
            command.Parameters.AddWithValue("@имя_сотрудника", textBox_name_user.Text);
            command.Parameters.AddWithValue("@Статус_сотрудника",comboBox1.SelectedItem.ToString());
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
