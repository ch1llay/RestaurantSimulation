using Domain.Interfaces;
using Models.DTO;
using Models.Enums;

namespace Domain;

public class EmployeeRepository : IEmployeeRepository
{
    public IEnumerable<DbEmployee> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public DbEmployee Get(int id)
    {
        throw new NotImplementedException();
    }

    public int Add(DbEmployee model)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbEmployee> AddRange(IEnumerable<DbEmployee> models)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbEmployee> GetByEmployeeType(EmployeeType employeeType)
    {
        throw new NotImplementedException();
    }
}