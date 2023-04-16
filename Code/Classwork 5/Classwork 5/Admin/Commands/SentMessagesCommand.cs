using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace Classwork_5.Admin.Commands
{
    public class SentMessagesCommand
    {
        public static void Handle()
        {
            UserValidator validator = new UserValidator();

            Console.Write("Who will it be sent to : ");
            string email = Console.ReadLine()!;

            if (validator.IsEmailExists(email))
            {
                foreach (User user in DataContext.Users)
                {
                    if (user.Email == email)
                    {
                        Console.WriteLine("Write your message : ");
                        string message = Console.ReadLine()!;
                        user.Messages.Add(message);
                    }
                }
            }
        }
    }
}
