using Models.Application;
using Service.Preparing.Interfaces;

namespace Service.Kitchens;

public class Bar : WorkPlace
{
    public override ReadyOrderItem Modfify(ReadyOrderItem orderItem)
    {
        throw new NotImplementedException();
    }
}