using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SpecClothes
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();

            tableOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;           
            OrdersUpdate();
        }

        public void OrdersUpdate()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connectionString))
                {
                    conn.Open();

                    SqlDataAdapter read = new SqlDataAdapter($"SELECT o.ID as 'Номер заказа', p.name as 'Спецодежда', o.count as 'Кол-во', o.datestart as 'Дата начала', o.datefinish as 'Дата поставки', o.ID_status as 'Номер статуса', s.name as ' Статус', CONCAT(u.LastName, ' ', u.FirstName, ' ', u.Patronymic) as 'Заказчик', m.name as 'Поставщик'\r\nFROM Orders as o \r\nLeft join Users as u  On o.ID_client = u.ID Left join Products as p On o.ID_specclothe = p.article Left join Manufacturers as m On p.ID_manufacturer = m.ID \r\nLeft join Statuses as s On o.ID_status = s.ID\r\n" +
                        $"Where o.ID LIKE '{tbOrderNum.Text.Trim()}%' AND CONCAT(u.LastName, ' ', u.FirstName, ' ', u.Patronymic) LIKE '%{tbClient.Text.Trim()}%' AND p.name LIKE '%{tbWear.Text.Trim()}%'", conn);
                    DataTable dt = new DataTable();
                    read.Fill(dt);

                    tableOrders.DataSource = dt;
                    tableOrders.Columns["Номер статуса"].Visible = false;

                    conn.Close();

                }
            }
            catch (SqlException) { }

        }
        public void ConfirmSupply(int orderNum, int orderStatusID)
        {
            //проверяем статус
            if (orderStatusID == 3 || orderStatusID == 4){
                MessageBox.Show("Поставка уже подтверждена", "Подтверждена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (orderStatusID == 5 || orderStatusID == 6){
                MessageBox.Show("Поставка отменена и не можеть быть подтверждена", "Не удалось подтвердить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var result = MessageBox.Show($"Подтвердить поставку спецодежды выбранного заказа (№{orderNum})?", "Подверждение поставки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(Program.connectionString))
                {
                    conn.Open();//открытие подключения к бд
                    //создание sql-команды на изменение даты доставки на текущий и статуса на поступивший
                    SqlCommand cmd = new SqlCommand($"UPDATE Orders SET datefinish = '{DateTime.Now.Date}', ID_status = 3" +
                                                    $" WHERE ID = '{orderNum}';", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();//закрытие подключения
                }
                MessageBox.Show("Поставка подтверждена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrdersUpdate();//обновление таблицы заказов
            }
        }
        public void CancelOrder(int orderNum, int orderStatusID)
        {
            //проверяем статус
            if (orderStatusID == 3 || orderStatusID == 4){
                MessageBox.Show($"Заказ №{orderNum} не может быть отменен, так как он уже получен", "Не удалось отменить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (orderStatusID == 5 || orderStatusID == 6){
                MessageBox.Show($"Заказ №{orderNum} уже отменен", "Отменен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var result = MessageBox.Show($"Отменить выбранный заказ (№{orderNum})?", "Отменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(Program.connectionString))
                {
                    conn.Open();//открытие подключения к бд
                    //создание sql-команды на изменение даты окончания на текущий и статуса на отмененный
                    SqlCommand cmd = new SqlCommand($"UPDATE Orders SET datefinish = '{DateTime.Now.Date}', ID_status = 5 WHERE ID = '{orderNum}';", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();//закрытие подключения 
                }
                MessageBox.Show("Заказ успешно был отменен", "Заказ отменен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrdersUpdate();//обновление таблицы заказов
            }
        }
        private void btnConfirmSupply_Click(object sender, EventArgs e)
        {
            if (tableOrders.SelectedRows.Count <= 0 || tableOrders.CurrentRow is null)
                return;
            var orderNum = Convert.ToInt32(tableOrders.Rows[tableOrders.CurrentRow.Index].Cells["Номер заказа"].Value);
            var orderStatusID = Convert.ToInt32(tableOrders.Rows[tableOrders.CurrentRow.Index].Cells["Номер статуса"].Value);
            ConfirmSupply(orderNum, orderStatusID);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (tableOrders.SelectedRows.Count <= 0 || tableOrders.CurrentRow is null)
                return;
            var orderNum = Convert.ToInt32(tableOrders.Rows[tableOrders.CurrentRow.Index].Cells["Номер заказа"].Value.ToString());
            var orderStatusID = Convert.ToInt32(tableOrders.Rows[tableOrders.CurrentRow.Index].Cells["Номер статуса"].Value);
            CancelOrder(orderNum, orderStatusID);
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (tbClient.Text.Contains('\'') || tbClient.Text.Contains('%'))
                tableOrders.DataSource = null;
            else OrdersUpdate();

        }
        private void btnExit_Click(object sender, EventArgs e) => this.Close();


    }
}
