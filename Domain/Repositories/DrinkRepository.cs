using Common.Enums;
using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Models;
using Domain.Repositories.Interfaces;
using Domain.Sql.Drink;

namespace Domain.Repositories;

public class DrinkRepository : IDrinkRepository
{
    private readonly IDataContext _dataContext;

    public DrinkRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public async Task<IEnumerable<DbDrink>> GetAll()
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDrink>(Drink.GetAllDrinks, new { });
    }

    public async Task<DbDrink> Add(DbDrink model)
    {
        return await _dataContext.InsertAsync<DbDrink>(Drink.InsertDrink, model);
    }

    public async Task<IEnumerable<DbDrink>> GetByType(DrinkType type)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDrink>(Drink.GetDrinksByType, new {dishType=type });
    }

    public async Task<IEnumerable<DbDrink>> GetByIds(IEnumerable<int> ids)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDrink>(Drink.GetDrinkByIds, new {ids=ids });

    }

    public async Task<DbDrink> GetById(int id)
    {
        return await _dataContext.FirstOrDefaultAsync<DbDrink>(Drink.GetDrinkByIds, new {ids=new List<int>{id}});
    }
}