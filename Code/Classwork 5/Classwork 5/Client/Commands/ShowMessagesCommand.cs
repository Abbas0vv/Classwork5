using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;

namespace Classwork_5.Client.Commands
{
    public class ShowMessagesCommand
    {
        public static void Handle(User user)
        {
            int order = 1;

            foreach (string message in user.Messages)
            {
                Console.WriteLine($"{order}. From {user.Sender} Message : ");
                Console.WriteLine(message);
                order++;
            }
        }
    }
}
