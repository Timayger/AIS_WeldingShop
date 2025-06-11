namespace SpecClothes
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.lvProductsInCart = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCostInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.l_Discount = new System.Windows.Forms.Label();
            this.l_Sum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_TotalCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpCostInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProductsInCart
            // 
            this.lvProductsInCart.BackColor = System.Drawing.Color.Honeydew;
            this.lvProductsInCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProductsInCart.CheckBoxes = true;
            this.lvProductsInCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colCount,
            this.colCost});
            this.tlpMain.SetColumnSpan(this.lvProductsInCart, 3);
            this.lvProductsInCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProductsInCart.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvProductsInCart.ForeColor = System.Drawing.Color.Black;
            this.lvProductsInCart.HideSelection = false;
            this.lvProductsInCart.Location = new System.Drawing.Point(30, 49);
            this.lvProductsInCart.Margin = new System.Windows.Forms.Padding(30, 5, 30, 10);
            this.lvProductsInCart.Name = "lvProductsInCart";
            this.lvProductsInCart.Size = new System.Drawing.Size(1714, 683);
            this.lvProductsInCart.TabIndex = 0;
            this.lvProductsInCart.UseCompatibleStateImageBehavior = false;
            this.lvProductsInCart.View = System.Windows.Forms.View.Details;
            this.lvProductsInCart.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lbProducts_ItemChecked);
            this.lvProductsInCart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvProductsInCart_MouseClick);
            this.lvProductsInCart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProductsInCart_MouseDoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Название товара";
            this.colName.Width = 729;
            // 
            // colSize
            // 
            this.colSize.Text = "Размер";
            this.colSize.Width = 362;
            // 
            // colCount
            // 
            this.colCount.Text = "Кол-во";
            this.colCount.Width = 268;
            // 
            // colCost
            // 
            this.colCost.Text = "Стоимость";
            this.colCost.Width = 354;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1051, 872);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 73);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "–1";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MistyRose;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(3, 865);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 3, 400, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 87);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Font = new System.Drawing.Font("Impact", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSend.Location = new System.Drawing.Point(1185, 865);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(586, 87);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Создать заказ и уведомить поставщика";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Controls.Add(this.tlpCostInfo, 2, 2);
            this.tlpMain.Controls.Add(this.label3, 0, 0);
            this.tlpMain.Controls.Add(this.btnSend, 2, 3);
            this.tlpMain.Controls.Add(this.btnDelete, 1, 3);
            this.tlpMain.Controls.Add(this.lvProductsInCart, 0, 1);
            this.tlpMain.Controls.Add(this.btnExit, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1774, 955);
            this.tlpMain.TabIndex = 11;
            // 
            // tlpCostInfo
            // 
            this.tlpCostInfo.ColumnCount = 2;
            this.tlpCostInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCostInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCostInfo.Controls.Add(this.label7, 0, 1);
            this.tlpCostInfo.Controls.Add(this.l_Discount, 1, 1);
            this.tlpCostInfo.Controls.Add(this.l_Sum, 1, 0);
            this.tlpCostInfo.Controls.Add(this.label1, 0, 0);
            this.tlpCostInfo.Controls.Add(this.l_TotalCost, 1, 2);
            this.tlpCostInfo.Controls.Add(this.label2, 0, 2);
            this.tlpCostInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCostInfo.Location = new System.Drawing.Point(1185, 752);
            this.tlpCostInfo.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.tlpCostInfo.Name = "tlpCostInfo";
            this.tlpCostInfo.RowCount = 3;
            this.tlpCostInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCostInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCostInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCostInfo.Size = new System.Drawing.Size(559, 100);
            this.tlpCostInfo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label7.Location = new System.Drawing.Point(420, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "Скидка:";
            // 
            // l_Discount
            // 
            this.l_Discount.AutoSize = true;
            this.l_Discount.Dock = System.Windows.Forms.DockStyle.Left;
            this.l_Discount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Discount.ForeColor = System.Drawing.Color.Sienna;
            this.l_Discount.Location = new System.Drawing.Point(528, 33);
            this.l_Discount.Name = "l_Discount";
            this.l_Discount.Size = new System.Drawing.Size(24, 33);
            this.l_Discount.TabIndex = 15;
            this.l_Discount.Text = "0";
            // 
            // l_Sum
            // 
            this.l_Sum.AutoSize = true;
            this.l_Sum.Dock = System.Windows.Forms.DockStyle.Left;
            this.l_Sum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Sum.ForeColor = System.Drawing.Color.Sienna;
            this.l_Sum.Location = new System.Drawing.Point(528, 0);
            this.l_Sum.Name = "l_Sum";
            this.l_Sum.Size = new System.Drawing.Size(24, 33);
            this.l_Sum.TabIndex = 13;
            this.l_Sum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(438, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Всего:";
            // 
            // l_TotalCost
            // 
            this.l_TotalCost.AutoSize = true;
            this.l_TotalCost.Dock = System.Windows.Forms.DockStyle.Left;
            this.l_TotalCost.Font = new System.Drawing.Font("Times New Roman", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_TotalCost.ForeColor = System.Drawing.Color.Sienna;
            this.l_TotalCost.Location = new System.Drawing.Point(528, 66);
            this.l_TotalCost.Name = "l_TotalCost";
            this.l_TotalCost.Size = new System.Drawing.Size(28, 34);
            this.l_TotalCost.TabIndex = 14;
            this.l_TotalCost.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(307, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Итого к оплате:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(30, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Товары из корзины:";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1774, 955);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1800, 1000);
            this.Name = "CartForm";
            this.Text = "Корзина";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpCostInfo.ResumeLayout(false);
            this.tlpCostInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProductsInCart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpCostInfo;
        private System.Windows.Forms.Label l_TotalCost;
        private System.Windows.Forms.Label l_Sum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_Discount;
    }
}