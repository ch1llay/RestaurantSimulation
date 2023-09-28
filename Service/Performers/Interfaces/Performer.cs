using Models.Application;
using Models.Application.Items;
using Models.Application.ReadyItems;

namespace Service.Performers.Interfaces;

public abstract class Performer
{
    public abstract ReadyOrderItem Prepare(MenuItem? item);
    public abstract IEnumerable<ReadyOrderItem> Prepare(IEnumerable<MenuItem> sourceItems);
}