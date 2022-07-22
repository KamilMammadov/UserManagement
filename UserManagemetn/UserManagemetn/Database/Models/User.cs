using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagemetn.Database.Repository;

namespace UserManagemetn.Database.Models
{
    partial class User
    {

        public int ID { get; private set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
     
        //sildikden sonra elave etmek ucundur
        public User(string name, string surname, string email, string password,int id)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            ID = id;
        }

        public User(string name, string surname, string email, string password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            ID = UserRepository.IDCounter;
        }

    }
    partial class User
    {
        public virtual string GetInfo()
        {
            return Name + " " + Surname;
        }

     

    }
}
