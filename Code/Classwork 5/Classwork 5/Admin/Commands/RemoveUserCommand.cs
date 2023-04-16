using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class RemoveUserCommand
    {
        public static void Handle()
        {
            Console.Write("Write user's ID : ");
            int id = int.Parse(Console.ReadLine()!);

            foreach (User user in DataContext.Users)
            {
                if (user.Id == id)
                {
                    Console.WriteLine($"{user.Name} removed!");
                    DataContext.Users.Remove(user);
                    return;
                }
            }
            Console.WriteLine("User can not be found");
            return;
        }
    }
}