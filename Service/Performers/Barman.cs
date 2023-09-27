using Models.Application;
using Service.Performers.Interfaces;

namespace Service.Performers;

public class Barman : IBarman
{
    public ReadyDrink Prepare(Drink sourceItem)
    {
        throw new NotImplementedException();
    }
}