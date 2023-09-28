namespace Models.Domain;

public class DbCookingDrink
{
    public int Id { get; set; }
    public int DrinkId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int OrderId { get; set; }
}