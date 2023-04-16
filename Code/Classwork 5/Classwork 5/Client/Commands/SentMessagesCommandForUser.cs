using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database.Models;
using TaskManagement.Database;

namespace Classwork_5.Client.Commands
{
    public class SentMessagesCommandForUser
    {
        public static void Handle(User user)
        {
            UserValidator validator = new UserValidator();

            Console.Write("Who will it be sent to : ");
            string email = Console.ReadLine()!;

            if (validator.IsEmailExists(email))
            {
                foreach (User human in DataContext.Users)
                {
                    if (human.Email == email)
                    {
                        Console.WriteLine("Write your message : ");
                        string message = Console.ReadLine()!;
                        human.Messages.Add(message);
                        human.Sender = $"{user.Name} {user.LastName} ({user.Email})";
                    }
                }
            }
        }
    }
}
