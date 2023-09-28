namespace Models.Application;

public class Order
{
    public IEnumerable<int> DishIds { get; set; }
    public IEnumerable<int> DrinkIds { get; set; }
    public IEnumerable<int> ProductIdsForExcept { get; set; }
    public int PeopleAmount { get; set; }
}