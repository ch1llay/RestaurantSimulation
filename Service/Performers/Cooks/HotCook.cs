using Models.Application;
using Service.Performers.Interfaces;

namespace Service.Performers;

public class HotCook : ICook
{
    public ReadyDish Prepare(Dish sourceItem)
    {
        throw new NotImplementedException();
    }
}