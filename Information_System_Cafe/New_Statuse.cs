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
    public partial class New_Statuse : Form
    {
        public New_Statuse()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button_new_statuse_Click(object sender, EventArgs e)
        {
            Data_Base_Class db = new Data_Base_Class("Data Source=PC_Amal;Initial Catalog=Cafe;Integrated Security=True");
            db.OpenConnection();

            SqlCommand command = new SqlCommand("UPDATE Users SET Статус = @Статус WHERE Номер_Сотрудника = @Номер_Сотрудника AND Имя = @Имя", db.GetConnection());
            command.Parameters.AddWithValue("@Статус", comboBox_statuse.SelectedItem.ToString());
            command.Parameters.AddWithValue("@Номер_Сотрудника", textBox_number_user.Text);
            command.Parameters.AddWithValue("@Имя", textBox_name_user.Text);
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
