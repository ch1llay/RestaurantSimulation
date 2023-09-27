namespace Service.Preparing.Interfaces;

public interface IKitchen<TIn, TOut>
{
    IEnumerable<TOut> Prepare(IEnumerable<TIn> items);
    TOut Prepare(TIn item);
}