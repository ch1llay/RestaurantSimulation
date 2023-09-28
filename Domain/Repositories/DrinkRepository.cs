using DataAccess.DI.Interfaces;
using DataAccess.Interfaces;
using Domain.Repositories.Interfaces;

namespace Domain.Repositories;

public class DrinkRepository : IDrinkRepository
{
    public DrinkRepository(IDataContextManager dapperContext)
    {
        throw new NotImplementedException();
    }
}