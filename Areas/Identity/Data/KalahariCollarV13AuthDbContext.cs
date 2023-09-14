using KalahariCollarV13.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KalahariCollarV13.Models;

namespace KalahariCollarV13.Data;

public class KalahariCollarV13AuthDbContext : IdentityDbContext<ApplicationUser>
{
    public KalahariCollarV13AuthDbContext(DbContextOptions<KalahariCollarV13AuthDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<KalahariCollarV13.Models.Pet> Pet { get; set; } = default!;
}
