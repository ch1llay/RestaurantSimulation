using Service.Items;

namespace Service.Performers.Interfaces;

public abstract class Performer
{
    public abstract ReadyItem Prepare(MenuItem? item);
    public abstract IEnumerable<ReadyItem> Prepare(IEnumerable<MenuItem> sourceItems);
}