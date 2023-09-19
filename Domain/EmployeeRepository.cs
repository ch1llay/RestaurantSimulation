using Domain.Interfaces;
using Models.DTO;
using Models.Enums;

namespace Domain;

public class EmployeeRepository : IEmployeeRepository
{
    public IEnumerable<DbEmployee> AddRange(IEnumerable<DbEmployee> models)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbEmployee> GetByEmployeeType(EmployeeType employeeType)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbEmployee>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<DbEmployee> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbEmployee> Add(DbEmployee model)
    {
        throw new NotImplementedException();
    }
}