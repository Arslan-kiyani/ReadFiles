using Microsoft.EntityFrameworkCore;
using ReadFile_Mini.Models;

namespace ReadFile_Mini.Context
{
    public class SeniorDb : DbContext
    {
        public SeniorDb(DbContextOptions<SeniorDb> options) : base(options)
        {
        }

        public DbSet<UserTable> UserTable { get; set; }
        public DbSet<Trip> Trip { get; set; }
        public DbSet<UserTrip> UserTrip { get; set; }
        public DbSet<HouseState> HouseStates { get; set; }
        public DbSet<JournalByDate> journalByDates { get; set; }
        
        public DbSet<ExcelsFiles> ExcelsFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your model here if needed
            modelBuilder.Entity<Trip>()
                .HasKey(t => t.TripId); // Define the primary key
        }
    }
}
