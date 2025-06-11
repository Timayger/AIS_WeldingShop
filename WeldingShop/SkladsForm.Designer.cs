namespace SpecClothes
{
    partial class SkladsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkladsForm));
            this.tbSkladNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoveToSklad = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMoveToSkladNon = new System.Windows.Forms.Button();
            this.lvWearsNonInSklad = new System.Windows.Forms.ListView();
            this.colNameNon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCountNon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpFinish = new System.Windows.Forms.TableLayoutPanel();
            this.lFinishNum = new System.Windows.Forms.Label();
            this.lvWearsFinish = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbWearOfFinish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpStart = new System.Windows.Forms.TableLayoutPanel();
            this.lStartNum = new System.Windows.Forms.Label();
            this.lvWearsStart = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUncheckStart = new System.Windows.Forms.Button();
            this.tbWearOfStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpSklads = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNewSklad = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpFinish.SuspendLayout();
            this.tlpStart.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSkladNum
            // 
            this.tbSkladNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSkladNum.Font = new System.Drawing.Font("Georgia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSkladNum.Location = new System.Drawing.Point(160, 10);
            this.tbSkladNum.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.tbSkladNum.Name = "tbSkladNum";
            this.tbSkladNum.Size = new System.Drawing.Size(333, 38);
            this.tbSkladNum.TabIndex = 8;
            this.tbSkladNum.TextChanged += new System.EventHandler(this.tbSkladNum_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "№ склада:";
            // 
            // btnMoveToSklad
            // 
            this.btnMoveToSklad.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMoveToSklad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveToSklad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveToSklad.Font = new System.Drawing.Font("Book Antiqua", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoveToSklad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMoveToSklad.Location = new System.Drawing.Point(1267, 840);
            this.btnMoveToSklad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.btnMoveToSklad.Name = "btnMoveToSklad";
            this.btnMoveToSklad.Size = new System.Drawing.Size(751, 79);
            this.btnMoveToSklad.TabIndex = 6;
            this.btnMoveToSklad.Text = "Переместить выбранные спецодежды";
            this.btnMoveToSklad.UseVisualStyleBackColor = false;
            this.btnMoveToSklad.Click += new System.EventHandler(this.btnMoveToSklad_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MistyRose;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.DimGray;
            this.btnBack.Location = new System.Drawing.Point(4, 840);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(194, 79);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.02173F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.48913F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.48913F));
            this.tlpMain.Controls.Add(this.btnGenerateReport, 1, 3);
            this.tlpMain.Controls.Add(this.groupBox1, 0, 2);
            this.tlpMain.Controls.Add(this.tlpFinish, 2, 0);
            this.tlpMain.Controls.Add(this.tlpStart, 1, 0);
            this.tlpMain.Controls.Add(this.btnBack, 0, 3);
            this.tlpMain.Controls.Add(this.btnMoveToSklad, 2, 3);
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(2022, 929);
            this.tlpMain.TabIndex = 9;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.MediumPurple;
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerateReport.Font = new System.Drawing.Font("Book Antiqua", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnGenerateReport.Location = new System.Drawing.Point(853, 846);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(400, 68);
            this.btnGenerateReport.TabIndex = 10;
            this.btnGenerateReport.Text = "Сформировать отчёт";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 451);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 382);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нераспределенные";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnMoveToSkladNon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvWearsNonInSklad, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 352);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // btnMoveToSkladNon
            // 
            this.btnMoveToSkladNon.AutoSize = true;
            this.btnMoveToSkladNon.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMoveToSkladNon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveToSkladNon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMoveToSkladNon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToSkladNon.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoveToSkladNon.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMoveToSkladNon.Location = new System.Drawing.Point(3, 293);
            this.btnMoveToSkladNon.Name = "btnMoveToSkladNon";
            this.btnMoveToSkladNon.Size = new System.Drawing.Size(480, 56);
            this.btnMoveToSkladNon.TabIndex = 13;
            this.btnMoveToSkladNon.Text = "Переместить в исходный склад";
            this.btnMoveToSkladNon.UseVisualStyleBackColor = false;
            this.btnMoveToSkladNon.Click += new System.EventHandler(this.btnMoveToSkladNon_Click);
            // 
            // lvWearsNonInSklad
            // 
            this.lvWearsNonInSklad.BackColor = System.Drawing.Color.Honeydew;
            this.lvWearsNonInSklad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWearsNonInSklad.CheckBoxes = true;
            this.lvWearsNonInSklad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNameNon,
            this.colCountNon});
            this.lvWearsNonInSklad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWearsNonInSklad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvWearsNonInSklad.ForeColor = System.Drawing.Color.Black;
            this.lvWearsNonInSklad.HideSelection = false;
            this.lvWearsNonInSklad.Location = new System.Drawing.Point(5, 5);
            this.lvWearsNonInSklad.Margin = new System.Windows.Forms.Padding(5);
            this.lvWearsNonInSklad.Name = "lvWearsNonInSklad";
            this.lvWearsNonInSklad.Size = new System.Drawing.Size(476, 280);
            this.lvWearsNonInSklad.TabIndex = 16;
            this.lvWearsNonInSklad.UseCompatibleStateImageBehavior = false;
            this.lvWearsNonInSklad.View = System.Windows.Forms.View.Details;
            this.lvWearsNonInSklad.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvWearsNonInSklad_WearChecked);
            // 
            // colNameNon
            // 
            this.colNameNon.Text = "Название";
            this.colNameNon.Width = 271;
            // 
            // colCountNon
            // 
            this.colCountNon.Text = "Кол-во";
            this.colCountNon.Width = 113;
            // 
            // tlpFinish
            // 
            this.tlpFinish.ColumnCount = 2;
            this.tlpFinish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFinish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFinish.Controls.Add(this.lFinishNum, 0, 1);
            this.tlpFinish.Controls.Add(this.lvWearsFinish, 0, 2);
            this.tlpFinish.Controls.Add(this.tbWearOfFinish, 1, 0);
            this.tlpFinish.Controls.Add(this.label3, 0, 0);
            this.tlpFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFinish.Location = new System.Drawing.Point(1267, 4);
            this.tlpFinish.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFinish.Name = "tlpFinish";
            this.tlpFinish.RowCount = 3;
            this.tlpMain.SetRowSpan(this.tlpFinish, 3);
            this.tlpFinish.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFinish.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFinish.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFinish.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpFinish.Size = new System.Drawing.Size(751, 828);
            this.tlpFinish.TabIndex = 12;
            // 
            // lFinishNum
            // 
            this.lFinishNum.AutoSize = true;
            this.tlpFinish.SetColumnSpan(this.lFinishNum, 2);
            this.lFinishNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFinishNum.Font = new System.Drawing.Font("Georgia", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFinishNum.ForeColor = System.Drawing.Color.Black;
            this.lFinishNum.Location = new System.Drawing.Point(4, 52);
            this.lFinishNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFinishNum.Name = "lFinishNum";
            this.lFinishNum.Size = new System.Drawing.Size(743, 25);
            this.lFinishNum.TabIndex = 10;
            this.lFinishNum.Text = "Целевой склад № _";
            this.lFinishNum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lvWearsFinish
            // 
            this.lvWearsFinish.BackColor = System.Drawing.Color.Honeydew;
            this.lvWearsFinish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWearsFinish.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.tlpFinish.SetColumnSpan(this.lvWearsFinish, 2);
            this.lvWearsFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWearsFinish.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvWearsFinish.ForeColor = System.Drawing.Color.Black;
            this.lvWearsFinish.HideSelection = false;
            this.lvWearsFinish.Location = new System.Drawing.Point(10, 87);
            this.lvWearsFinish.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.lvWearsFinish.Name = "lvWearsFinish";
            this.lvWearsFinish.Size = new System.Drawing.Size(731, 721);
            this.lvWearsFinish.TabIndex = 10;
            this.lvWearsFinish.UseCompatibleStateImageBehavior = false;
            this.lvWearsFinish.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название товара";
            this.columnHeader1.Width = 474;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Кол-во";
            this.columnHeader2.Width = 196;
            // 
            // tbWearOfFinish
            // 
            this.tbWearOfFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWearOfFinish.Font = new System.Drawing.Font("Georgia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWearOfFinish.Location = new System.Drawing.Point(189, 10);
            this.tbWearOfFinish.Margin = new System.Windows.Forms.Padding(4, 10, 10, 4);
            this.tbWearOfFinish.Name = "tbWearOfFinish";
            this.tbWearOfFinish.Size = new System.Drawing.Size(552, 38);
            this.tbWearOfFinish.TabIndex = 8;
            this.tbWearOfFinish.TextChanged += new System.EventHandler(this.tbWearOfFinish_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Спецодежда:";
            // 
            // tlpStart
            // 
            this.tlpStart.ColumnCount = 2;
            this.tlpStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStart.Controls.Add(this.lStartNum, 0, 1);
            this.tlpStart.Controls.Add(this.lvWearsStart, 0, 2);
            this.tlpStart.Controls.Add(this.btnUncheckStart, 0, 3);
            this.tlpStart.Controls.Add(this.tbWearOfStart, 1, 0);
            this.tlpStart.Controls.Add(this.label2, 0, 0);
            this.tlpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStart.Location = new System.Drawing.Point(509, 4);
            this.tlpStart.Margin = new System.Windows.Forms.Padding(4);
            this.tlpStart.Name = "tlpStart";
            this.tlpStart.RowCount = 4;
            this.tlpMain.SetRowSpan(this.tlpStart, 3);
            this.tlpStart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStart.Size = new System.Drawing.Size(750, 828);
            this.tlpStart.TabIndex = 10;
            // 
            // lStartNum
            // 
            this.lStartNum.AutoSize = true;
            this.tlpStart.SetColumnSpan(this.lStartNum, 2);
            this.lStartNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lStartNum.Font = new System.Drawing.Font("Georgia", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStartNum.ForeColor = System.Drawing.Color.Black;
            this.lStartNum.Location = new System.Drawing.Point(4, 52);
            this.lStartNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lStartNum.Name = "lStartNum";
            this.lStartNum.Size = new System.Drawing.Size(742, 25);
            this.lStartNum.TabIndex = 10;
            this.lStartNum.Text = "Исходный склад № _";
            this.lStartNum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lvWearsStart
            // 
            this.lvWearsStart.BackColor = System.Drawing.Color.Honeydew;
            this.lvWearsStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWearsStart.CheckBoxes = true;
            this.lvWearsStart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCount});
            this.tlpStart.SetColumnSpan(this.lvWearsStart, 2);
            this.lvWearsStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWearsStart.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvWearsStart.ForeColor = System.Drawing.Color.Black;
            this.lvWearsStart.HideSelection = false;
            this.lvWearsStart.Location = new System.Drawing.Point(10, 87);
            this.lvWearsStart.Margin = new System.Windows.Forms.Padding(10, 10, 10, 19);
            this.lvWearsStart.Name = "lvWearsStart";
            this.lvWearsStart.Size = new System.Drawing.Size(730, 661);
            this.lvWearsStart.TabIndex = 10;
            this.lvWearsStart.UseCompatibleStateImageBehavior = false;
            this.lvWearsStart.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Название товара";
            this.colName.Width = 474;
            // 
            // colCount
            // 
            this.colCount.Text = "Кол-во";
            this.colCount.Width = 196;
            // 
            // btnUncheckStart
            // 
            this.btnUncheckStart.AutoSize = true;
            this.btnUncheckStart.BackColor = System.Drawing.Color.Wheat;
            this.tlpStart.SetColumnSpan(this.btnUncheckStart, 2);
            this.btnUncheckStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUncheckStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUncheckStart.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUncheckStart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUncheckStart.Location = new System.Drawing.Point(120, 767);
            this.btnUncheckStart.Margin = new System.Windows.Forms.Padding(120, 0, 100, 4);
            this.btnUncheckStart.Name = "btnUncheckStart";
            this.btnUncheckStart.Size = new System.Drawing.Size(530, 57);
            this.btnUncheckStart.TabIndex = 10;
            this.btnUncheckStart.Text = "Снять все галочки";
            this.btnUncheckStart.UseVisualStyleBackColor = false;
            this.btnUncheckStart.Click += new System.EventHandler(this.btnUncheckStart_Click);
            // 
            // tbWearOfStart
            // 
            this.tbWearOfStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWearOfStart.Font = new System.Drawing.Font("Georgia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWearOfStart.Location = new System.Drawing.Point(189, 10);
            this.tbWearOfStart.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.tbWearOfStart.Name = "tbWearOfStart";
            this.tbWearOfStart.Size = new System.Drawing.Size(557, 38);
            this.tbWearOfStart.TabIndex = 8;
            this.tbWearOfStart.TextChanged += new System.EventHandler(this.tbWearOfStart_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Спецодежда:";
            // 
            // flpSklads
            // 
            this.flpSklads.AutoScroll = true;
            this.flpSklads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSklads.Location = new System.Drawing.Point(4, 4);
            this.flpSklads.Margin = new System.Windows.Forms.Padding(4);
            this.flpSklads.Name = "flpSklads";
            this.flpSklads.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.flpSklads.Size = new System.Drawing.Size(491, 312);
            this.flpSklads.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tbSkladNum, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(497, 52);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btnAddNewSklad
            // 
            this.btnAddNewSklad.AutoSize = true;
            this.btnAddNewSklad.BackColor = System.Drawing.Color.Wheat;
            this.btnAddNewSklad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewSklad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddNewSklad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSklad.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewSklad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddNewSklad.Location = new System.Drawing.Point(3, 323);
            this.btnAddNewSklad.Name = "btnAddNewSklad";
            this.btnAddNewSklad.Size = new System.Drawing.Size(493, 56);
            this.btnAddNewSklad.TabIndex = 14;
            this.btnAddNewSklad.Text = "Добавить новый склад";
            this.btnAddNewSklad.UseVisualStyleBackColor = false;
            this.btnAddNewSklad.Click += new System.EventHandler(this.btnAddNewSklad_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddNewSklad, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flpSklads, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 382);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // SkladsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(2022, 929);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1800, 1000);
            this.Name = "SkladsForm";
            this.Text = "Складской учет";
            this.Load += new System.EventHandler(this.SkladsForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpFinish.ResumeLayout(false);
            this.tlpFinish.PerformLayout();
            this.tlpStart.ResumeLayout(false);
            this.tlpStart.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbSkladNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoveToSklad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpSklads;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView lvWearsStart;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.TableLayoutPanel tlpStart;
        private System.Windows.Forms.TextBox tbWearOfStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlpFinish;
        private System.Windows.Forms.ListView lvWearsFinish;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbWearOfFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lStartNum;
        private System.Windows.Forms.Label lFinishNum;
        private System.Windows.Forms.Button btnUncheckStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvWearsNonInSklad;
        private System.Windows.Forms.ColumnHeader colNameNon;
        private System.Windows.Forms.ColumnHeader colCountNon;
        private System.Windows.Forms.Button btnMoveToSkladNon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAddNewSklad;
    }
}