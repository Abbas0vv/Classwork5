using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class UpdateSettingsCommand
    {
        public static void Handle()
        {
            Console.Write("Write user's ID : ");

            int id = int.Parse(Console.ReadLine()!);

            foreach (User user in DataContext.Users)
            {
                if (user.Id == id)
                {
                    Console.WriteLine("Write user's new name : ");
                    user.Name = Console.ReadLine()!;

                    Console.WriteLine("Write user's new LastName : ");
                    user.LastName = Console.ReadLine()!;

                    Console.WriteLine("Write user's new password : ");
                    user.Password = Console.ReadLine()!;

                    Console.WriteLine("User's datas has been updated!");
                    return;
                }
            }
            Console.WriteLine("User not found");
        }
    }
}