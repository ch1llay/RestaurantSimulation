using Service.Factories;
using Service.Items;
using Service.Performers.Interfaces;
using Service.Workplaces.Interfaces;

namespace Service;

public class PerformerContext
{
    public PerformerContext(PerformerContextFactory factory)
    {
        _performer = factory.GetPerformer();
        _workPlace = factory.GetWorkPlace();
    }

    private Performer _performer { get; }
    private WorkPlace _workPlace { get; }

    public ReadyItem Prepare(MenuItem? item)
    {
        var readyItem = _performer.Prepare(item);
        _workPlace.Modify(readyItem);

        return readyItem;
    }
}