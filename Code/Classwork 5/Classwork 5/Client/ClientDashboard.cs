using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Client.Commands;
using TaskManagement.Database.Models;

namespace TaskManagement.Client
{
    public class ClientDashboard
    {
        public static void Introduction(User user)
        {
            Console.WriteLine($"Hello! : {user.Name} {user.LastName}");
            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/update-settings":
                        UpdateSettingsCommandForUsers.Handle();
                        break;
                    case "/close-account":
                        RemoveUserCommandForUsers.Handle();
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}