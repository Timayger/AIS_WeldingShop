using System;
using System.Windows.Forms;

namespace SpecClothes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Program.userRole == Role.Null)
                new LoginForm().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //если роль не назначена, то завершить работу программы
            if (Program.userRole == Role.Null)
            {
                Application.Exit();//выход из приложения
                this.Close();//закрытие формы
            }
            //установка прав в соответствии с ролью
            switch (Program.userRole)
            {
                case Role.Admin://если админ
                    btnWears.Enabled = false;
                    btnOrders.Enabled = false;
                    btnSklads.Enabled = false;
                    btnAdmin.Enabled = true;
                    pbCart.Visible = false;
                    break;
                case Role.Manager://если менеджер
                    btnWears.Enabled = true;
                    btnOrders.Enabled = true;
                    btnSklads.Enabled = false;
                    btnAdmin.Enabled = false;
                    pbCart.Visible = true;
                    break;
                case Role.Storekeeper://если кладовщик
                    btnWears.Enabled = false;
                    btnOrders.Enabled = false;
                    btnSklads.Enabled = true;
                    btnAdmin.Enabled = false;
                    pbCart.Visible = false;
                    break;
                case Role.Worker://если сварщик
                    btnWears.Enabled = false;
                    btnOrders.Enabled = false;
                    btnSklads.Enabled = false;
                    btnAdmin.Enabled = false;
                    pbCart.Visible = false;
                    break;
            }
        }

        private void btnWears_Click(object sender, EventArgs e) => new WearsForm().ShowDialog();
        private void btnOrders_Click(object sender, EventArgs e) => new OrdersForm().ShowDialog();
        private void btnSklads_Click(object sender, EventArgs e) => new SkladsForm().ShowDialog();
        private void btnAdmin_Click(object sender, EventArgs e) => new EmployeesForm().ShowDialog();
        private void pictureBox2_Click(object sender, EventArgs e) => new CartForm().ShowDialog();
        private void label2_Click(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
            MainForm_Load(sender, e);
        }


    }
}
