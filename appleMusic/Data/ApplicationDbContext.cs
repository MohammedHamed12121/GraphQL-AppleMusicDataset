using appleMusic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace appleMusic.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Collection> Collections { get; set; }
    public DbSet<Track> Tracks { get; set; }
}
