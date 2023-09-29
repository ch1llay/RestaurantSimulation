
using Service.Items;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class GeneralBarmen : Barman
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