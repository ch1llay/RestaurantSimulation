using Models.Enums;

namespace Models.DTO;

public class DbEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TimeSpan WorkExperience { get; }
    public EmployeeType EmployeeType { get; set; }
    public EmployeeRang EmployeeRang { get; set; }
}