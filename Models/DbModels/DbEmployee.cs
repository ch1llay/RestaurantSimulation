using Models.Enums;

namespace Models.DbModels;

public class DbEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TimeSpan WorkExperience { get; } = new TimeSpan(1, 1, 1);
    public EmployeeType EmployeeType { get; set; }
    public EmployeeRang EmployeeRang { get; set; }
}