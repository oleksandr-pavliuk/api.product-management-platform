using api.product_management_platform.Entities.Common;

namespace api.product_management_platform.Entities;

public class Customer : BaseEntity
{
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public IList<Order> Orders { get; private set; } = new List<Order>();
    public Customer(DateTime updatedAt, string fullName, string email, string phoneNumber) : base(DateTime.UtcNow, updatedAt)
    {
        FullName = fullName;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}