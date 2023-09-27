namespace Models.Application;

public class Order
{
    public List<int> DishIds { get; set; }
    public List<int> DrinkIds { get; set; }
    public List<int> ProductIdsForExcept { get; set; }
    public int PeopleAmount { get; set; }
}