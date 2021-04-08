using System;
using System.Collections.Generic;
using System.Text;

namespace CreateLoginRegisterC.ClassesCreated
{
    public class User
    {
        //properties
        public int Id { get; set; }
        public string Username{get;set;}

        public string Password { get; set; }

        public string [] Messages { get; set; }

        public User()
        {

        }
        public User(int id,string username,string password, string[] messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages;
        }

        public void DisplayMessages()
        {
           
            if (Messages.Length == 0)
            {
                Console.WriteLine( "No messegaes yet!");
            }
           
                foreach (string item in Messages)
                {
                    Console.WriteLine(item);
                }
            
        }

    }
}
