using Service.Items;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class AlcoBarmen : Barman
{
    public override ReadyItem Prepare(MenuItem? item)
    {
        return new ReadyDrink().AddEmoji("🍷").AddIce();
    }
}