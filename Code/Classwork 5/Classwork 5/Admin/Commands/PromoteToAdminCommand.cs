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
    public class PromoteToAdminCommand
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
                            Console.WriteLine($"{user.Name} already admin!");
                            return;
                        }
                        else
                        {
                            user.IsAdmin = true;
                            Console.WriteLine($"{user.Name} is now admin!");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Email can not be found!");
        }
    }
}