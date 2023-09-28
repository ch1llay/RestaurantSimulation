using Models.Enums;

namespace Models.Application;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public EmployeeType EmployeeType { get; set; }
    public EmployeeRang EmployeeRang { get; set; }
}