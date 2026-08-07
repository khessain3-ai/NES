using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NES.Infrastructure.Data;

public class NESDbContextFactory : IDesignTimeDbContextFactory<NESDbContext>
{
    public NESDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<NESDbContext>();

        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;Database=NESDb;Trusted_Connection=True;TrustServerCertificate=True");

        return new NESDbContext(optionsBuilder.Options);
    }
}