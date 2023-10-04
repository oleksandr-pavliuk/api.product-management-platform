using api.product_management_platform.Domain.Common;

namespace api.product_management_platform.Domain.Entities;

public class Incoming : BaseEntity
{
    public int ProductId { get; private set; }
    public Product Product { get; private set; }
    public uint Count { get; private set; }

    public Incoming(DateTime updatedAt, int productId, uint count) : base(DateTime.UtcNow, updatedAt)
    {
        ProductId = productId;
        Count = count;
    }
}