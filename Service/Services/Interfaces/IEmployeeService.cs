using Models.Application;
using Models.Domain;
using Models.Enums;

namespace Service.Services.Interfaces;

public interface IEmployeeService : ICrudService<Employee, EmployeeType>
{
}