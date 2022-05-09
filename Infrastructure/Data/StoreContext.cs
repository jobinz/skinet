using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class StoreContext : DbContext
{
    /// <summary>
    /// Store context constructor
    /// </summary>
    /// <param name="options"></param>
    /// <returns></returns>
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
} 