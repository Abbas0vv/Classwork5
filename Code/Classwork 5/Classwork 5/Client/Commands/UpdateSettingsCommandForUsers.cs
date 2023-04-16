using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client.Commands
{
    public class UpdateSettingsCommandForUsers
    {
        public static void Handle()
        {
            Console.Write("Write your email : ");

            string email = Console.ReadLine()!;

            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    UserValidator userValidator = new UserValidator();

                    Console.Write("Write your new Name : ");
                    user.Name = Console.ReadLine()!;

                    Console.Write("Write your new LastName : ");
                    user.LastName = Console.ReadLine()!;
                    
                    Console.WriteLine("Write your old password : ");
                    string password = userValidator.GetAndValidatePassword();

                    Console.WriteLine("Write your new password");
                    user.Password = Console.ReadLine()!;


                    Console.WriteLine("Your new datas has been added!");
                    return;
                }
            }
            Console.WriteLine("Email can not be found!");
        }
    }
}