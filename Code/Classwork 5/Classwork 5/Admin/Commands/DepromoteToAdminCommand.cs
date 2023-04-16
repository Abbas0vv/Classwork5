using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Utilities;

namespace TaskManagement.Admin.Commands
{
    public class DepromoteToAdminCommand
    {
        public static void Handle()
        {
            UserValidator validator = new UserValidator();

            string email = Console.ReadLine()!;

            if (!validator.IsEmailExists(email))
            {
                foreach (User user in DataContext.Users)
                {
                    if (user.Email == email)
                    {
                        if (user.IsAdmin)
                        {
                            user.IsAdmin = false;
                            Console.WriteLine($"{user.Name} is now user!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"{user.Name} already user!");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Email can not be found!");
        }
    }
}