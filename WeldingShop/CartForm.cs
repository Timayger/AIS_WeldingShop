using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace SpecClothes
{
    public partial class CartForm : Form
    {
        public List<WearViewItem> pastCheckedWears = new List<WearViewItem>(); 
        public CartForm()
        {
            InitializeComponent();

            lvProductsInCart.Columns[0].Width = Convert.ToInt32(lvProductsInCart.Width / 2);
            lvProductsInCart.Columns[1].Width = Convert.ToInt32(lvProductsInCart.Width / 8);
            lvProductsInCart.Columns[2].Width = Convert.ToInt32(lvProductsInCart.Width / 8);
            lvProductsInCart.Columns[3].Width = Convert.ToInt32(lvProductsInCart.Width / 6);
            cartUpdate();
            InfoUpdate();

        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnSend.Enabled = false;
        }
        private void InfoUpdate()
        {
            decimal total_sum = 0;
            decimal total_discount = 0;
            decimal total_cost = 0;
            foreach (WearViewItem wear in lvProductsInCart.Items)
            {
                if (wear is null) continue;
                total_sum += wear.price * wear.count * (1 - wear.discount / 100);
                if (wear.Checked)
                {
                    total_discount += wear.price * wear.count * (wear.discount / 100);
                    total_cost += wear.price * wear.count * (1 - wear.discount / 100);
                }
            }
            l_Sum.Text = total_sum + " руб.";
            l_Discount.Text = $"- {total_discount} руб.";
            l_TotalCost.Text = total_cost + " руб.";
        }
        private void cartUpdate()
        {
            lvProductsInCart.Items.Clear();

            var conn = new SqlConnection(Program.connectionString);
            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"SELECT  p.*, s.ID as ID_size, s.name as size, m.ID as ID_manufacturer, m.name as manufacturer, cart.count as count FROM ProductsInCart as cart \r\nLeft join Users as c \r\nOn cart.ID_client = c.ID \r\nLeft join Products as p \r\nOn cart.ID_product = p.article \r\nLeft join Sizes as s \r\nOn cart.ID_size = s.ID\r\nLeft join Manufacturers as m  On p.ID_manufacturer = m.ID Where c.ID = '{Program.userId}';", conn);
                SqlDataReader read = cmd.ExecuteReader();

                using (read) 
                    while (read.Read())
                    {
                        var wear = new WearViewItem()
                        {
                            article = (string)read["article"],
                            name = (string)read["name"],
                            ID_size = (int)read["ID_size"],
                            size = (string)read["size"],
                            type = (string)read["type"],
                            price = (decimal)read["price"],
                            discount = (int)read["discount"],
                            ID_manufacturer = (int)read["ID_manufacturer"],
                            manufacturer = (string)read["manufacturer"],
                            count = (int)read["count"]

                        };
                        lvProductsInCart.Items.Add(wear);
                    }

                conn.Close();

                // Получение списка элементов из ListView
                var listProducts = new List<WearViewItem>();
                for (int i = 0; i < lvProductsInCart.Items.Count; i++)
                    listProducts.Add(lvProductsInCart.Items[i] as WearViewItem);

                // Группировка по Id и сложение Count
                var groupedProducts = listProducts
                    .GroupBy(p => new { p.article, p.ID_size })
                    .Select(g => new WearViewItem()
                    {
                        ID_size = g.Key.ID_size,
                        article = g.Key.article,
                        size = g.First().size,
                        name = g.First().name,
                        price = g.First().price,
                        discount = g.First().discount,
                        type = g.First().type,
                        ID_manufacturer = g.First().ID_manufacturer,
                        manufacturer = g.First().manufacturer,
                        count = g.Sum(p => p.count),
                    })
                    .ToList();

                lvProductsInCart.Items.Clear();
                for (int i = 0; i < groupedProducts.Count; i++)
                {
                    var wear = groupedProducts[i];
                    wear.SubItems.Add("colName");
                    wear.SubItems.Add("colSize");
                    wear.SubItems.Add("colCount");
                    wear.SubItems.Add("colCost");
                    lvProductsInCart.Items.Add(wear);
                    lvProductsInCart.Items[i].SubItems[0].Text = wear.name;
                    lvProductsInCart.Items[i].SubItems[1].Text = wear.size;
                    lvProductsInCart.Items[i].SubItems[2].Text = wear.count.ToString();
                    lvProductsInCart.Items[i].SubItems[3].Text = Convert.ToString(wear.price * (1 - wear.discount / 100)); ;
                }
            }
        }
        public void CreateOrderAndNotifySupplier()
        {
            for (int i = 0; i < lvProductsInCart.CheckedItems.Count; i++)//итерация выбранных спецодежд
            {
                var wear = (lvProductsInCart.CheckedItems[i] as WearViewItem);
                using (var conn = new SqlConnection(Program.connectionString))
                {
                    conn.Open();//открытие подключения к бд
                    //создание sql-команды на добавление заказа спецодежды и удаление из корзины
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Orders (ID_client, ID_specclothe, ID_size, count, datestart, datefinish, ID_status) " +
                        $"VALUES('{Program.userId}','{wear.article}', {wear.ID_size},'{wear.count}','{DateTime.Now.Date}', NULL,'1'); " +
                        $"DELETE ProductsInCart WHERE ID_client = '{Program.userId}' AND ID_product = '{wear.article}' AND ID_size = '{wear.ID_size}';", conn);
                    cmd.ExecuteNonQuery();//выполнение команды                    
                    conn.Close();//закрытие подключения
                }
                Request.Send(wear.manufacturer);//отправка заявки поставщику
            }
            MessageBox.Show("Заказ создан и заявка на закупку отправлена поставщику", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cartUpdate();//обновление списка спецодежд
        }

        public void DeleteCheckedWears()
        {
            try
            {
                string script_del = $" DELETE ProductsInCart Where ID_client = '{Program.userId}' and ";
                string script_minus = $" UPDATE ProductsInCart SET count = count-1 Where ID_client = '{Program.userId}' and ";

                string full_script = "";
                var listWears = new List<WearViewItem>();
                foreach (WearViewItem wear in lvProductsInCart.CheckedItems)
                {
                    listWears.Add(wear);
                    pastCheckedWears.Add(wear);
                }
                var listWearsForDelete = listWears.Where(wear => wear.count <= 1).ToList();
                var listWearsForUpdate = listWears.Where(wear => wear.count > 1).ToList();

                if (listWearsForDelete.Count > 0)
                {
                    full_script += script_del;
                    for (int i = 0; i < listWearsForDelete.Count; i++)
                    {
                        var wear = listWearsForDelete[i];
                        if (i + 1 >= listWearsForDelete.Count)
                            full_script += $"ID_product = '{wear.article}' and ID_size = '{wear.ID_size}'; ";
                        else full_script += $"ID_product = '{wear.article}' and ID_size = '{wear.ID_size}' or ";

                    }
                }
                if (listWearsForUpdate.Count > 0)
                {
                    full_script += script_minus;
                    for (int i = 0; i < listWearsForUpdate.Count; i++)
                    {
                        var wear = listWearsForUpdate[i];
                        if (i + 1 >= listWearsForUpdate.Count)
                            full_script += $"ID_product = '{wear.article}' and ID_size = '{wear.ID_size}'; ";
                        else full_script += $"ID_product = '{wear.article}' and ID_size = '{wear.ID_size}' or ";
                    }
                }

                using (var conn = new SqlConnection(Program.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(full_script, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                cartUpdate();
                foreach (WearViewItem wear in lvProductsInCart.Items)
                    if (pastCheckedWears.Contains(wear))
                        wear.Checked = true;
                pastCheckedWears.Clear();
            }
            catch (SqlException ex)
            {
            }
        }
        private void btnSend_Click(object sender, EventArgs e) => CreateOrderAndNotifySupplier();
        private void btnDelete_Click(object sender, EventArgs e) => DeleteCheckedWears();
        private void btnExit_Click(object sender, EventArgs e) => this.Close();
        private void lbProducts_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvProductsInCart.CheckedItems.Count > 0)
            {
                btnDelete.Enabled = true;
                btnSend.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnSend.Enabled = false;
            }
            
            InfoUpdate();
        }
        private void lvProductsInCart_MouseClick(object sender, MouseEventArgs e)
        {
            for (int itemIndex = 0; itemIndex < lvProductsInCart.Items.Count; itemIndex++)
            {
                WearViewItem product = lvProductsInCart.Items[itemIndex] as WearViewItem;
                Rectangle itemRect = product.GetBounds(ItemBoundsPortion.Label);
                if (itemRect.Contains(e.Location))
                {
                    product.Checked = !product.Checked;
                    break;
                }
            }

        }
        private void lvProductsInCart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int itemIndex = 0; itemIndex < lvProductsInCart.Items.Count; itemIndex++)
            {
                WearViewItem product = lvProductsInCart.Items[itemIndex] as WearViewItem;
                Rectangle itemRect = product.GetBounds(ItemBoundsPortion.Label);
                if (itemRect.Contains(e.Location))
                {
                    string text = $"Название товара: {product.name}\n" +
                                  $"Артикль: {product.article}\n" +
                                  $"Размер: {product.size}\n" +
                                  $"Тип: {product.type}\n" +
                                  $"Кол-во: {product.count}\n" +
                                  $"Цена: {product.price} руб.\n" +
                                  $"Скидка: {product.discount} %\n" +
                                  $"Итого: {(product.price * product.count) * (1 - product.discount/100)} руб.\n" +
                                  $"Поставщик: {product.manufacturer}\n";
                    var result = MessageBox.Show(text, "Информация о товаре", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    break;
                }
            }
        }

    }
}
