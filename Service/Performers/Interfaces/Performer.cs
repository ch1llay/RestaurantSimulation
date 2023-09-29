using Service.Items;

namespace Service.Performers.Interfaces;

public abstract class Performer
{
    public abstract ReadyItem Prepare(MenuItem? item);

    public IEnumerable<ReadyItem> Prepare(IEnumerable<MenuItem> sourceItems)
    {
        foreach (var item in sourceItems) yield return Prepare(item);
    }
}