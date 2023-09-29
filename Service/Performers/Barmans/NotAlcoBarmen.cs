using Service.Items;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class NotAlcoBarmen : Barman
{
    public override ReadyItem Prepare(MenuItem? item)
    {
        return new ReadyDrink()
            .AddEmoji("🧃")
            .AddStraw();
    }
}