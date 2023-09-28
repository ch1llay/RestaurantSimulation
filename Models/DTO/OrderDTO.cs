using Models.Application;
using Models.Application.Items;

namespace Models.DTO;

public class OrderDTO
{
    public List<ReadyDish?> Dishes { get; set; }
    public List<ReadyDrink?> Drinks { get; set; }
    public decimal TotalAmount { get; set; }
}