using System.Reflection;
using api.product_management_platform.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.product_management_platform.Infrastructure.Persistence.DatabaseContext;

public class ApplicationContext : DbContext, IApplicationContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Incoming> Incomings { get; set; }
    public DbSet<Order> Orders { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options){ }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
} 