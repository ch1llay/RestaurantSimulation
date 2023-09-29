using Service.Items;
using Service.Models;
using Service.Workplaces.Interfaces;

namespace Service.Workplaces;

public class Kitchen : WorkPlace
{
    public Kitchen(Employee employee) : base(employee) { }
    public override Employee Employee { get; set; }

    public override ReadyItem? Modify(ReadyItem orderItem)
    {
        var dish = orderItem as ReadyDish;

        dish?.AddEmployee(Employee);

        return dish;
    }
}