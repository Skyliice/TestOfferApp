using Microsoft.EntityFrameworkCore;

namespace SPA_Offer_App.Models;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<Offer> Offers { get; set; }
}