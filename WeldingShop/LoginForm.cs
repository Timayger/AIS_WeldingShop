using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SpecClothes
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Program.userRole = Role.Null;
            Program.userId = 0;
            Program.userName = null;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            AutorizeUser(tbLogin.Text, tbPassword.Text);
        }
        public void AutorizeUser(string login, string password)
        {
            //обновляем фон для полей логина и пароля
            tbLogin.BackColor = Color.White;
            tbPassword.BackColor = Color.White;
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connectionString))
                {
                    conn.Open();//открытие подключения к бд
                    //создание sql команды для получения списка логинов всех пользователей
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE login = '{login}'", conn);
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        //если введенного логина не существует, закрашивается в красный цвет фон поля логина
                        if (!read.HasRows) { tbLogin.BackColor = Color.Red; return; }
                        else { tbLogin.BackColor = Color.White; }
                    }
                    //создание sql команды для проверки пароля
                    SqlCommand cmd2 = new SqlCommand($"SELECT * FROM Users WHERE login = '{login}' " +
                                                     $" AND password = '{password}'", conn);
                    using (SqlDataReader read2 = cmd2.ExecuteReader())
                    {
                        //если введенный пароль не правильный, закрашивается в красный цвет фон поля пароля
                        if (!read2.HasRows) { tbPassword.BackColor = Color.Red; return; }
                        else
                        {
                            tbPassword.BackColor = Color.White;
                            while (read2.Read())//чтение записи и запись полученных значений
                            {
                                Program.userRole = (Role)read2["ID_role"];
                                Program.userId = (int)read2["ID"];
                                Program.userName = login;
                            }
                        }
                    }
                    conn.Close();//закрытие подключения
                }
                this.Close();//закрытие формы авторизации
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSign_MouseEnter(object sender, EventArgs e) => (sender as Button).BackColor = Color.LightBlue;
        private void btnSign_MouseLeave(object sender, EventArgs e) => (sender as Button).BackColor = Color.MediumPurple;
        private void btnSign_MouseClick(object sender, MouseEventArgs e) => (sender as Button).BackColor = Color.White;

    }
}
