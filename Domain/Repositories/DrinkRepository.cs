using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.Repositories.Interfaces;
using Models.Domain;

namespace Domain.Repositories;

public class DrinkRepository : IDrinkRepository
{
    private readonly IDataContext _dataContext;

    public DrinkRepository(IDataContextManager dataContextManager)
    {
        _dataContext = dataContextManager.DataContext;
    }

    Task<IEnumerable<DbDrink>> IRepository<DbDrink>.Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<DbDrink>> IDrinkRepository.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<DbDrink> IDrinkRepository.Get(int id)
    {
        throw new NotImplementedException();
    }

    Task<DbDrink> IDrinkRepository.Add(DbDrink model)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<DbEmployee>> IDrinkRepository.AddRange(IEnumerable<DbDrink> dbEmployees)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<DbDrink>> IDrinkRepository.Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<DbDrink>> IRepository<DbDrink>.GetAll()
    {
        throw new NotImplementedException();
    }

    Task<DbDrink> IRepository<DbDrink>.Get(int id)
    {
        throw new NotImplementedException();
    }

    Task<DbDrink> IRepository<DbDrink>.Add(DbDrink model)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<DbDrink>> IRepository<DbDrink>.AddRange(IEnumerable<DbDrink> dbEmployees)
    {
        throw new NotImplementedException();
    }
}