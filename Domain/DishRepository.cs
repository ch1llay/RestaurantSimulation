using DataAccess.Interfaces;
using Domain.Interfaces;
using Models.Domain;
using Models.Enums;

namespace Domain;

public class DishRepository : IDishRepository
{
    public DishRepository(IDataContext dataContext)
    {
        throw new NotImplementedException();
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

    public Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<DbDish> models)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CookingDish> GetByType(DishType dishType)
    {
        throw new NotImplementedException();
    }
}