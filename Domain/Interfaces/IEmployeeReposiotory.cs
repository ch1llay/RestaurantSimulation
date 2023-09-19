using Models.DTO;
using Models.Enums;

namespace Domain.Interfaces;

public interface IEmployeeRepository : IRepository<DbEmployee>
{
    public IEnumerable<DbEmployee> GetByEmployeeType(EmployeeType employeeType);
}