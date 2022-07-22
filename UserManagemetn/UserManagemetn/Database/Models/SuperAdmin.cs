using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagemetn.Database.Models
{
    class SuperAdmin:Admin
    {
        public SuperAdmin(string name, string surname, string email, string password, int id)
            : base(name, surname, email, password, id)
        {

        }
        public SuperAdmin(string name,string surname,string email,string password)
            :base(name,surname,email,password)
        {

        }

        public override string GetInfo()
        {
            return ID + " " + Name + " " + Surname + " " + Email;
        }
    }
}
