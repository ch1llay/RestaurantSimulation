using Models.Application;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class GeneralBarmen : IBarman
{
    public ReadyDrink Prepare(Drink sourceItem)
    {
        throw new NotImplementedException();
    }
}