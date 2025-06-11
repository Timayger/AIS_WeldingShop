using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SpecClothes
{
    public partial class WearsForm : Form
    {
        public Dictionary<int, string> Sizes = new Dictionary<int, string>();
        public Dictionary<string, string> SizesOfEmployees = new Dictionary<string, string>();
        public WearsForm()
        {
            InitializeComponent();

            tableProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WearsUpdate();
            ComboBoxesUpdate();
            
        }

        public void WearsUpdate()
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();//открытие подключения к бд
                //создание sql-запроса на вывод таблицы спецодежд
                SqlDataAdapter read = new SqlDataAdapter($"SELECT p.article as 'Артикль', p.name as 'Товар', p.type as 'Тип', p.price as 'Цена', p.discount as 'Скидка', m.name as 'Поставщик' " +
                    $"FROM Products as p\r\nLeft join Manufacturers as m \r\nOn p.ID_manufacturer = m.ID\r\n" +
                    $"Where p.name LIKE '%{tbWearName.Text.Trim()}%' AND p.type LIKE '%{tbType.Text.Trim()}%'", conn);
                DataTable dt = new DataTable();//создание экземпляра таблицы
                read.Fill(dt);//заполнение таблицы данными
                tableProducts.DataSource = dt;//заполнение таблицы спецодежд данными
                conn.Close();//закрытие подключения
            }
        }
        public void ComboBoxesUpdate()
        {
            Sizes.Clear();
            SizesOfEmployees.Clear();
            checkListEmployees.Items.Clear();
            cbSize.Items.Clear();

            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"SELECT name FROM Sizes", conn);
                SqlDataReader read = cmd.ExecuteReader();

                using(read)
                {
                    int c = 1;
                    while (read.Read())
                    {
                        var size = (string)read["name"];
                        Sizes.Add(c++, size);
                        cbSize.Items.Add(size);
                    }
                }

                SqlCommand cmd2 = new SqlCommand($"SELECT CONCAT(u.LastName, ' ', u.FirstName, ' ', u.Patronymic) as worker, s.name as size FROM Users u LEFT JOIN Sizes s ON s.ID = u.ID_size WHERE u.ID_role = 4;", conn);
                SqlDataReader read2 = cmd2.ExecuteReader();

                using (read2)
                {
                    while (read2.Read())
                    {
                        var emp = (string)read2["worker"];
                        var size = (string)read2["size"];
                        SizesOfEmployees.Add(emp, size);
                        checkListEmployees.Items.Add(emp);
                    }
                }

                conn.Close();
            }

            cbSize.Text = "M";
        }
        private void checkListEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkListEmployees.SetItemChecked(checkListEmployees.SelectedIndex, !checkListEmployees.GetItemChecked(checkListEmployees.SelectedIndex));            
            cbSize.Enabled = false;
            if (checkListEmployees.CheckedItems.Count == 0)
            {
                cbSize.Text = "M";
                cbSize.Enabled = true;
            }
            else if (checkListEmployees.CheckedItems.Count == 1)
                cbSize.Text = SizesOfEmployees.First(key => key.Key == checkListEmployees.CheckedItems[0]).Value;
            else
                cbSize.Text = "...";

        }
        private void tbWearName_TextChanged(object sender, EventArgs e)
        {
            if (tbWearName.Text.Contains('\'') || tbWearName.Text.Contains('%'))
                tableProducts.DataSource = null;
            else WearsUpdate();
        }
        private void tbType_TextChanged(object sender, EventArgs e)
        {
            if (tbType.Text.Contains('\'') || tbType.Text.Contains('%'))
                tableProducts.DataSource = null;
            else WearsUpdate();
        }
        private void btnAddInCart_Click(object sender, EventArgs e)
        {
            if (tableProducts.CurrentRow is null)
                return;
            
            int id_client = Program.userId;
            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();
                string article = tableProducts.Rows[tableProducts.CurrentRow.Index].Cells[0].Value.ToString();
                var read1 = new SqlCommand($"Select p.article from Products as p where p.article = '{article}'", conn).ExecuteReader();
                using(read1)
                    while (read1.Read())
                        article = (string)read1["article"];

                if (article == ""){
                    MessageBox.Show("Не удаётся добавить товар в корзину", "Операция не удалась", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (checkListEmployees.CheckedItems.Count <= 1){
                    if (!Sizes.Values.Contains(cbSize.Text)){
                        MessageBox.Show("Указан некорректный размер.\nВыберите из списка соответсвующий размер", "Некорректность размера", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    int id_size = Sizes.First(s => s.Value == cbSize.Text).Key;
                    AddInCart(article, id_size, (int)numericKolvo.Value, conn);
                }
                else
                {
                    var sorted_sizes = new Dictionary<string, int>();
                    for (int i = 0; i < checkListEmployees.CheckedItems.Count; i++)
                    {
                        var checked_emp = checkListEmployees.CheckedItems[i].ToString();
                        var size = SizesOfEmployees.First(emp => emp.Key == checked_emp).Value;
                        if (!sorted_sizes.Keys.Contains(size))
                            sorted_sizes.Add(size, 1);
                        else
                            sorted_sizes[size]++;
                    }
                    foreach (KeyValuePair<string, int> size in sorted_sizes)
                    {
                        var id_size = Sizes.First(s => s.Value == size.Key).Key;
                        var count = size.Value * numericKolvo.Value;
                        AddInCart(article, id_size, (int)count, conn);
                    }
                }

                var result = MessageBox.Show("Перейти к просмотру товаров в корзине?", "Переход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    new CartForm().ShowDialog();

                conn.Close();
            }
            
        }
        public void AddInCart(string article, int id_size, int count, SqlConnection conn)
        {
            var id_client = Program.userId;
            //создание reader для получения кол-ва указанной спецодежды
            SqlDataReader read2 = new SqlCommand($"SELECT count FROM ProductsInCart WHERE ID_client = '{id_client}' and ID_product = '{article}' and ID_size = '{id_size}';", conn)
                .ExecuteReader();
            int sum = Convert.ToInt32(numericKolvo.Value);
            using (read2)
                while (read2.Read())//чтение каждой строки и суммирование
                    sum += (int)read2["count"];
            SqlCommand sqlcommand;
            //если сумма получилась больше указанной, то создается sql-команда на изменение значения count на sum,
            //иначе на добавление новой
            if (sum > numericKolvo.Value)
                sqlcommand = new SqlCommand($"UPDATE ProductsInCart SET count = '{sum}' WHERE ID_client = '{id_client}' and ID_product = '{article}' and ID_size = '{id_size}';", conn);
            else
                sqlcommand = new SqlCommand($"INSERT INTO ProductsInCart (ID_client, ID_product, ID_size, count) VALUES ('{id_client}', '{article}', '{id_size}', '{count}');", conn);
            sqlcommand.ExecuteNonQuery();//выполнение sql-команды
        }
        private void btnUncheckEmps_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkListEmployees.Items.Count; i++)
                checkListEmployees.SetItemChecked(i, false);
            cbSize.Text = "M";
            cbSize.Enabled = true;
        }
        private void btnExit_Click(object sender, EventArgs e) => this.Close();


    }
}
