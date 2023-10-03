using api.product_management_platform.Entities.Common;

namespace api.product_management_platform.Entities;

public class Product : BaseEntity
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Amount { get; private set; }

    public IList<Order> Orders { get; private set; } = new List<Order>();
    public IList<Incoming> Incomings { get; private set; } = new List<Incoming>();

    public Product(DateTime updatedAt, string name, decimal price, int amount) : base(DateTime.UtcNow, updatedAt)
    {
        Name = name;
        Price = price;
        Amount = amount;
    }
}