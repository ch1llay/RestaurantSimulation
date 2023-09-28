using Models.Application.Items;
using Models.Application.ReadyItems;
using Service.Performers.Interfaces;

namespace Service.Performers.Cooks;

public class ConfectioneryCook : Cook
{
    public override ReadyOrderItem Prepare(MenuItem? item)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<ReadyOrderItem> Prepare(IEnumerable<MenuItem> sourceItems)
    {
        throw new NotImplementedException();
    }
}