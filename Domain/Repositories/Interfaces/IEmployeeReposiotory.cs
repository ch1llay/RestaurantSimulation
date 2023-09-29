using Common.Enums;
using Domain.Models;

namespace Domain.Repositories.Interfaces;

public interface IEmployeeRepository : IRepository<DbEmployee, EmployeeType>
{
}