using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Repositories.Interfaces;
using Domain.Sql.Dish;
using Domain.Sql.Dish;
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

    public async Task<IEnumerable<DbDish>> Get(IEnumerable<int> ids)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDish>(SqlDish.GetDishesByIds, new {ids});
    }

    public async Task<IEnumerable<DbDish>> GetAll()
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDish>(SqlDish.GetAllDishes, new { });
    }

    public async Task<DbDish?> Get(int id)
    {
        return await _dataContext.FirstOrDefaultAsync<DbDish>(SqlDish.GetDishesByIds, new List<int> {id});
    }

    public async Task<DbDish> Add(DbDish model)
    {
        var id = await _dataContext.InsertAsync<int>(SqlDish.InsertDish, model);
        model.Id = id;

        return model;
    }

    public async Task<IEnumerable<DbDish>> AddRange(IEnumerable<DbDish> dbDishes)
    {
        var ids = (await _dataContext.InsertManyAsync(SqlDish.InsertDish, dbDishes)).ToList();

        var i = 0;

        foreach (var model in dbDishes)
        {
            model.Id = ids[i];
            i++;
        }

        return dbDishes;
    }

    public async Task<IEnumerable<DbDish>> GetByType(DishType dishType)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDish>(SqlDish.GetDishesByType, new {dishType});
    }
}