using Models.Application;

namespace Service.Preparing.Interfaces;

public abstract class WorkPlace
{
    public abstract ReadyOrderItem Modfify(ReadyOrderItem orderItem);
}