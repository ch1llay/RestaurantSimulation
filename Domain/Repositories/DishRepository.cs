using Common.Enums;
using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Models;
using Domain.Repositories.Interfaces;

namespace Domain.Repositories;

public class DishRepository : IDishRepository
{
    private readonly IDataContext _dataContext;

    public DishRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public Task<IEnumerable<DbDish>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<DbDish> Add(DbDish model)
    {
        return await _dataContext.InsertAsync<DbDish>("", model);
    }

    public Task<IEnumerable<DbDish>> GetByType(DishType type)
    {
        throw new NotImplementedException();
    }
}