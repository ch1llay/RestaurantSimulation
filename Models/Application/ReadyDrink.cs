using Models.Enums;

namespace Models.Application;

public class ReadyDrink
{
    public GlassType GlassType { get; set; }
    public bool IsStraw { get; set; }
    public Drink Drink { get; set; }
}