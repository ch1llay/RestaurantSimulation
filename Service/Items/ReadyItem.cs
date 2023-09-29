using Service.Models;

namespace Service.Items;

public class ReadyItem : MenuItem
{
    public Employee PerformerEmployee { get; set; }

    public ReadyItem AddEmployee(Employee employee)
    {
        PerformerEmployee = employee;

        return this;
    }
}