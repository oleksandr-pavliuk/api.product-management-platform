namespace api.product_management_platform.Infrastructure.Persistence.DatabaseContext;

public interface IApplicationContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}