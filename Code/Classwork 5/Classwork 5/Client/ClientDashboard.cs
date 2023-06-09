﻿using Classwork_5.Client.Commands;
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
                    case "/sent-messages":
                        SentMessagesCommandForUser.Handle(user);
                        break;
                    case "/update-settings":
                        UpdateSettingsCommandForUsers.Handle(user);
                        break;
                    case "/show-messages":
                        ShowMessagesCommand.Handle(user);
                        break;
                    case "/close-account":
                        RemoveUserCommandForUsers.Handle(user);
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