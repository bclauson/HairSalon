using Microsoft.EntityFrameworkCore;

namespace SalonTracker.Models
{
  public class SalonTrackerContext : DbContext
  {
    public DbSet<stylists> Stylists { get; set; }
    public DbSet<clients> Clients { get; set; }

    public SalonTrackerContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}