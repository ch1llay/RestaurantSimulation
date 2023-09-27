using Models.Application;
using Service.Preparing.Interfaces;

namespace Service.Preparing;

public class Kitchen : IKitchen<Dish, ReadyDish>
{
    public IEnumerable<ReadyDish> Prepare(IEnumerable<Dish> items)
    {
        throw new NotImplementedException();
    }

    public ReadyDish Prepare(Dish item)
    {
        throw new NotImplementedException();
    }
}