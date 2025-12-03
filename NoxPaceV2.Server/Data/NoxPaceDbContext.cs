using Microsoft.EntityFrameworkCore;
using NoxPaceV2.Server.Models;

namespace NoxPaceV2.Server.Data
{
    public class NoxPaceDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public NoxPaceDbContext(DbContextOptions<NoxPaceDbContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>().ToTable("users");
        }


    }
}
