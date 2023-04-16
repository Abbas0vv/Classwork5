using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client.Commands
{
    public class RemoveUserCommandForUsers
    {
        public static void Handle()
        {
            Console.WriteLine("Write your email : ");
            string email = Console.ReadLine()!;

            Console.Write("Write your password : ");
            string password = Console.ReadLine()!;

            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    if (user.Password == password)
                    {
                        Console.WriteLine($"{user.Name} removed!");
                        DataContext.Users.Remove(user);
                        return;
                    }
                    Console.WriteLine("Incorrect Password!");
                }
            }
            Console.WriteLine("Email can not be found!");
            return;
        }
    }
}