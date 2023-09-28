using Models.Application;
using Models.Application.Items;
using Models.Application.ReadyItems;
using Service.Factories;
using Service.Performers.Interfaces;
using Service.Workplaces.Interfaces;

namespace Service;

public class PerformerContext
{
    private Performer _performer { get; }
    private WorkPlace _workPlace { get; set; }

    public PerformerContext(PerformerContextFactory factory)
    {
        _performer = factory.GetPerformer();
        _workPlace = factory.GetWorkPlace();
    }

    public ReadyOrderItem Prepare(MenuItem? item)
    {
        var readyItem = _performer.Prepare(item);
        _workPlace.Modify(readyItem);

        return readyItem;
    }

}