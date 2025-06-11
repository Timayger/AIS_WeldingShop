namespace SpecClothes
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableEmployees = new System.Windows.Forms.DataGridView();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.tbFindEmployee = new System.Windows.Forms.TextBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tlpMain.Controls.Add(this.btnEditEmployee, 2, 2);
            this.tlpMain.Controls.Add(this.label1, 0, 0);
            this.tlpMain.Controls.Add(this.btnAddEmployee, 3, 2);
            this.tlpMain.Controls.Add(this.btnExit, 0, 2);
            this.tlpMain.Controls.Add(this.tableEmployees, 0, 1);
            this.tlpMain.Controls.Add(this.btnDeleteEmployee, 1, 2);
            this.tlpMain.Controls.Add(this.tbFindEmployee, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1774, 929);
            this.tlpMain.TabIndex = 12;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditEmployee.Font = new System.Drawing.Font("Impact", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditEmployee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditEmployee.Location = new System.Drawing.Point(904, 854);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(430, 72);
            this.btnEditEmployee.TabIndex = 13;
            this.btnEditEmployee.Text = "Редактировать";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО:";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddEmployee.Font = new System.Drawing.Font("Impact", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddEmployee.Location = new System.Drawing.Point(1340, 854);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(431, 72);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MistyRose;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(3, 854);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 72);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableEmployees
            // 
            this.tableEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableEmployees.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.tableEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMain.SetColumnSpan(this.tableEmployees, 4);
            this.tableEmployees.EnableHeadersVisualStyles = false;
            this.tableEmployees.GridColor = System.Drawing.SystemColors.ControlText;
            this.tableEmployees.Location = new System.Drawing.Point(50, 61);
            this.tableEmployees.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.tableEmployees.Name = "tableEmployees";
            this.tableEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tableEmployees.RowHeadersVisible = false;
            this.tableEmployees.RowHeadersWidth = 30;
            this.tableEmployees.RowTemplate.DividerHeight = 1;
            this.tableEmployees.RowTemplate.Height = 30;
            this.tableEmployees.RowTemplate.ReadOnly = true;
            this.tableEmployees.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tableEmployees.Size = new System.Drawing.Size(1674, 780);
            this.tableEmployees.StandardTab = true;
            this.tableEmployees.TabIndex = 7;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmployee.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Impact", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(564, 854);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(334, 72);
            this.btnDeleteEmployee.TabIndex = 13;
            this.btnDeleteEmployee.Text = "Удалить";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // tbFindEmployee
            // 
            this.tbFindEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFindEmployee.Font = new System.Drawing.Font("Georgia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFindEmployee.Location = new System.Drawing.Point(178, 10);
            this.tbFindEmployee.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tbFindEmployee.Name = "tbFindEmployee";
            this.tbFindEmployee.Size = new System.Drawing.Size(720, 38);
            this.tbFindEmployee.TabIndex = 10;
            this.tbFindEmployee.TextChanged += new System.EventHandler(this.tbFindEmployee_TextChanged);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1774, 929);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1800, 1000);
            this.Name = "EmployeesForm";
            this.Text = "Сотрудники";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFindEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView tableEmployees;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}