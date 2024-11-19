using Microsoft.EntityFrameworkCore;
using PostgresEntityFramework.Model;

namespace PostgresEntityFramework;

public class ProfessionDbContext(DbContextOptions<ProfessionDbContext> options) : DbContext(options)
{
    public required DbSet<Profession> Professions { get; set; }

    public required DbSet<Skill> Skills { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Profession>().HasKey(p => p.Id);
        modelBuilder.Entity<Profession>().Property(p => p.Name).IsRequired();
        modelBuilder.Entity<Profession>().Property(p => p.MinEducationLevel).IsRequired().HasDefaultValue(EducationLevel.None);

        modelBuilder.Entity<Skill>().HasKey(s => s.Id);
        modelBuilder.Entity<Skill>().Property(s => s.Name).IsRequired();
        modelBuilder.Entity<Skill>().Property(s => s.Details).IsRequired();

        modelBuilder.Entity<Profession>()
            .HasMany(p => p.Skills)
            .WithOne(s => s.Profession);
    }
}
