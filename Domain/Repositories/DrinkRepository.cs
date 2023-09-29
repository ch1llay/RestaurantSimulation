using Common.Enums;
using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Models;
using Domain.Repositories.Interfaces;

namespace Domain.Repositories;

public class DrinkRepository : IDrinkRepository
{
    private readonly IDataContext _dataContext;

    public DrinkRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public Task<IEnumerable<DbDrink>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbDrink> Add(DbDrink model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbDrink>> GetByType(DrinkType type)
    {
        throw new NotImplementedException();
    }
}