using Common.Enums;

namespace Service.Items;

public class ReadyDrink : ReadyItem
{
    public MenuItem MenuItem { get; private set; }

    public ReadyDrink(MenuItem menuItem)
    {
        MenuItem = menuItem;
    }
    public string Emoji { get; private set; }
    public bool IsNeedStraw { get; private set; }
    public bool IsNeedIce { get; private set; }
    public bool IsNeedPlate { get; private set; }
    public override MenuItemType MenuItemType => MenuItemType.Drink;

    public ReadyDrink AddStraw()
    {
        IsNeedStraw = true;

        return this;
    }

    public ReadyDrink AddIce()
    {
        IsNeedStraw = true;

        return this;
    }

    public ReadyDrink AddPlate()
    {
        IsNeedStraw = true;

        return this;
    }

    public ReadyDrink AddEmoji(string emoji)
    {
        Emoji = emoji;

        return this;
    }
}