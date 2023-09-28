using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Domain.Sql.Drink;
using Models.Domain;

namespace Domain.Repositories;

public class DrinkRepository : IDrinkRepository
{
    private readonly IDataContext _dataContext;

    public DrinkRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public async Task<IEnumerable<DbDrink>> Get(IEnumerable<int> ids)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDrink>(SqlDrink.GetAllDrinks, new {ids});
    }

    public async Task<IEnumerable<DbDrink>> GetAll()
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDrink>(SqlDrink.GetAllDrinks, new { });
    }

    public async Task<DbDrink?> Get(int id)
    {
        return await _dataContext.FirstOrDefaultAsync<DbDrink>(SqlDrink.GetAllDrinks, new {id});
    }

    public async Task<DbDrink> Add(DbDrink model)
    {
        var id = await _dataContext.InsertAsync<int>(SqlDrink.GetAllDrinks, model);
        model.Id = id;

        return model;
    }

    public async Task<IEnumerable<DbDrink>> AddRange(IEnumerable<DbDrink> dbDrinks)
    {
        var ids = (await _dataContext.InsertManyAsync(SqlDrink.GetAllDrinks, dbDrinks)).ToList();

        var i = 0;

        foreach (var model in dbDrinks)
        {
            model.Id = ids[i];
            i++;
        }

        return dbDrinks;
    }
}