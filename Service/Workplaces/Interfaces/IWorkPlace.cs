using Service.Items;
using Service.Models;

namespace Service.Workplaces.Interfaces;

public abstract class WorkPlace
{
    public abstract Employee Employee { get; set; }

    public WorkPlace(Employee employee)
    {
        Employee = employee;
    }

    public abstract ReadyItem? Modify(ReadyItem orderItem);
}