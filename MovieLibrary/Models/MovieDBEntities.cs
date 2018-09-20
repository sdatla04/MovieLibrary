
using System.Data.Entity;

namespace MovieLibrary.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public ApplicationDbContext() 
            //: base("name=DefaultConnection")
        {
            //< add name = "DefaultConnection" 
            //connectionString = "Data Source=(LocalDb)\v11.0;Initial Catalog=aspnet-eManager.Web-20140216202751;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\aspnet-eManager.Web-20140216202751.mdf" 
            //providerName = "System.Data.SqlClient" />

        }
    }
}