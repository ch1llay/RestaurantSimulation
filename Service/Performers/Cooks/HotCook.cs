using Models.Application;
using Service.Performers.Interfaces;

namespace Service.Performers;

public class HotCook : Cook
{
    public override ReadyOrderItem Prepare(OrderItem? item)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<ReadyOrderItem> Prepare(IEnumerable<OrderItem> sourceItems)
    {
        throw new NotImplementedException();
    }
}