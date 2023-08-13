using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
  public class PierresTreatsContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<FlavoredTreat> FlavorTreats { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public PierresTreatsContext(dbContextOptions options) : base(options) { }
  }
}