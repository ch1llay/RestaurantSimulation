using Service.Items;
using Service.Performers.Interfaces;

namespace Service.Performers.Cooks;

public class HotCook : Cook
{
    public override ReadyItem Prepare(MenuItem? item)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<ReadyItem> Prepare(IEnumerable<MenuItem> sourceItems)
    {
        throw new NotImplementedException();
    }
}