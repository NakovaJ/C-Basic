using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;

namespace ClassLibrary.Models
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public AcademyRole Role {get;set;}
        public AcademyGroup Group { get; set; }

        public Member()
        {

        }
        public Member(AcademyRole setter)
        {
            Role = setter;
        }

    }
}
