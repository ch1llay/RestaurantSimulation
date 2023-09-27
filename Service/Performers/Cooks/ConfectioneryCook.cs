using Models.Application;
using Service.Performers.Interfaces;

namespace Service.Performers;

public class ConfectioneryCook : ICook
{
    public ReadyDish Prepare(Dish sourceItem)
    {
        throw new NotImplementedException();
    }
}