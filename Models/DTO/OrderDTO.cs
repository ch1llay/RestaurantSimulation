using Models.Application;

namespace Models.DTO;

public class OrderDTO
{
    public List<ReadyDish?> Dishes { get; set; }
    public List<ReadyDrink?> Drinks { get; set; }
}