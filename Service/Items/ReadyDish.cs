using Common.Enums;

namespace Service.Items;

public class ReadyDish : ReadyItem
{
    public MenuItem MenuItem { get; private set; }

    public ReadyDish(MenuItem menuItem)
    {
        MenuItem = menuItem;
    }
    public string Emoji { get; private set; }
    public string Name { get; private set; }
    public bool IsNeedSpoon { get; private set; }
    public bool IsNeedFork { get; private set; }

    public override MenuItemType MenuItemType => MenuItemType.Dish;

    public ReadyDish AddSpoon()
    {
        IsNeedSpoon = true;

        return this;
    }

    public ReadyDish AddFork()
    {
        IsNeedSpoon = true;

        return this;
    }

    public ReadyDish AddEmoji(string emoji)
    {
        Emoji = emoji;

        return this;
    }
    
    public ReadyDish AddName(string name)
    {
        Name = name;

        return this;
    }
}