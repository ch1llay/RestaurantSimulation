using Common.Enums;
using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Models;
using Domain.Repositories.Interfaces;

namespace Domain.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly IDataContext _dataContext;

    public EmployeeRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public Task<IEnumerable<DbEmployee>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbEmployee> Add(DbEmployee model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbEmployee>> GetByType(EmployeeType type)
    {
        throw new NotImplementedException();
    }
}