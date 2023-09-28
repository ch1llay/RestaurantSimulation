using Models.Application.Items;
using Models.Application.ReadyItems;
using Service.Performers.Interfaces;

namespace Service.Performers.Cooks;

public class ColdCook : Cook
{
    public override ReadyOrderItem Prepare(MenuItem? item)
    {
        var dish = item as Dish;

        return new ReadyDish()
            .SmallPlate().AddFork();
    }

    public override IEnumerable<ReadyOrderItem> Prepare(IEnumerable<MenuItem> sourceItems)
    {
        throw new NotImplementedException();
    }
}