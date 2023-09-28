namespace Models.Domain;

public class ProducDish
{
    public int Id { get; set; }
    public int DishId { get; set; }
    public int ProductId { get; set; }
    public int ProductAmount { get; set; }
}