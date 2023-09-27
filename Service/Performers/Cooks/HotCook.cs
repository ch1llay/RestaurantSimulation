using Models.Application;
using Service.Performers.Interfaces;

namespace Service.Performers;

public class HotCook : ICook
{
    public Dish Prepare(ReadyDish sourceItem)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Dish> Prepare(IEnumerable<ReadyDish> sourceItem)
    {
        throw new NotImplementedException();
    }
}