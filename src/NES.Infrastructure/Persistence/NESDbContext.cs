using Microsoft.EntityFrameworkCore;

namespace NES.Infrastructure.Persistence;

public sealed class NESDbContext : DbContext
{
    public NESDbContext(DbContextOptions<NESDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(NESDbContext).Assembly);
    }
}