using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManagement.Database.Models;

namespace Classwork_5.Database.Models
{
    public class Message
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }


        public Message(string name, string lastName, string email, string content)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Content = content;
        }

        public void GetMessages()
        {

        }
    }

}
