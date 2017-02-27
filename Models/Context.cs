using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;
namespace entitytry.Models
{
    public class YourContext : DbContext
    {
        // this is the setup to work with our database  all dbsets NEED TO BE EXACTLY THE SAME AS IN THE DATABASE
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Server = "localhost";
            string Port = "3306"; //or 8889 on Mac
            string Database = "entitydb";
            string UserId = "root";
            string Password = "root";
            string Connection = $"Server={Server};port={Port};database={Database};uid={UserId};pwd={Password};SslMode=None;";
            optionsBuilder.UseMySQL(Connection);
        }
        public DbSet<User> users { get; set; }
    }
}