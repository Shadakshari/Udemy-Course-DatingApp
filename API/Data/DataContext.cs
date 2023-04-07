using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // DbSet represents table inside the database. Table name is going to be Users.
        public DbSet<AppUser> Users { get; set; }
    }
}