using Common.Enums;

namespace Domain.Models;

public class DbEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public EmployeeType EmployeeType { get; set; }
}