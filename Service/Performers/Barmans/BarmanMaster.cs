using Common.Enums;
using Service.Items;
using Service.Models;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class BarmanMaster : Barman
{
    public Dictionary<DrinkType, Barman> _performers = new()
    {
        {DrinkType.Alco, new AlcoBarmen()},
        {DrinkType.HotTonic, new HotTonicBarman()},
        {DrinkType.NotAlco, new NotAlcoBarmen()}
    };

    public override ReadyItem Prepare(MenuItem? item)
    {
        var drink = item as Drink;

        return _performers[drink.DrinkType].Prepare(drink);
    }
}