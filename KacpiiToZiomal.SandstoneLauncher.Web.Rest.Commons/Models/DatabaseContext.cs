using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserCredentials> UserCredentials { get; set; }

        private readonly string ConnectionString;

        public DatabaseContext()
        {
        }

        public DatabaseContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString ?? StaticConstants.TestConnectionString);
        }
    }
}