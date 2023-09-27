using DataAccess.Interfaces;
using Domain.Interfaces;

namespace Domain;

public class DrinkRepository : IDrinkRepository
{
    public DrinkRepository(IDataContext dapperContext)
    {
        throw new NotImplementedException();
    }
}