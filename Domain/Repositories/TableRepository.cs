using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Domain;

namespace Domain.Repositories;

public class TableRepository : ITableRepository
{
    private readonly IDataContext _dataContext;

    public TableRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public Task<IEnumerable<DbDbTable>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbDbTable>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbDbTable> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbDbTable> Add(DbDbTable model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbDbTable>> AddRange(IEnumerable<DbDbTable> dbEmployees)
    {
        throw new NotImplementedException();
    }

    public async Task<DbDbTable?> GetAvailableByPeopleCapacity(int peopleAmount)
    {
        return await _dataContext.FirstOrDefaultAsync<DbDbTable>("", peopleAmount);
    }
}