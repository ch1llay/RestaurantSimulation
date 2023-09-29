using Common.Enums;

namespace Service.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public EmployeeType EmployeeType { get; set; }
}