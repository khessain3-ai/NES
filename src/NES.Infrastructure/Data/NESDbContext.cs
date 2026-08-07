using Microsoft.EntityFrameworkCore;
using NES.Domain.Entities.MealPlan;
using NES.Domain.Entities.MealEntry;

namespace NES.Infrastructure.Data;

public class NESDbContext : DbContext
{
    public NESDbContext(DbContextOptions<NESDbContext> options)
        : base(options)
    {
    }

    public DbSet<MealPlan> MealPlans { get; set; }

    public DbSet<Meal> Meals { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(NESDbContext).Assembly);
    }
}