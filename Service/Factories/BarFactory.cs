using Service.Performers.Barmans;
using Service.Performers.Interfaces;
using Service.Workplaces;
using Service.Workplaces.Interfaces;

namespace Service.Factories;

public class BarFactory : PerformerContextFactory
{
    public override Performer GetPerformer()
    {
        return new BarmanMaster();
    }

    public override WorkPlace GetWorkPlace()
    {
        return new Bar();
    }
}