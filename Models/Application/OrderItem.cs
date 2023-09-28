using Models.Enums;

namespace Models.Application;

public class OrderItem
{
    public virtual OrderItemType OrderItemType { get; }
}