using Models.Application;
using Service.Performers.Interfaces;

namespace Service.Performers;

public class ConfectioneryCook : ICook
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