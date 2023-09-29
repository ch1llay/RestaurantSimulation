using Service.Items;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class HotTonicBarman : Barman
{
    public override ReadyItem Prepare(MenuItem? item)
    {
        return new ReadyDrink(item)
            .AddEmoji("☕️")
            .AddPlate();
    }
}