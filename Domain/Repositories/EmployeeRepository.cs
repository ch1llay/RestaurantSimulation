using Common.Enums;
using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Models;
using Domain.Repositories.Interfaces;
using Domain.Sql.Employee;

namespace Domain.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly IDataContext _dataContext;

    public EmployeeRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public async Task<IEnumerable<DbEmployee>> GetAll()
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbEmployee>(Employee.GetAllEmployees, new { });
    }

    public async Task<DbEmployee> Add(DbEmployee model)
    {
        return await _dataContext.InsertAsync<DbEmployee>(Employee.InsertEmployee, model);
    }

    public async Task<IEnumerable<DbEmployee>> GetByType(EmployeeType type)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbEmployee>(Employee.GetEmployeesByType, new {employeeType = type});
    }

    public async Task<IEnumerable<DbEmployee>> GetByIds(IEnumerable<int> ids)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbEmployee>(Employee.GetEmployeeByIds, new {ids});
    }

    public async Task<DbEmployee> GetById(int id)
    {
        return await _dataContext.FirstOrDefaultAsync<DbEmployee>(Employee.GetEmployeeByIds, new {ids = new List<int> {id}});
    }
}