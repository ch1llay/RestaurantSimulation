using Service.DI.Interfaces;
using Service.Factories;
using Service.Items;
using Service.Performers.Interfaces;
using Service.Workplaces.Interfaces;

namespace Service;

public class PerformerContext
{
    public PerformerContext(PerformerContextFactory factory, IServiceManager serviceManager)
    {
        _performer = factory.GetPerformer();
        _workPlace = factory.GetWorkPlace(serviceManager);
        _workPlace.Wait();
    }

    private Performer _performer { get; }
    private Task<WorkPlace> _workPlace { get; }

    public ReadyItem Prepare(MenuItem? item)
    {
        var readyItem = _performer.Prepare(item);
        _workPlace.Result.Modify(readyItem);

        return readyItem;
    }
}