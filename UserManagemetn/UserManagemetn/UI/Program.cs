﻿using System;
using UserManagemetn.Aplication_Logic;

namespace UserManagemetn
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("------------------------");

            Console.WriteLine("commands :");

            Console.WriteLine("reg");
            Console.WriteLine("log");
            while (true)
            {
                Console.WriteLine("enterCommand");
                string command = Console.ReadLine();

                if (command == "reg")
                {
                    Authentication.Register();
                }
                else if (command == "log")
                {
                    Authentication.Login();
                }
            }
           
        }
    }
}
