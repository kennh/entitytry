using System;

namespace entitytry.Models
{
    // All dbsets need to be exactly the same as in the database
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public DateTime created_at { get;set; }
        public DateTime updated_at { get;set; }
    }
}