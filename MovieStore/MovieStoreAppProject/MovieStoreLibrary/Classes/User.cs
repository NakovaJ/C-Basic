using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Classes
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public SubscriptionTYpe TypeOfSubscription { get; set; }
        public Movie[] RentedMovies { get; set; }
        public User()
        {
            Role = AppRole.User;
        }
        public User(string name, string lastName, int age, string userName, string password, int phone, string registrationDate, int id, string typeOfSubscription, Movie[]rentedMovies)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phone;
            DateOfRegisteration = DateTime.Parse(registrationDate);
            Role = AppRole.User;
            MemberNumber = id;
            if (typeOfSubscription == "m")
            {
                TypeOfSubscription = SubscriptionTYpe.Monthly;
            }
            if (typeOfSubscription == "a")
            {
                TypeOfSubscription = SubscriptionTYpe.Annually;

            };
            RentedMovies = rentedMovies;

        }

       
        

    }
}
