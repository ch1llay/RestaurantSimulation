using Models.Application;
using Models.Enums;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class BarmanMaster : Barman
{
    public Dictionary<DrinkType, Barman> _performers = new Dictionary<DrinkType, Barman>
    {
        {DrinkType.Wine, new GeneralBarmen()},
        {DrinkType.HotTonic, new GeneralBarmen()},
        {DrinkType.Strong, new GeneralBarmen()}
    };
    public override ReadyOrderItem Prepare(OrderItem? item)
    {
        var drink = item as Drink;
        return _performers[drink.DrinkType].Prepare(drink);

    }

    public override IEnumerable<ReadyOrderItem> Prepare(IEnumerable<OrderItem> sourceItems)
    {
        foreach (var sourceItem in sourceItems)
        {
            yield return Prepare(sourceItem);
        }
    }
}