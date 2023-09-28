using Models.Application;

namespace Service.Performers.Interfaces;

public abstract class Performer
{
    public abstract ReadyOrderItem Prepare(OrderItem? item);
    public abstract IEnumerable<ReadyOrderItem> Prepare(IEnumerable<OrderItem> sourceItems);
}