using Models.Application;
using Service.Preparing.Interfaces;

namespace Service.Preparing;

public class Kitchen : WorkPlace
{
    public override ReadyOrderItem Modfify(ReadyOrderItem orderItem)
    {
        throw new NotImplementedException();
    }
}