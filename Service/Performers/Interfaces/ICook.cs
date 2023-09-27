using Models.Application;

namespace Service.Performers.Interfaces;

public interface ICook : IPerformers<ReadyDish, Dish> { }