#nullable disable
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechHands.Api.Data.Entities;

namespace TechHands.Api.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string> 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}

    public DbSet<Client> Clients { get; set; }
    public DbSet<Technician> Technicians { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Issue> Issues { get; set; }
    public DbSet<Part> Parts { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Reply> Replies { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // builder.Entity<Appointment>()
        //     .HasOne(a => a.Review)
        //     .WithOne(r => r.Appointment)
        //     .HasForeignKey<Appointment>(a => a.ReviewId);

        builder.SeedRoles();
    }

    public override int SaveChanges()
    {
        var changedEntities = ChangeTracker.Entries();

        foreach (var changedEntity in changedEntities)
        {
            if (changedEntity.Entity is Entity)
            {
                var entity = changedEntity.Entity as Entity;
                if (changedEntity.State == EntityState.Added)
                {
                    entity.Created = DateTime.Now;
                    entity.Updated = DateTime.Now;

                }
                else if (changedEntity.State == EntityState.Modified)
                {
                    entity.Updated = DateTime.Now;
                }
            }

        }
        return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        var changedEntities = ChangeTracker.Entries();

        foreach (var changedEntity in changedEntities)
        {
            if (changedEntity.Entity is Entity)
            {
                var entity = changedEntity.Entity as Entity;
                if (changedEntity.State == EntityState.Added)
                {
                    entity.Created = DateTime.Now;
                    entity.Updated = DateTime.Now;

                }
                else if (changedEntity.State == EntityState.Modified)
                {
                    entity.Updated = DateTime.Now;
                }
            }
        }
        return (await base.SaveChangesAsync(true, cancellationToken));
    }

}
