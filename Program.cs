using System.IO;
using entitytry.Models;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using System;
using System.Collections.Generic;

namespace entitytry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var db = new YourContext())
            {
                //  This should Add a new user to the database by first constructing a new User object
                // User NewPerson = new User
                // {
                //     Name = "Name",
                //     Email = "example@example.com",
                //     Password = "password",
                //     Age = 24,
                //     created_at = DateTime.Now,
                //     updated_at = DateTime.Now
                // };
                // db.Add(NewPerson);
                // db.SaveChanges();
                // var;
            
                //perform database interactions
                // var TableContents = GetTableContents(db);
              
                
                // Updating and saving changes to the database
                // RetrievedUser.Name = "New name";
                // db.Add(NewPerson);
                // User ReturnedValue = db.users.Where(user => user.UserId == 3).SingleOrDefault();
                User RetrievedUser = db.users.SingleOrDefault(user => user.UserId == 3);
                db.users.Remove(RetrievedUser);
                db.SaveChanges();
                // List<User> RetrievedUser = db.Users.Where(user => user.Age == 24).ToList();
            }


        }
    }
}
