namespace Models.DTO;

public class ProductCookingDish
{
    public int Id { get; set; }
    public int CookingDishesId { get; set; }
    public int ProductId { get; set; }
    public int ProductAmount { get; set; }
}