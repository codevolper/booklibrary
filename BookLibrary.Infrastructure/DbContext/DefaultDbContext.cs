using BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookLibrary.Infrastructure;

/// <summary>
/// DefaultDbContext is the default implementation of the DbContext for the BookLibrary application.
/// </summary>
public class DefaultDbContext : DbContext
{
    #region DbSets entities
    public DbSet<Book> Books { get; set; }
    #endregion

    #region Constructor
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {

    }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
