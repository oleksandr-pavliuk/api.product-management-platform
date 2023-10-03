using api.product_management_platform.Entities.Common;

namespace api.product_management_platform.Entities;

public class Order : BaseEntity
{
    public int ProductId { get; private set; }
    public Product Product {  get; private set; }
    public decimal Cost { get; private set; }
    public uint Count { get; private set; }
    public int CustomerId { get; private set; }
    public Customer Customer { get; private set; }

    public Order(DateTime updatedAt, int productId, decimal cost, uint count, int customerId) : base(DateTime.UtcNow,
        updatedAt)
    {
        ProductId = productId;
        Cost = cost;
        Count = count;
        CustomerId = customerId;
    }
}