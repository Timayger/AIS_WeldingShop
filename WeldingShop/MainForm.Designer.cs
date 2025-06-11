namespace SpecClothes
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelExit = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUp = new System.Windows.Forms.TableLayoutPanel();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnWears = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnSklads = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Georgia", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.Navy;
            this.labelExit.Location = new System.Drawing.Point(108, 15);
            this.labelExit.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(130, 33);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "Выйти";
            this.labelExit.Click += new System.EventHandler(this.label2_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.60785F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.35947F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.03268F));
            this.tlpMain.Controls.Add(this.tlpUp, 2, 0);
            this.tlpMain.Controls.Add(this.pbLogo, 0, 0);
            this.tlpMain.Controls.Add(this.labelName, 1, 0);
            this.tlpMain.Controls.Add(this.btnWears, 0, 1);
            this.tlpMain.Controls.Add(this.btnOrders, 0, 2);
            this.tlpMain.Controls.Add(this.btnSklads, 0, 3);
            this.tlpMain.Controls.Add(this.btnAdmin, 0, 4);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(1774, 929);
            this.tlpMain.TabIndex = 5;
            // 
            // tlpUp
            // 
            this.tlpUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.tlpUp.ColumnCount = 1;
            this.tlpUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUp.Controls.Add(this.labelExit, 0, 0);
            this.tlpUp.Controls.Add(this.pbCart, 0, 1);
            this.tlpUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUp.Location = new System.Drawing.Point(1506, 0);
            this.tlpUp.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUp.Name = "tlpUp";
            this.tlpUp.RowCount = 2;
            this.tlpUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUp.Size = new System.Drawing.Size(268, 126);
            this.tlpUp.TabIndex = 6;
            // 
            // pbCart
            // 
            this.pbCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.ErrorImage = global::SpecClothes.Properties.Resources.logo;
            this.pbCart.Image = global::SpecClothes.Properties.Resources.img_cart;
            this.pbCart.InitialImage = global::SpecClothes.Properties.Resources.logo;
            this.pbCart.Location = new System.Drawing.Point(153, 66);
            this.pbCart.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.pbCart.MaximumSize = new System.Drawing.Size(70, 70);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(65, 57);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCart.TabIndex = 2;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.NavajoWhite;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.ErrorImage = global::SpecClothes.Properties.Resources.logo;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = global::SpecClothes.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(347, 126);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Berlin Sans FB", 16.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelName.Location = new System.Drawing.Point(347, 0);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(1159, 126);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "WeldingShop";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWears
            // 
            this.btnWears.AutoSize = true;
            this.btnWears.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tlpMain.SetColumnSpan(this.btnWears, 3);
            this.btnWears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWears.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnWears.Image = global::SpecClothes.Properties.Resources.img_clothe;
            this.btnWears.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWears.Location = new System.Drawing.Point(10, 136);
            this.btnWears.Margin = new System.Windows.Forms.Padding(10);
            this.btnWears.Name = "btnWears";
            this.btnWears.Padding = new System.Windows.Forms.Padding(10);
            this.btnWears.Size = new System.Drawing.Size(1754, 180);
            this.btnWears.TabIndex = 4;
            this.btnWears.Text = "Спецодежды";
            this.btnWears.UseVisualStyleBackColor = false;
            this.btnWears.Click += new System.EventHandler(this.btnWears_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.AutoSize = true;
            this.btnOrders.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tlpMain.SetColumnSpan(this.btnOrders, 3);
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnOrders.Image = global::SpecClothes.Properties.Resources.img_order;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.Location = new System.Drawing.Point(10, 336);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(10);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10);
            this.btnOrders.Size = new System.Drawing.Size(1754, 180);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Заказы / Закупки";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnSklads
            // 
            this.btnSklads.AutoSize = true;
            this.btnSklads.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tlpMain.SetColumnSpan(this.btnSklads, 3);
            this.btnSklads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSklads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSklads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSklads.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnSklads.Image = global::SpecClothes.Properties.Resources.img_sklad;
            this.btnSklads.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSklads.Location = new System.Drawing.Point(10, 536);
            this.btnSklads.Margin = new System.Windows.Forms.Padding(10);
            this.btnSklads.Name = "btnSklads";
            this.btnSklads.Padding = new System.Windows.Forms.Padding(10);
            this.btnSklads.Size = new System.Drawing.Size(1754, 180);
            this.btnSklads.TabIndex = 2;
            this.btnSklads.Text = "Складской учет";
            this.btnSklads.UseVisualStyleBackColor = false;
            this.btnSklads.Click += new System.EventHandler(this.btnSklads_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = true;
            this.btnAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tlpMain.SetColumnSpan(this.btnAdmin, 3);
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAdmin.Image = global::SpecClothes.Properties.Resources.img_admin;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.Location = new System.Drawing.Point(10, 736);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10);
            this.btnAdmin.Size = new System.Drawing.Size(1754, 183);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Сотрудники";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1774, 929);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1800, 1000);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSklads;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnWears;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpUp;
        private System.Windows.Forms.Label labelName;
    }
}