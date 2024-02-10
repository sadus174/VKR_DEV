using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VKR_DEV
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginTXT = textBox1.Text;
            string passwordTXT = textBox2.Text;

            // строка подключения к БД
            string connStr = "server=10.80.1.7;port=3306;user=st_60;database=is_60_EKZ;password=123456789;";
            //Переменная соединения
            MySqlConnection conn;
            //Инициализация подключения
            conn = new MySqlConnection(connStr);
            //Открываем соединения
            conn.Open();
            //Составляем запрос
            string querySql = $"SELECT COUNT(*) FROM T_Users WHERE loginUsers='{loginTXT}' and passUsers='{passwordTXT}' and enabledUsers=1";
            //Формируем комманду
            MySqlCommand authCom = new MySqlCommand(querySql, conn);
            //Выполняем команду
            string result = authCom.ExecuteScalar().ToString();

            if(Convert.ToInt32(result) > 0) 
            {

                string queryGetDataUser = $"SELECT " +
                    $"T_Users.idUsers, " +
                    $"T_Users.loginUsers, " +
                    $"T_Users.passUsers, " +
                    $"T_Users.fioUsers, 	" +
                    $"T_Users.enabledUsers, 	" +
                    $"T_Role.titleRole, 	" +
                    $"T_Users.roleUsers " +
                    $"FROM	T_Role	" +
                    $"INNER JOIN 	T_Users	ON 		T_Role.idRole = T_Users.roleUsers " +
                    $"WHERE T_Users.loginUsers='{loginTXT}' and T_Users.passUsers='{passwordTXT}' and T_Users.enabledUsers=1";
                // объект для выполнения SQL-запроса
                MySqlCommand commandGetDataUser = new MySqlCommand(queryGetDataUser, conn);
                // объект для чтения ответа сервера
                MySqlDataReader reader = commandGetDataUser.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    AuthClass.auth_id = Convert.ToInt32(reader[0].ToString());
                    AuthClass.auth_fio = reader[3].ToString();
                    AuthClass.auth_role = Convert.ToInt32(reader[6].ToString());
                    AuthClass.auth_role_title = reader[5].ToString();

                }
                reader.Close(); // закрываем reader

                MessageBox.Show($"Авторизация пользователя {loginTXT} успешна.");
                AuthClass.IsAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show($"Авторизация пользователя {loginTXT} не удалась.");
                AuthClass.IsAuthenticated = false;
                Application.Exit();
            }
            conn.Close();

        }
    }
}
