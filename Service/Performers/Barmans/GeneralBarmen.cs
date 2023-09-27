using Models.Application;
using Service.Performers.Interfaces;

namespace Service.Performers.Barmans;

public class GeneralBarmen : IBarman
{
    public Drink Prepare(ReadyDrink sourceItem)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Drink> Prepare(IEnumerable<ReadyDrink> sourceItem)
    {
        throw new NotImplementedException();
    }
}