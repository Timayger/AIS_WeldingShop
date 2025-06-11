using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SpecClothes
{
    public partial class SkladsForm : Form
    {
        public bool isMoving = false;
        public SkladView StartSklad;
        public SkladView FinishSklad;
        public System.Data.DataTable DTofMovedWearsForReport = new System.Data.DataTable();
        public System.Data.DataTable DTofAddedWearsForReport = new System.Data.DataTable();

        public SkladsForm()
        {
            InitializeComponent();
        }
        private void SkladsForm_Load(object sender, EventArgs e)
        {
            lvWearsStart.Columns[0].Width = Convert.ToInt32(lvWearsStart.Width / 1.5);
            lvWearsStart.Columns[1].Width = Convert.ToInt32(lvWearsStart.Width / 3);
            lvWearsFinish.Columns[0].Width = Convert.ToInt32(lvWearsFinish.Width / 1.5);
            lvWearsFinish.Columns[1].Width = Convert.ToInt32(lvWearsFinish.Width / 3);
            lvWearsNonInSklad.Columns[0].Width = Convert.ToInt32(lvWearsFinish.Width / 1.5);
            lvWearsNonInSklad.Columns[1].Width = Convert.ToInt32(lvWearsFinish.Width / 3);
            tlpStart.Visible = false;
            tlpFinish.Visible = false;
            btnMoveToSklad.Enabled = false;
            btnMoveToSkladNon.Enabled = false;

            lStartNum.Text = String.Empty;
            lFinishNum.Text = String.Empty;

            DTofMovedWearsForReport.Columns.Add("Спецодежда");
            DTofMovedWearsForReport.Columns.Add("Исходный склад");
            DTofMovedWearsForReport.Columns.Add("Целевой склад"); 
            DTofMovedWearsForReport.Columns.Add("Количество");
            DTofMovedWearsForReport.Columns.Add("Дата");

            DTofAddedWearsForReport.Columns.Add("Спецодежда");
            DTofAddedWearsForReport.Columns.Add("Склад");
            DTofAddedWearsForReport.Columns.Add("Количество");
            DTofAddedWearsForReport.Columns.Add("Дата");

            SkladsUpdate();
            WearsUpdate();
        }
        private void Sklad_Click(object sender, EventArgs e)
        {
            var selectedSklad = sender as SkladView;
            if (lvWearsStart.Items.Count <= 0 || lvWearsStart.CheckedItems.Count <= 0)
            {
                //значит не перемещение и просто обновляем список содержимого выбранного склада, который по-умолчанию исходный, а целевой, если открыт, скрываем
                tlpStart.Visible = true;
                lvWearsStart.Items.Clear();
                StartSklad = selectedSklad;
                lStartNum.Text = "Исходный склад №" + StartSklad.number;

                tlpFinish.Visible = false;
                FinishSklad = null;
                lFinishNum.Text = String.Empty;
                btnMoveToSklad.Enabled = false;

                ContentOfSkladUpdate(lvWearsStart);
            }
            else if (lvWearsStart.CheckedItems.Count > 0 && selectedSklad.number != StartSklad.number)
            {
                //значит перемещение и обновляем список содержимого выбранного склада как целевой
                tlpFinish.Visible = true;
                lvWearsFinish.Items.Clear();
                FinishSklad = selectedSklad;
                lFinishNum.Text = "Целевой склад №" + FinishSklad.number;
                btnMoveToSklad.Enabled = true;

                ContentOfSkladUpdate(lvWearsFinish);
            }
            lvWearsNonInSklad_WearChecked(sender, new ItemCheckedEventArgs(new ListViewItem()));
        }
        public void ContentOfSkladUpdate(ListView lv)
        {
            IEnumerable<WearViewItem> wears;
            if (lv == lvWearsStart)
                wears = GetListContentOfSklad(StartSklad);
            else if (lv == lvWearsFinish)
                wears = GetListContentOfSklad(FinishSklad);
            else return;

            lv.Items.Clear();
            foreach (WearViewItem wear in wears)
                lv.Items.Add(wear);
            for (int i = 0; i < lv.Items.Count; i++)
            {
                var item = lv.Items[i] as WearViewItem;
                item.SubItems.Add("colName");
                item.SubItems.Add("colCount");
                lv.Items[i].SubItems[0].Text = item.name;
                lv.Items[i].SubItems[1].Text = item.count.ToString();
            }
        }
        private void SkladsUpdate()
        {
            flpSklads.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM Sklads WHERE number LIKE '%{tbSkladNum.Text.Trim()}%';", conn);
                SqlDataReader read = cmd.ExecuteReader();

                using (read)
                {
                    while (read.Read())
                    {
                        SkladView sklad = new SkladView()
                        {
                            ID = (int)read["ID"],
                            number = (int)read["number"],
                            address = (string)read["address"],
                        };
                        sklad.AutoSize = true;
                        sklad.Text = "№ " + sklad.number;
                        sklad.Click += Sklad_Click;
                        flpSklads.Controls.Add(sklad);
                    }
                }

                conn.Close();

            }
        }
        private IEnumerable<WearViewItem> GetListContentOfSklad(SkladView sklad)
        {
            string wear_name = "";
            if (sklad == StartSklad)
                wear_name = tbWearOfStart.Text.Trim();
            else if (sklad == FinishSklad)
                wear_name = tbWearOfFinish.Text.Trim();

            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"SELECT p.article, CONCAT(p.name, ' ', s.name) as name, content.ID_size, s.name as size, content.count, p.type, m.name as manufacturer FROM ContentSklads content " +
                                                $"LEFT JOIN Sklads sk ON sk.ID = content.ID_sklad " +
                                                $"LEFT JOIN Products p ON p.article = content.ID_clothe " +
                                                $"LEFT JOIN Sizes s ON s.ID = content.ID_size " +
                                                $"LEFT JOIN Manufacturers m ON p.ID_manufacturer = m.ID " +
                                                $"Where sk.number = '{sklad.number}' AND CONCAT(p.name, ' ', s.name) LIKE '%{wear_name}%';", conn);
                SqlDataReader read = cmd.ExecuteReader();
                using (read)
                {
                    while (read.Read())
                    {
                        WearViewItem wear = new WearViewItem()
                        {
                            article = (string)read["article"],
                            name = (string)read["name"],
                            type = (string)read["type"],
                            ID_size = (int)read["ID_size"],
                            size = (string)read["size"],
                            manufacturer = (string)read["manufacturer"],
                            count = (int)read["count"],
                        };
                        
                        yield return wear;
                    }
                }
                conn.Close();
            }
        }
        private void WearsUpdate()
        {
            lvWearsNonInSklad.Items.Clear();

            using (var conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"SELECT o.ID as ID_order, p.article, CONCAT(p.name, ' ', s.name) as name, s.ID as ID_size, s.name as size, SUM(o.count) as count, p.type FROM Orders o " +
                                                $"LEFT JOIN Products p ON p.article = o.ID_specclothe " +
                                                $"LEFT JOIN Sizes s ON s.ID = o.ID_size " +
                                                $"LEFT JOIN Manufacturers m ON p.ID_manufacturer = m.ID " +
                                                $"WHERE o.ID_status = 3 " +
                                                $"GROUP BY o.ID, p.article, CONCAT(p.name, ' ', s.name), p.type, s.ID, s.name", conn);
                SqlDataReader read = cmd.ExecuteReader();

                int c = 0;
                using (read)
                    while (read.Read())
                    {
                        var wear = new WearViewItem()
                        {
                            ID_order = (int)read["ID_order"],
                            article = (string)read["article"],
                            name = (string)read["name"],
                            ID_size = (int)read["ID_size"],
                            size = (string)read["size"],
                            count = (int)read["count"],
                            type = (string)read["type"],
                        };
                        lvWearsNonInSklad.Items.Add(wear);
                        wear.SubItems.Add("colNameNon");
                        wear.SubItems.Add("colCountNon");
                        lvWearsNonInSklad.Items[c].SubItems[0].Text = wear.name;
                        lvWearsNonInSklad.Items[c++].SubItems[1].Text = wear.count.ToString();
                    }

                conn.Close();

            }
            var lv = lvWearsNonInSklad;

            for (int i = 0; i < lv.Items.Count; i++)
            {
                var item = lv.Items[i] as WearViewItem;
                item.SubItems.Add("colName");
                item.SubItems.Add("colCount");
                lv.Items[i].SubItems[0].Text = item.name;
                lv.Items[i].SubItems[1].Text = item.count.ToString();
            }

        }
        private void lvWearsNonInSklad_WearChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvWearsNonInSklad.CheckedItems.Count > 0 && StartSklad !=  null)
                btnMoveToSkladNon.Enabled = true;
            else btnMoveToSkladNon.Enabled = false;
        }
        private void btnMoveToSkladNon_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();

                foreach (WearViewItem check_wear in lvWearsNonInSklad.CheckedItems)
                {
                    var read = new SqlCommand($"SELECT count FROM ContentSklads WHERE ID_sklad = '{StartSklad.ID}' and ID_clothe = '{check_wear.article}' and ID_size = '{check_wear.ID_size}';", conn).ExecuteReader();
                    int sum = check_wear.count;
                    using (read)
                        while (read.Read())
                            sum += (int)read["count"];

                    lvWearsNonInSklad.Items.Remove(check_wear);

                    SqlCommand sqlcommand;
                    if (sum > check_wear.count)
                        sqlcommand = new SqlCommand($"UPDATE ContentSklads SET count = '{sum}' WHERE ID_sklad = '{StartSklad.ID}' and ID_clothe = '{check_wear.article}' and ID_size = '{check_wear.ID_size}';", conn);
                    else
                        sqlcommand = new SqlCommand($"INSERT INTO ContentSklads (ID_sklad, ID_clothe, ID_size, count) VALUES ('{StartSklad.ID}', '{check_wear.article}', '{check_wear.ID_size}', '{sum}');", conn);
                    using (sqlcommand) sqlcommand.ExecuteNonQuery();

                    using (SqlCommand cmd_change_order_status = new SqlCommand($"UPDATE Orders SET ID_status = 4 Where ID = '{check_wear.ID_order}';", conn))
                        cmd_change_order_status.ExecuteNonQuery();

                    DTofAddedWearsForReport.Rows.Add(check_wear.name, "№" + StartSklad.number, check_wear.count, DateTime.Now.ToString());

                }
                conn.Close();
            }
            ContentOfSkladUpdate(lvWearsStart);
            btnMoveToSkladNon.Enabled = false;
        }
        private void btnGenerateReport_Click(object sender, EventArgs e) => GenerateReport();
        protected void GenerateReport()
        {
            // создание экземпляра приложения
            Excel.Application excelApp = new Excel.Application();
            // создание экземпляра рабочей книги Excel и списка листов
            Excel.Workbook workBook;
            workBook = excelApp.Workbooks.Add();
            Excel.Sheets xlSheets = workBook.Sheets;
            // создание экземпляра листа Excel в качестве информации о содержимом складов
            Excel.Worksheet workSheetInfo = (Excel.Worksheet)workBook.Worksheets.Add(xlSheets[1]);

            int pos = 1;
            workSheetInfo.Cells[pos, 1] = "Информация о содержимом складов";
            workSheetInfo.get_Range("A" + pos, "C" + pos).Merge();
            workSheetInfo.Cells[pos, 1].Font.Bold = true;
            workSheetInfo.Cells[pos, 1].Font.Size = 15;
            workSheetInfo.Cells[pos, 1].HorizontalAlignment = -4108;
            workSheetInfo.Cells[pos, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.NavajoWhite);
            pos++;
            workSheetInfo.Cells[pos, 1] = "Дата: " + DateTime.Now.ToString();
            pos++;
            workSheetInfo.Cells[pos, 1] = "Спецодежда";
            workSheetInfo.Cells[pos, 2] = "Размер";
            workSheetInfo.Cells[pos, 3] = "Количество";
            for (int i = 0; i < 3; i++)//установка стилей
            {
                workSheetInfo.Cells[pos, i+1].HorizontalAlignment = -4108;
                workSheetInfo.Cells[pos, i+1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheetInfo.Cells[pos, i+1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            }
            pos++;
            for (int j = 0; j < flpSklads.Controls.Count; j++)
            {
                var sklad = flpSklads.Controls[j] as SkladView;
                var content = GetListContentOfSklad(sklad);
                // выделение диапазона ячеек от A до C
                workSheetInfo.get_Range("A" + pos, "C" + pos).Merge();
                workSheetInfo.Cells[pos, 1] = "Склад №" + sklad.number;
                workSheetInfo.Cells[pos, 1].HorizontalAlignment = -4108;
                workSheetInfo.Cells[pos, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.NavajoWhite);
                pos++;
                int sum = 0;
                for (int i = 0; i < content.Count(); i++)
                {
                    var wear = content.ElementAt(i);
                    workSheetInfo.Cells[i + pos, 1] = wear.name;
                    workSheetInfo.Cells[i + pos, 2] = wear.size;
                    workSheetInfo.Cells[i + pos, 3] = wear.count;
                    workSheetInfo.Cells[i + pos, 2].HorizontalAlignment = -4108;
                    workSheetInfo.Cells[i + pos, 3].HorizontalAlignment = -4108;
                    workSheetInfo.Cells[i + pos, 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    workSheetInfo.Cells[i + pos, 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    workSheetInfo.Cells[i + pos, 3].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    sum += wear.count;
                }
                pos += content.Count();
                workSheetInfo.Cells[pos, 3] = "Всего: " + sum;
                workSheetInfo.Cells[pos, 3].HorizontalAlignment = -4108;
                workSheetInfo.Cells[pos, 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
                pos++;
            }
            workSheetInfo.Columns.AutoFit();
            workSheetInfo.Rows.AutoFit();

            // создание экземпляра листа Excel в качестве отчета по проделанной работе
            Excel.Worksheet workSheetReport = (Excel.Worksheet)workBook.Worksheets.Add(xlSheets[2]);
            int pos_ = 1;
            workSheetReport.Cells[pos_, 1] = "Отчет по проделанной работе";
            workSheetReport.get_Range("A" + pos_, "J" + pos_).Merge();
            workSheetReport.Cells[pos_, 1].Font.Size = 15;
            workSheetReport.Cells[pos_, 1].Font.Bold = true;
            workSheetReport.Cells[pos_, 1].HorizontalAlignment = -4108;
            workSheetReport.Cells[pos_, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.NavajoWhite);            
            pos_++;
            workSheetReport.Cells[pos_, 1] = "Дата: " + DateTime.Now.ToString();
            pos_++;
            workSheetReport.Cells[pos_, 1] = "Перемещённые спецодежды";//добавление заголовка
            workSheetReport.get_Range("A" + pos_, "E" + pos_).Merge();
            workSheetReport.Cells[pos_, 1].Font.Bold = true;
            workSheetReport.Cells[pos_, 1].HorizontalAlignment = -4108;
            workSheetReport.Cells[pos_, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
            pos_++;
            workSheetReport.Cells[pos_, 1] = "Спецодежда";
            workSheetReport.Cells[pos_, 2] = "Исходный склад";
            workSheetReport.Cells[pos_, 3] = "Целевой склад";
            workSheetReport.Cells[pos_, 4] = "Количество";
            workSheetReport.Cells[pos_, 5] = "Дата";
            for (int i = 0; i < 5; i++)//установка стилей
            {
                workSheetReport.Cells[pos_, i+1].HorizontalAlignment = -4108;
                workSheetReport.Cells[pos_, i+1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheetReport.Cells[pos_, i+1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            }
            pos_++;
            for (int i = 0; i < DTofMovedWearsForReport.Rows.Count; i++)
                for (int j = 0; j < DTofMovedWearsForReport.Columns.Count; j++)
                {
                    workSheetReport.Cells[i + pos_, j + 1] = DTofMovedWearsForReport.Rows[i][j];
                    workSheetReport.Cells[i + pos_, j + 1].HorizontalAlignment = -4108;
                    workSheetReport.Cells[i + pos_, j + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }

            pos_ = 3;
            int start_pos = 7;
            workSheetReport.Cells[pos_, start_pos] = "Добавленные новые спецодежды";//добавление заголовка
            workSheetReport.get_Range("G" + pos_, "J" + pos_).Merge();
            workSheetReport.Cells[pos_, start_pos].Font.Bold = true;
            workSheetReport.Cells[pos_, start_pos].HorizontalAlignment = -4108;
            workSheetReport.Cells[pos_, start_pos].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
            pos_++;
            workSheetReport.Cells[pos_, start_pos] = "Спецодежда";
            workSheetReport.Cells[pos_, start_pos+1] = "Склад";
            workSheetReport.Cells[pos_, start_pos+2] = "Количество";
            workSheetReport.Cells[pos_, start_pos+3] = "Дата";
            for (int i = 0; i < 4; i++)//установка стилей
            {
                workSheetReport.Cells[pos_, start_pos + i].HorizontalAlignment = -4108;
                workSheetReport.Cells[pos_, start_pos + i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheetReport.Cells[pos_, start_pos + i].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            }
            pos_++;
            for (int i = 0; i < DTofAddedWearsForReport.Rows.Count; i++)
                for (int j = 0; j < DTofAddedWearsForReport.Columns.Count; j++)
                {
                    workSheetReport.Cells[i + pos_, start_pos + j] = DTofAddedWearsForReport.Rows[i][j];
                    workSheetReport.Cells[i + pos_, start_pos + j].HorizontalAlignment = -4108;
                    workSheetReport.Cells[i + pos_, start_pos + j].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }

            workSheetReport.Columns.AutoFit();
            workSheetReport.Rows.AutoFit();

            // открытие созданной excel-файла
            excelApp.Visible = true;
            excelApp.UserControl = true;
            try{
                //сохранение файла            
                workBook.Save();
            }
            catch{}

        }
        public void MoveToSklad()
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();//открытие подключения к бд
                foreach (WearViewItem check_wear in lvWearsStart.CheckedItems)//итерация списка спецодежды
                {
                    //создание SqlDataReader sql-командой на вывод количества выбранной спецодежды
                    SqlDataReader read = new SqlCommand($"SELECT count FROM ContentSklads WHERE ID_sklad = '{FinishSklad.ID}' and ID_clothe = '{check_wear.article}' and ID_size = '{check_wear.ID_size}';", conn)
                        .ExecuteReader();
                    int sum = check_wear.count;
                    using (read)
                        while (read.Read())//чтение каждой строки и суммирование
                            sum += (int)read["count"];
                    //выполнение sql-команды на удаление из исходного склада спецодежду
                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM ContentSklads " +
                        $"WHERE ID_sklad = '{StartSklad.ID}' AND ID_clothe = '{check_wear.article}' AND ID_size = '{check_wear.ID_size}';", conn))
                        cmd.ExecuteNonQuery();

                    SqlCommand sqlcommand;
                    //если сумма получилась больше количества спецодежды,
                    //то создается sql-команда на изменение значения count на sum, иначе на добавление новой
                    if (sum > check_wear.count)
                        sqlcommand = new SqlCommand($"UPDATE ContentSklads SET count = '{sum}' " +
                            $"WHERE ID_sklad = '{FinishSklad.ID}' and ID_clothe = '{check_wear.article}' and ID_size = '{check_wear.ID_size}';", conn);
                    else
                        sqlcommand = new SqlCommand($"INSERT INTO ContentSklads (ID_sklad, ID_clothe, ID_size, count) " +
                            $"VALUES ('{FinishSklad.ID}', '{check_wear.article}', '{check_wear.ID_size}', '{sum}');", conn);
                    using (sqlcommand) sqlcommand.ExecuteNonQuery();//выполнение команды

                    DTofMovedWearsForReport.Rows.Add(check_wear.name, "№" + StartSklad.number, "№" + FinishSklad.number, check_wear.count, DateTime.Now.ToString());

                }
                conn.Close();//закрытие подключения
            }
            if (lvWearsStart.Items.Count > 1)//если содержимое исходного склада не пуста, то обновляется, иначе очищается
                ContentOfSkladUpdate(lvWearsStart);
            else lvWearsStart.Items.Clear();
            ContentOfSkladUpdate(lvWearsFinish);//обновление целевого склада, куда перемещаются
            btnMoveToSklad.Enabled = false;
        }
        private void btnMoveToSklad_Click(object sender, EventArgs e) => MoveToSklad();
        private void btnUncheckStart_Click(object sender, EventArgs e)
        {
            foreach (WearViewItem item in lvWearsStart.CheckedItems)
                item.Checked = false;
        }
        private void btnBack_Click(object sender, EventArgs e) => this.Close();
        private void tbSkladNum_TextChanged(object sender, EventArgs e)
        {
            if (tbSkladNum.Text.Contains('\'') || tbSkladNum.Text.Contains('%'))
                return;            
            else SkladsUpdate();
        }
        private void tbWearOfStart_TextChanged(object sender, EventArgs e)
        {
            if (tbWearOfStart.Text.Contains('\'') || tbWearOfStart.Text.Contains('%'))
                return;
            else ContentOfSkladUpdate(lvWearsStart);
        }
        private void tbWearOfFinish_TextChanged(object sender, EventArgs e)
        {
            if (tbWearOfFinish.Text.Contains('\'') || tbWearOfFinish.Text.Contains('%'))
                return;
            else ContentOfSkladUpdate(lvWearsFinish);
        }

        private void btnAddNewSklad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"DECLARE @num INT \r\nIF (SELECT count(*) FROM Sklads) = 0\r\n    BEGIN\r\n\t\tSET @num = 1;\r\n    END;\r\nELSE SET @num = (SELECT TOP 1 ID+1 FROM Sklads ORDER BY ID DESC);\r\nSELECT @num;\r\nINSERT INTO Sklads VALUES(@num, '');", conn))
                    cmd.ExecuteNonQuery();
                conn.Close();
                SkladsUpdate();
            }

        }
    }
}
