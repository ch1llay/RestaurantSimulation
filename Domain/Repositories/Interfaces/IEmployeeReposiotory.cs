using Models.Domain;
using Models.Enums;

namespace Domain.Repositories.Interfaces;

public interface IEmployeeRepository : IRepository<DbEmployee>
{
    public Task<IEnumerable<DbEmployee>> GetByEmployeeType(EmployeeType employeeType);
}