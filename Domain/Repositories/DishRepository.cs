using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Domain;
using Models.Enums;

namespace Domain.Repositories;

public class DishRepository : IDishRepository
{
    private readonly IDataContext _dataContext;

    public DishRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public Task<IEnumerable<DbDish>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbDish>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbDish> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbDish> Add(DbDish model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbDish>> AddRange(IEnumerable<DbDish> dbEmployees)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbCookingDish> GetByType(DishType dishType)
    {
        throw new NotImplementedException();
    }
}