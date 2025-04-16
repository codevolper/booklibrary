using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace BookLibrary.Infrastructure;

/// <summary>
/// This class is used by EF Core to create a new instance of the DbContext at design time
/// </summary>
public class DefaultDbContextFactory : IDesignTimeDbContextFactory<DefaultDbContext>
{
    /// <summary>
    /// Creates a new instance of the DbContext with the specified options.
    /// </summary>
    /// <param name="args"></param>
    /// <returns>Return a database connection</returns>
    public DefaultDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var builder = new DbContextOptionsBuilder<DefaultDbContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        builder.UseSqlServer(connectionString, options =>        
            options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)         
        );

        return new DefaultDbContext(builder.Options);
    }
}
