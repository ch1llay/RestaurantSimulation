using Service.Items;
using Service.Performers.Interfaces;

namespace Service.Performers.Cooks;

public class ColdCook : Cook
{
    public override ReadyItem Prepare(MenuItem? item)
    {
        return new ReadyDish().AddEmoji("🥗").AddFork();
    }
}