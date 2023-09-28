using Models.Application;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class GeneralBarmen : Barman
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