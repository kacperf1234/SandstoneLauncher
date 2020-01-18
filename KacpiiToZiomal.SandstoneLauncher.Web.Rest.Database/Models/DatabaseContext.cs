using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models
{
    public class DatabaseContext : DbContext
    {
        private readonly string ConnectionString;

        public DatabaseContext()
        {
            Initialize();
        }

        public DatabaseContext(string connectionString)
        {
            ConnectionString = connectionString ?? StaticConstants.TestConnectionString;
            Initialize();
        }

        public DbSet<UserCredentials> UserCredentials { get; set; }

        public DbSet<UserToken> UserTokens { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<DeveloperCredentials> DeveloperCredentials { get; set; }

        public DbSet<Developer> Developers { get; set; }

        public DbSet<DeveloperToken> DeveloperTokens { get; set; }

        public DbSet<RestRequest> RestRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString ?? StaticConstants.TestConnectionString);
        }

        void Initialize()
        {
            Database.OpenConnection();
            Database.Migrate();
            Database.EnsureCreated();
        }
    }
}