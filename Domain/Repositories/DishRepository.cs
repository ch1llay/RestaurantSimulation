using Common.Enums;
using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Domain.Models;
using Domain.Repositories.Interfaces;
using Domain.Sql.Dish;

namespace Domain.Repositories;

public class DishRepository : IDishRepository
{
    private readonly IDataContext _dataContext;

    public DishRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    public async Task<IEnumerable<DbDish>> GetAll()
    {
       return await _dataContext.EnumerableOrEmptyAsync<DbDish>(Dish.GetAllDishes, new { });
    }

    public async Task<DbDish> Add(DbDish model)
    {
        return await _dataContext.InsertAsync<DbDish>(Dish.InsertDish, model);
    }

    public async Task<IEnumerable<DbDish>> GetByType(DishType type)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDish>(Dish.GetDishesByType, new {dishType=type });
    }

    public async Task<IEnumerable<DbDish>> GetByIds(IEnumerable<int> ids)
    {
        return await _dataContext.EnumerableOrEmptyAsync<DbDish>(Dish.GetDishByIds, new {ids=ids });

    }

    public async Task<DbDish> GetById(int id)
    {
        return await _dataContext.FirstOrDefaultAsync<DbDish>(Dish.GetDishByIds, new {ids=new List<int>{id}});
    }
}