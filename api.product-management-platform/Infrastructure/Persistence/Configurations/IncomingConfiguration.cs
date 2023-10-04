using api.product_management_platform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.product_management_platform.Infrastructure.Persistence.Configurations;

public class IncomingConfiguration : IEntityTypeConfiguration<Incoming>
{
    public void Configure(EntityTypeBuilder<Incoming> builder)
    {
        builder
            .HasOne(x => x.Product)
            .WithMany(x => x.Incomings);
    }
}