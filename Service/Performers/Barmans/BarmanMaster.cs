
using Common.Enums;
using Domain.Models;
using Service.Items;
using Service.Models;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class BarmanMaster : Barman
{
    public Dictionary<DrinkType, Barman> _performers = new()
    {
        {DrinkType.Alco, new GeneralBarmen()},
        {DrinkType.HotTonic, new GeneralBarmen()},
        {DrinkType.NotAlco, new GeneralBarmen()}
    };

    public override ReadyItem Prepare(MenuItem? item)
    {
        var drink = item as Drink;

        return _performers[drink.DrinkType].Prepare(drink);
    }

    public override IEnumerable<ReadyItem> Prepare(IEnumerable<MenuItem> sourceItems)
    {
        foreach (var sourceItem in sourceItems) yield return Prepare(sourceItem);
    }
}