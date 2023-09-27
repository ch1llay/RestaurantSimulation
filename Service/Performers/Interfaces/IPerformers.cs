namespace Service.Performers.Interfaces;

public interface IPerformers<TPreparedItem, TSourceItem>
{
    public TPreparedItem Prepare(TSourceItem sourceItem);
}