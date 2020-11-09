using HotDrinksMachine.Types;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HotDrinksMachine.HotDrinks
{
    public class HotDrinkFactory : IHotDrinkFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public HotDrinkFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IHotDrink GetHotDrink(HotDrinksEnum hotDrink)
        {
            switch (hotDrink) 
            {
                case HotDrinksEnum.Chocolate:
                    return (IHotDrink)_serviceProvider.GetService<Chocolate>();
                case HotDrinksEnum.LemonTea:
                    return (IHotDrink)_serviceProvider.GetService<LemonTea>();
                case HotDrinksEnum.Coffee:
                default:
                    return (IHotDrink)_serviceProvider.GetService<Coffee>();
            }

        }
    }
}
