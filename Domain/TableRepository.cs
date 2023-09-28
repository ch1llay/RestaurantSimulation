using DataAccess.Interfaces;
using DataAccess.Sql;
using Domain.Interfaces;
using Models.Domain;

namespace Domain;

public class TableRepository : ITableRepository
{
    private readonly IDataContext _dataContext;

    public TableRepository(IDataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public Task<IEnumerable<DbTable>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbTable>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbTable> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbTable> Add(DbTable model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<DbTable> dbEmployees)
    {
        throw new NotImplementedException();
    }

    public async Task<DbTable?> GetAvailableByPeopleCapacity(int peopleAmount)
    {
        return await _dataContext.FirstOrDefaultAsync<DbTable>(Sql.GetAvailableTableByPeopleCapacity, peopleAmount);
    }
}