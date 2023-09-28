using Models.Enums;

namespace Models.Application.Items;

public class MenuItem
{
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public List<Product> Products { get; set; }
    public virtual MenuItemType MenuItemType { get; }
}