using ASP.NETCoreIdentityCustom.Areas.Identity.Data;
using ASP.NETCoreIdentityCustom.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP.NETCoreIdentityCustom.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Students> Students { get; set; }
    public DbSet<Teacher> Teacher { get; set; }
    public DbSet<Demande> Demande { get; set; }
    public DbSet<reclamation> reclamation { get; set; }
    public DbSet<Demande> Course { get; set; }

    public DbSet<Club> Club { get; set; }
    public DbSet<Clubs> Clubs { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Students>()
          .ToTable("Students");
        builder.Entity<Teacher>()
          .ToTable("Teacher");
        builder.Entity<Demande>()
          .ToTable("Demande");
        builder.Entity<reclamation>()
          .ToTable("reclamation");
        builder.Entity<Courses>()
          .ToTable("Course");
        builder.Entity<Club>()
          .ToTable("club");
        builder.Entity<Clubs>()
         .ToTable("clubs");
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}
