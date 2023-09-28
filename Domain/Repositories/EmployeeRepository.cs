using DataAccess.DI;
using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using DataAccess.Sql;
using Domain.Repositories.Interfaces;
using Models.Domain;
using Models.Enums;

namespace Domain.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly IDataContext _dataContext;

    public EmployeeRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public async Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<DbEmployee> dbEmployees)
    {
        var ids = (await _dataContext.InsertManyAsync(Sql.InsertEmployee, dbEmployees)).ToList();

        var i = 0;
        foreach (var model in dbEmployees)
        {
            model.Id = ids[i];
            i++;
        }

        return dbEmployees;
    }

    public IEnumerable<DbEmployee> GetByEmployeeType(EmployeeType employeeType)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbEmployee>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbEmployee>> GetAll()
    {
        return _dataContext.EnumerableOrEmptyAsync<DbEmployee>(Sql.GetAllEmployees, new { });
    }

    public Task<DbEmployee> Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<DbEmployee> Add(DbEmployee model)
    {
        var id = await _dataContext.InsertAsync<int>(Sql.InsertEmployee, model);
        model.Id = id;

        return model;
    }
}