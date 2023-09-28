namespace Models.Domain;

public class DbCookingDish
{
    public int Id { get; set; }
    public int DishId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int OrderId { get; set; }
}