using Models.Application.ReadyItems;

namespace Service.Workplaces.Interfaces;

public abstract class WorkPlace
{
    public abstract ReadyOrderItem? Modify(ReadyOrderItem orderItem);
}