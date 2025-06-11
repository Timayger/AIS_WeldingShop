using System;
using System.Windows.Forms;

namespace SpecClothes
{
    internal static class Program
    {

        public static string connectionString = "Server=DESKTOPTIM;Database=specclothes_db;Integrated Security=True";

        public static Role userRole = Role.Null;
        public static int userId;
        public static string userName;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
        
    }
}
