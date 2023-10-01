using Service.Items;
using Service.Performers.Interfaces;

namespace Service.Performers.Cooks;

public class ConfectioneryCook : Cook
{
    public override ReadyItem Prepare(MenuItem? item)
    {
        return new ReadyDish(item)
            .AddEmoji("🍰")
            .AddTeaSpoon();
    }
}