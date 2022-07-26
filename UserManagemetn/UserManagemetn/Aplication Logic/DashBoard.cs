﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagemetn.Database.Models;
using UserManagemetn.Database.Repository;

namespace UserManagemetn.Aplication_Logic
{
    class DashBoard
    {
        public static void SuperAdminPanel(string email)
        {
            User user = UserRepository.GetUserByEmail(email);
            Console.WriteLine("Admin succesfully joined", user.GetInfo());

            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Commands");

                Console.WriteLine("/show-user");
                Console.WriteLine("/remove");
                Console.WriteLine("/make-admin");
                Console.WriteLine("/remove-admin");
                Console.WriteLine("/logout");

                Console.WriteLine("Enter Command");
                string command = Console.ReadLine();


                if (command == "/make-admin")
                {
                    Console.WriteLine("Enter email");
                    string adminEmail = Console.ReadLine();
                    User user1 = UserRepository.GetUserByEmail(adminEmail);

                    if (user == null)
                    {
                        Console.WriteLine("Email ile isitfadeci tapilmadi");
                    }
                    else
                    {
                        UserRepository.Delete(user1);
                        Admin admin = new Admin(user1.Name, user1.Surname, user1.Email, user1.Password,user1.ID);
                        UserRepository.Add(admin);
                    }
                }
                else if (command == "/remove-admin")
                {
                    Console.WriteLine("emaili daxil edin");
                    string targetemail = Console.ReadLine();

                    User adminuser = UserRepository.GetUserByEmail(targetemail);
                    if (adminuser is Admin)
                    {
                        UserRepository.Delete(adminuser);
                        UserRepository.Add(adminuser.Name, adminuser.Surname, adminuser.Email, adminuser.Password, adminuser.ID);
                        UserRepository.Add(adminuser);
                        Console.WriteLine("Admin succes fully deleted");
                    }
                }
                else if (command == "/showuser")
                {
                    List<User> Users = UserRepository.GetAll();
                    foreach (User oneuser in Users)
                    {
                        Console.WriteLine(oneuser.ID + " " + oneuser.Name + " " + oneuser.Surname + " " + oneuser.Email);
                    }
                }
                else if (command == "/remove")
                {
                    Console.WriteLine("Please Enter email");
                    string targetemail = Console.ReadLine();

                    User RemoveUser = UserRepository.GetUserByEmail(targetemail);
                    if (RemoveUser==null)
                    {
                        Console.WriteLine("Email not found");
                    }
                    else
                    {
                    UserRepository.Delete(RemoveUser);
                    Console.WriteLine("User succesfully deleted");
                    }

                }
                else if (command == "/logout")
                {
                    Program.Main(new string[] { });
                }
                else
                {
                    Console.WriteLine("Command Not Found");
                }
            }

        }

        public static void AdminPanel(string email)
        {
            User user = UserRepository.GetUserByEmail(email);
            Console.WriteLine("Admin succesfully joined", user.GetInfo());

            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Commands");

                Console.WriteLine("/showuser");
                Console.WriteLine("/logout");
                Console.WriteLine();
                Console.WriteLine("Enter Command");
                string command = Console.ReadLine();


                List<User> Users = UserRepository.GetAll();
                if (command=="/showuser")
                {
                    foreach (User oneuser in Users)
                    {
                        Console.WriteLine(oneuser.ID+" "+ oneuser.Name+ " "+ oneuser.Surname+" "+oneuser.Email);
                    }
                }
                else if (command == "/logout")
                {
                    Program.Main(new string[] { });
                }
                else
                {
                    Console.WriteLine("command not found");
                }
            }
            
        }

        public static void UserPanel(string email)
        {
            User user = UserRepository.GetUserByEmail(email);
            Console.WriteLine($"User successfully authenticated : {user.GetInfo()}");
            Console.WriteLine();

            Console.WriteLine("commands : / logout ");
            string command = Console.ReadLine();

            if (command == "/logout")
            {
                Program.Main(new string[] { });
            }
            else
            {
                Console.WriteLine("command not found");
            }
        }


    }
}
