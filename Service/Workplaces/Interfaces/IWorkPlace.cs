
using Service.Items;

namespace Service.Workplaces.Interfaces;

public abstract class WorkPlace
{
    public abstract ReadyItem? Modify(ReadyItem orderItem);
}