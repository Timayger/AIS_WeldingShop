using System.Drawing;
using System.Windows.Forms;

namespace SpecClothes
{
    partial class WearsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WearsForm));
            this.numericKolvo = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableProducts = new System.Windows.Forms.DataGridView();
            this.tbWearName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUncheckEmps = new System.Windows.Forms.Button();
            this.checkListEmployees = new System.Windows.Forms.CheckedListBox();
            this.tlpChange = new System.Windows.Forms.TableLayoutPanel();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.btnAddInCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericKolvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProducts)).BeginInit();
            this.tableMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpChange.SuspendLayout();
            this.tlpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericKolvo
            // 
            this.numericKolvo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericKolvo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numericKolvo.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericKolvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numericKolvo.Location = new System.Drawing.Point(436, 14);
            this.numericKolvo.Margin = new System.Windows.Forms.Padding(4);
            this.numericKolvo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericKolvo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericKolvo.Name = "numericKolvo";
            this.numericKolvo.Size = new System.Drawing.Size(180, 50);
            this.numericKolvo.TabIndex = 6;
            this.numericKolvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericKolvo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MistyRose;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(4, 848);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 77);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            //  
            // tableProducts
            // 
            this.tableProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableProducts.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.tableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMain.SetColumnSpan(this.tableProducts, 2);
            this.tableProducts.EnableHeadersVisualStyles = false;
            this.tableProducts.GridColor = System.Drawing.SystemColors.ControlText;
            this.tableProducts.Location = new System.Drawing.Point(50, 139);
            this.tableProducts.Margin = new System.Windows.Forms.Padding(50, 10, 20, 10);
            this.tableProducts.Name = "tableProducts";
            this.tableProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tableProducts.RowHeadersVisible = false;
            this.tableProducts.RowHeadersWidth = 30;
            this.tableProducts.RowTemplate.DividerHeight = 1;
            this.tableProducts.RowTemplate.Height = 30;
            this.tableProducts.RowTemplate.ReadOnly = true;
            this.tableProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tableProducts.Size = new System.Drawing.Size(1182, 695);
            this.tableProducts.StandardTab = true;
            this.tableProducts.TabIndex = 7;
            // 
            // tbWearName
            // 
            this.tbWearName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWearName.Font = new System.Drawing.Font("Georgia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWearName.Location = new System.Drawing.Point(193, 13);
            this.tbWearName.Margin = new System.Windows.Forms.Padding(4, 10, 10, 4);
            this.tbWearName.Name = "tbWearName";
            this.tbWearName.Size = new System.Drawing.Size(979, 38);
            this.tbWearName.TabIndex = 10;
            this.tbWearName.TextChanged += new System.EventHandler(this.tbWearName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Спецодежда:";
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 3;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableMain.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tableMain.Controls.Add(this.tlpChange, 1, 2);
            this.tableMain.Controls.Add(this.tlpFilter, 0, 0);
            this.tableMain.Controls.Add(this.btnAddInCart, 2, 2);
            this.tableMain.Controls.Add(this.btnExit, 0, 2);
            this.tableMain.Controls.Add(this.tableProducts, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Margin = new System.Windows.Forms.Padding(4);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.Size = new System.Drawing.Size(1774, 929);
            this.tableMain.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUncheckEmps, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkListEmployees, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1255, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableMain.SetRowSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 838);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Подобрать сотрудникам:";
            // 
            // btnUncheckEmps
            // 
            this.btnUncheckEmps.AutoSize = true;
            this.btnUncheckEmps.BackColor = System.Drawing.Color.Wheat;
            this.btnUncheckEmps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUncheckEmps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUncheckEmps.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUncheckEmps.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUncheckEmps.Location = new System.Drawing.Point(10, 770);
            this.btnUncheckEmps.Margin = new System.Windows.Forms.Padding(10, 0, 10, 4);
            this.btnUncheckEmps.Name = "btnUncheckEmps";
            this.btnUncheckEmps.Size = new System.Drawing.Size(469, 64);
            this.btnUncheckEmps.TabIndex = 13;
            this.btnUncheckEmps.Text = "Снять все галочки";
            this.btnUncheckEmps.UseVisualStyleBackColor = false;
            this.btnUncheckEmps.Click += new System.EventHandler(this.btnUncheckEmps_Click);
            // 
            // checkListEmployees
            // 
            this.checkListEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkListEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListEmployees.Font = new System.Drawing.Font("Georgia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkListEmployees.FormattingEnabled = true;
            this.checkListEmployees.Location = new System.Drawing.Point(3, 46);
            this.checkListEmployees.Name = "checkListEmployees";
            this.checkListEmployees.Size = new System.Drawing.Size(483, 721);
            this.checkListEmployees.TabIndex = 14;
            this.checkListEmployees.SelectedIndexChanged += new System.EventHandler(this.checkListEmployees_SelectedIndexChanged);
            // 
            // tlpChange
            // 
            this.tlpChange.AutoSize = true;
            this.tlpChange.ColumnCount = 2;
            this.tlpChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpChange.Controls.Add(this.numericKolvo, 1, 0);
            this.tlpChange.Controls.Add(this.cbSize, 0, 0);
            this.tlpChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChange.Location = new System.Drawing.Point(629, 847);
            this.tlpChange.Name = "tlpChange";
            this.tlpChange.RowCount = 1;
            this.tlpChange.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpChange.Size = new System.Drawing.Size(620, 79);
            this.tlpChange.TabIndex = 13;
            // 
            // cbSize
            // 
            this.cbSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbSize.Font = new System.Drawing.Font("Georgia", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "XXS",
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.cbSize.Location = new System.Drawing.Point(200, 10);
            this.cbSize.Margin = new System.Windows.Forms.Padding(200, 10, 3, 3);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(229, 57);
            this.cbSize.TabIndex = 14;
            // 
            // tlpFilter
            // 
            this.tlpFilter.ColumnCount = 2;
            this.tableMain.SetColumnSpan(this.tlpFilter, 2);
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFilter.Controls.Add(this.tbWearName, 1, 0);
            this.tlpFilter.Controls.Add(this.label1, 0, 0);
            this.tlpFilter.Controls.Add(this.label3, 0, 1);
            this.tlpFilter.Controls.Add(this.tbType, 1, 1);
            this.tlpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilter.Location = new System.Drawing.Point(50, 6);
            this.tlpFilter.Margin = new System.Windows.Forms.Padding(50, 6, 20, 6);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 2;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFilter.Size = new System.Drawing.Size(1182, 117);
            this.tlpFilter.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип:";
            // 
            // tbType
            // 
            this.tbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbType.Font = new System.Drawing.Font("Georgia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbType.Location = new System.Drawing.Point(193, 68);
            this.tbType.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(979, 38);
            this.tbType.TabIndex = 10;
            this.tbType.TextChanged += new System.EventHandler(this.tbType_TextChanged);
            // 
            // btnAddInCart
            // 
            this.btnAddInCart.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddInCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddInCart.Font = new System.Drawing.Font("Impact", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddInCart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddInCart.Location = new System.Drawing.Point(1256, 848);
            this.btnAddInCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddInCart.Name = "btnAddInCart";
            this.btnAddInCart.Size = new System.Drawing.Size(514, 77);
            this.btnAddInCart.TabIndex = 4;
            this.btnAddInCart.Text = "В корзину";
            this.btnAddInCart.UseVisualStyleBackColor = false;
            this.btnAddInCart.Click += new System.EventHandler(this.btnAddInCart_Click);
            // 
            // WearsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1774, 929);
            this.Controls.Add(this.tableMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1800, 1000);
            this.Name = "WearsForm";
            this.Text = "Спецодежды";
            ((System.ComponentModel.ISupportInitialize)(this.numericKolvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProducts)).EndInit();
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpChange.ResumeLayout(false);
            this.tlpFilter.ResumeLayout(false);
            this.tlpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnExit;
        private DataGridView tableProducts;
        private TextBox tbWearName;
        private Label label1;
        private NumericUpDown numericKolvo;
        private TableLayoutPanel tableMain;
        private Button btnAddInCart;
        private TableLayoutPanel tlpFilter;
        private TextBox tbType;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tlpChange;
        private ComboBox cbSize;
        private CheckedListBox checkListEmployees;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnUncheckEmps;
    }
}