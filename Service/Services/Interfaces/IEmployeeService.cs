using Models.Application;
using Models.Enums;

namespace Service.Services.Interfaces;

public interface IEmployeeService : ICrudService<Employee, EmployeeType> { }