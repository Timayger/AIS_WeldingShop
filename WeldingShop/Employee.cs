using System;

namespace SpecClothes
{
    public class Employee
    {
        public int ID;
        public string LastName;
        public string FirstName;
        public string Patronymic;
        public int ID_role;
        public string roleName;
        public int ID_size;
        public string sizeName;
        public string Email;
        public string Phone;
        public DateTime Birthdate;
        public string Login;
        public string Password;
        public Employee(int id, string last_name, string first_name, string patronymic, int id_role, int id_size, string email, string phone, DateTime birthdate, string login, string password)
        {
            ID = id;
            LastName = last_name;
            FirstName = first_name;
            Patronymic = patronymic;
            ID_role = id_role;
            ID_size = id_size;
            Email = email;
            Phone = phone;
            Birthdate = birthdate;
            Login = login;
            Password = password;

        }
    }
}
