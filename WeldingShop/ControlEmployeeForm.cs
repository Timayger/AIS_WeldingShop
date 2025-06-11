using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SpecClothes
{
    public partial class ControlEmployeeForm : Form
    {
        public Employee EditEmployee;
        public Dictionary<int, string> Roles = new Dictionary<int, string>();
        public Dictionary<int, string> Sizes = new Dictionary<int, string>();
        public bool isCanceled = false;
        public ControlEmployeeForm(Employee employee = null)
        {
            InitializeComponent();

            ComboBoxesUpdate();

            EditEmployee = employee;
            if (EditEmployee is null)
            {
                this.Text = "Добавление сотрудника";
                gbMain.Text = "Добавление нового сотрудника";
                btnSaveEmployee.Text = "Добавить";
            }
            else
            {
                this.Text = "Редактирование сотрудника";
                gbMain.Text = $"Редактирование сотрудника '{EditEmployee.LastName} {EditEmployee.FirstName} {EditEmployee.Patronymic}'";
                btnSaveEmployee.Text = "Сохранить";

                tbLastName.Text = employee.LastName;
                tbFirstName.Text = employee.FirstName;
                tbPatronymic.Text = employee.Patronymic;
                cbRole.Text = employee.roleName;
                cbSize.Text = employee.sizeName;
                tbEmail.Text = employee.Email;
                tbPhone.Text = employee.Phone;
                dtpBirthdate.Value = employee.Birthdate;
                tbLogin.Text = employee.Login;
                tbPassword.Text = employee.Password;

            }
        }
        private void ComboBoxesUpdate()
        {
            cbRole.Items.Clear();
            cbSize.Items.Clear();

            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter ms_data_roles = new SqlDataAdapter($"SELECT ID, name FROM Roles", conn);
                DataTable table_roles = new DataTable();
                ms_data_roles.Fill(table_roles);
                foreach (DataRow row in table_roles.Rows)
                {
                    Roles.Add((int)row.ItemArray[0], (string)row.ItemArray[1]);
                    cbRole.Items.Add(row.ItemArray[1]);
                }

                SqlDataAdapter ms_data_sizes = new SqlDataAdapter($"SELECT ID, name FROM Sizes", conn);
                DataTable table_sizes = new DataTable();
                ms_data_sizes.Fill(table_sizes);
                foreach (DataRow row in table_sizes.Rows)
                {
                    Sizes.Add((int)row.ItemArray[0], (string)row.ItemArray[1]);
                    cbSize.Items.Add(row.ItemArray[1]);
                }
            }
        }
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            SaveEmployee();
        }
        public void SaveEmployee()
        {
            //заполнение переменных значениями из полей
            string script = "";
            var last_name = tbLastName.Text.Trim();
            var first_name = tbFirstName.Text.Trim();
            var patronymic = tbPatronymic.Text.Trim();
            var id_role = Roles.First(r => r.Value == cbRole.Text).Key;
            var id_size = Sizes.First(r => r.Value == cbSize.Text).Key;
            var email = tbEmail.Text.Trim();
            var phone = tbPhone.Text.Trim();
            var dateofbirth = dtpBirthdate.Value;
            var login = tbLogin.Text.Trim();
            var password = tbPassword.Text.Trim();

            //если форма для добавления, то создается sql-запрос на добавление, иначе на редактирование
            if (EditEmployee is null)
                script = $"INSERT INTO Users VALUES('{last_name}', '{first_name}', '{patronymic}', '{id_role}','{id_size}','{email}','{phone}','{dateofbirth}','{login}','{password}');";
            else
                script = $"UPDATE Users SET " +
                    $"LastName = '{last_name}', " +
                    $"FirstName = '{first_name}', " +
                    $"Patronymic = '{patronymic}', " +
                    $"ID_role = '{id_role}', " +
                    $"ID_size = '{id_size}', " +
                    $"email = '{email}', " +
                    $"phone = '{phone}', " +
                    $"dateofbirth = '{dateofbirth}', " +
                    $"login = '{login}', " +
                    $"password = '{password}' " +
                    $"Where ID = '{EditEmployee.ID}';";

            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();//открытие подключения к бд
                using (var cmd = new SqlCommand(script, conn))
                    cmd.ExecuteNonQuery();//выполнение команды
                conn.Close();//закрытие подключения
            }
            //если форма для добавления, то создается выводится сообщение о добавлении, иначе о отредактировании
            if (EditEmployee is null)
                MessageBox.Show("Новый сотрудник добавлен", "Добавлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Данные сотрудника отредактированы", "Отредактирован", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();//закрытие формы
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            isCanceled = true;
            this.Close();
        }

    }
}
