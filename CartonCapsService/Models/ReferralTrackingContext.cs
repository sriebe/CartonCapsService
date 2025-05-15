using Microsoft.EntityFrameworkCore;

namespace CartonCapsService.Models
{
    public class ReferralTrackingContext : DbContext
    {
        public DbSet<ReferralTracking> ReferralTracking { get; set; }
        public string DbPath { get; }

        public ReferralTrackingContext() 
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "ReferralTracking.db");

            Console.WriteLine(DbPath);

            Database.EnsureCreated();
        }

        // The following configures EF to create a new Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");

    }
}
