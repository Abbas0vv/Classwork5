﻿namespace TaskManagement.Database.Models
{
    public class User
    {
        public static int IdCounter { get; private set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBanned { get; set; }
        public string Sender { get; set; }
        public List<string> Messages { get; set; }

        public User(string name, string lastName, string password, string email, bool isAdmin = false, bool isBanned = false, List<string> messages = null, string sender = null)
        {
            Id = ++IdCounter;
            Name = name;
            LastName = lastName;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
            IsBanned = isBanned;
            Messages = messages ?? new List<string>();
            Sender = sender;
        }

        public string GetShortInfo()
        {
            return $"Id : {Id}, Full name : {Name} {LastName}, Email : {Email}, Is admin : {GetIsAdminInfo()}";
        }

        public string GetIsAdminInfo()
        {
            return IsAdmin ? "Yes" : "No";
        }
    }
}