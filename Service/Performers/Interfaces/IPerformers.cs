namespace Service.Performers.Interfaces;

public interface IPerformers<TIn, TOut>
{
    public TOut Prepare(TIn sourceItem);
    public IEnumerable<TOut> Prepare(IEnumerable<TIn> sourceItem);
}