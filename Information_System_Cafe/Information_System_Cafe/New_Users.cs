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
using System.Windows.Forms.VisualStyles;

namespace Information_System_Cafe
{
    public partial class New_Users : Form
    {
        public New_Users()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            Data_Base_Class db = new Data_Base_Class("Data Source=PC_Amal;Initial Catalog=Cafe;Integrated Security=True");
            db.OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Users (Номер_Сотрудника, Имя, Фамилия, Роль, Логин, Пароль, Статус) VALUES (@Номер_Сотрудника, @Имя, @Фамилия, @Роль, @Логин, @Пароль, @Статус)", db.GetConnection());
            command.Parameters.AddWithValue("@Номер_Сотрудника", textBox_numder_user.Text);
            command.Parameters.AddWithValue("@Имя", textBox_name_user.Text);
            command.Parameters.AddWithValue("@Фамилия", textBox_surename_user.Text);
            command.Parameters.AddWithValue("@Роль", textBox_role_user.Text);
            command.Parameters.AddWithValue("@Логин",textBox_login_user.Text);
            command.Parameters.AddWithValue("@Пароль", textBox_password_user.Text);
            command.Parameters.AddWithValue("@Статус", comboBox_statuse_user.SelectedItem.ToString());
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
