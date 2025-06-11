using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SpecClothes
{
    public partial class EmployeesForm : Form
    {
        public List<Employee> Employees = new List<Employee>();
        public EmployeesForm()
        {
            InitializeComponent();

            tableEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableEmployees.AllowUserToAddRows = false;

            EmployeesUpdate();
        }
        private void tbFindEmployee_TextChanged(object sender, EventArgs e)
        {
            if (tbFindEmployee.Text.Contains('\'') || tbFindEmployee.Text.Contains('%'))
                tableEmployees.DataSource = null;
            else EmployeesUpdate();
        }

        public void EmployeesUpdate()
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();
                string script = $"SELECT emp.ID, emp.LastName as 'Фамилия', emp.FirstName as 'Имя', emp.Patronymic as 'Отчество', r.ID as ID_role, s.ID as ID_size, r.name as 'Должность', CONCAT(s.name, ' (', s.value, ')') as 'Размер одежды', emp.email as 'E-mail', emp.phone as 'Телефон', emp.dateofbirth as 'Дата рождения', emp.login as 'Логин', emp.password as 'Пароль' FROM Users emp " +
                    $"LEFT JOIN Roles r ON r.ID = emp.ID_role " +
                    $"LEFT JOIN Sizes s ON s.ID = emp.ID_size " +
                    $"Where CONCAT(emp.LastName, ' ', emp.FirstName, ' ', emp.Patronymic) LIKE '%{tbFindEmployee.Text.Trim()}%' Order by r.ID ASC;";
                SqlDataAdapter read_dt = new SqlDataAdapter(script, conn);
                DataTable dt = new DataTable();
                read_dt.Fill(dt);
                tableEmployees.DataSource = dt;
                tableEmployees.Columns["ID"].Visible = false;
                tableEmployees.Columns["ID_role"].Visible = false;
                tableEmployees.Columns["ID_size"].Visible = false;
                using (var cmd =  new SqlCommand(script, conn))
                {
                    var read = cmd.ExecuteReader();
                    Employees.Clear();
                    using (read) 
                        while (read.Read())
                        {
                            var employee = new Employee(
                                (int)read["ID"],
                                (string)read["Фамилия"],
                                (string)read["Имя"],
                                (string)read["Отчество"],
                                (int)read["ID_role"],
                                (int)read["ID_size"],
                                (string)read["E-mail"],
                                (string)read["Телефон"],
                                (DateTime)read["Дата рождения"],
                                (string)read["Логин"],
                                (string)read["Пароль"]

                                );
                            employee.roleName = (string)read["Должность"];
                            employee.sizeName = ((string)read["Размер одежды"]).Split(' ')[0];
                            Employees.Add(employee);
                        }
                }

                conn.Close();

            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var form = new ControlEmployeeForm();
            form.ShowDialog();
            if (!form.isCanceled) EmployeesUpdate();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (tableEmployees.SelectedRows.Count <= 0 || tableEmployees.CurrentRow is null)
                return;
            int ID_emp = Convert.ToInt32(tableEmployees.Rows[tableEmployees.CurrentRow.Index].Cells["ID"].Value);
            var edit_employee = Employees.First(emp => emp.ID == ID_emp);

            var form = new ControlEmployeeForm(edit_employee);
            form.ShowDialog();
            if(!form.isCanceled) EmployeesUpdate();

        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }
        public void DeleteEmployee()
        {
            if (tableEmployees.SelectedRows.Count <= 0 || tableEmployees.CurrentRow is null)
                return;//завершить работу, если сотрудник из таблицы не был выбран
            //сохранить в переменную ID выбранного сотрудника из таблицы
            int ID_emp = Convert.ToInt32(tableEmployees.Rows[tableEmployees.CurrentRow.Index].Cells["ID"].Value);
            var delete_employee = Employees.First(emp => emp.ID == ID_emp);//найденный для удаления сотрудник

            var result = MessageBox.Show($"Удалить сотрудника '{delete_employee.LastName} {delete_employee.FirstName[0]}. {delete_employee.Patronymic[0]}.'?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ; ;
            if (result == DialogResult.No)
                return;
            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();//открытие подключения к бд
                using (SqlCommand cmd = new SqlCommand($"DELETE Users Where ID = '{ID_emp}'", conn))
                {
                    cmd.ExecuteNonQuery();//выполнение sql-запроса на удаление
                    MessageBox.Show("Сотрудник удален", "Удален", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();//закрытие подключения
            }
            EmployeesUpdate();//обновление таблицы сотрудников
        }
        private void btnExit_Click(object sender, EventArgs e) => this.Close();

    }
}
