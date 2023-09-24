using DataAccess.Interfaces;
using DataAccess.Sql;
using Domain.Interfaces;
using Models.DbModels;
using Models.Enums;

namespace Domain;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly IDataContext _dataContext;

    public EmployeeRepository(IDataContext dataContext)
    {
        _dataContext = dataContext;
    }

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

    public async Task<DbEmployee> Add(DbEmployee model)
    {
        var id = await _dataContext.InsertAsync<int>(Sql.InsertEmployee, new {Name = "Bob"});
        model.Id = id;

        return model;
    }
}