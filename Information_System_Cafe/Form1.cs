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
    public partial class Form_Authorization : Form
    {
        
        public Form_Authorization()
        {
            InitializeComponent();
        }

         
        private void Button_Enter_Authorization_Click_1(object sender, EventArgs e)
        {
            string login = textBox_Login.Text;
            string password = textBox_Password.Text;

            Data_Base_Class db = new Data_Base_Class("Data Source=PC_AMAL;Initial Catalog=Cafe;Integrated Security=True");
            db.OpenConnection();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Логин=@login AND Пароль=@password", db.GetConnection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string role = reader["Роль"].ToString();
                    switch (role)
                    {
                        case "Администратор":
                            MessageBox.Show("Авториация Админа"); // Открыть форму администратора
                            Admin_Form adminForm = new Admin_Form();
                            adminForm.Show();
                            this.Hide();
                            break;
                        case "Повар":
                            MessageBox.Show("Авторизация Повара"); // Открыть форму повара
                            Сook_Form cookForm = new Сook_Form();
                            cookForm.Show();
                            this.Hide();
                            break;
                        // Добавьте здесь другие роли по мере необходимости
                        default:
                            MessageBox.Show("Авториация ОФицианта");    // Открыть форму по умолчанию
                            Garcon_Form garconForm = new Garcon_Form();
                            garconForm.Show();
                            this.Hide();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }

            db.CloseConnection();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
