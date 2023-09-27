using Models.Enums;

namespace Models.Domain;

public class DbDrink
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DrinkType DrinkType { get; set; }
    public int Volume { get; set; }
}