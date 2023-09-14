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

        // Configure the one-to-many relationship between Owner and Pet
        builder.Entity<ApplicationUser>()
            .HasMany(o => o.Pets)  // An owner can have many pets
            .WithOne(p => p.Owner) // Each pet has one owner
            .HasForeignKey(p => p.OwnerId);
    }

    public DbSet<KalahariCollarV13.Models.Pet> Pet { get; set; } = default!;
}
