using Service.Performers.Interfaces;
using Service.Preparing.Interfaces;

namespace Service.Factories;

public class BarFactory : PerformerContextFactory
{
    public override Performer GetPerformer()
    {
        throw new NotImplementedException();
    }

    public override WorkPlace GetWorkPlace()
    {
        throw new NotImplementedException();
    }
}