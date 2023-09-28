using Models.Application;
using Service.Factories;
using Service.Performers.Interfaces;
using Service.Preparing.Interfaces;

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

    public ReadyOrderItem Prepare(OrderItem? item)
    {
        var readyItem = _performer.Prepare(item);
        _workPlace.Modfify(readyItem);

        return readyItem;
    }

}