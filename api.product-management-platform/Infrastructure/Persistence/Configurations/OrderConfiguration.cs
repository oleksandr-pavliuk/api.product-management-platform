using api.product_management_platform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.product_management_platform.Infrastructure.Persistence.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
            .HasOne(x => x.Customer)
            .WithMany(x => x.Orders);

        builder
            .HasOne(x => x.Product)
            .WithMany(x => x.Orders);
    }
}