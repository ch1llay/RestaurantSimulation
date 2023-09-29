using Service.Items;
using Service.Models;
using Service.Workplaces.Interfaces;

namespace Service.Workplaces;

public class Bar : WorkPlace
{
    public override Employee Employee { get; set; }

    public override ReadyItem? Modify(ReadyItem orderItem)
    {
        var drink = orderItem as ReadyDrink;

        drink?.AddEmployee(Employee);

        return drink;
    }

    public Bar(Employee? employee) : base(employee) { }
}