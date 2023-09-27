using Models.Application;
using Service.Preparing.Interfaces;

namespace Service.Preparing;

public class Bar : IKitchen<Drink, ReadyDrink>
{
    
    public IEnumerable<ReadyDrink> Prepare(IEnumerable<Drink> items)
    {
        throw new NotImplementedException();
    }

    public ReadyDrink Prepare(Drink item)
    {
        throw new NotImplementedException();
    }
}