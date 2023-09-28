using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Domain.Sql.Employee;
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
        var ids = (await _dataContext.InsertManyAsync(SqlEmployee.InsertEmployee, dbEmployees)).ToList();

        var i = 0;

        foreach (var model in dbEmployees)
        {
            model.Id = ids[i];
            i++;
        }

        return dbEmployees;
    }

    public async Task<IEnumerable<DbEmployee>> GetByEmployeeType(EmployeeType employeeType)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbEmployee>(SqlEmployee.GetAllEmployees, new {employeeType});
    }

    public async Task<IEnumerable<DbEmployee>> Get(IEnumerable<int> ids)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbEmployee>(SqlEmployee.GetEmployeesByIds, new {ids});
    }

    public async Task<IEnumerable<DbEmployee>> GetAll()
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbEmployee>(SqlEmployee.GetAllEmployees, new { });
    }

    public async Task<DbEmployee?> Get(int id)
    {
        return await _dataContext.FirstOrDefaultAsync<DbEmployee>(SqlEmployee.InsertEmployee, new {id});
    }

    public async Task<DbEmployee> Add(DbEmployee model)
    {
        var id = await _dataContext.InsertAsync<int>(SqlEmployee.InsertEmployee, model);
        model.Id = id;

        return model;
    }
}