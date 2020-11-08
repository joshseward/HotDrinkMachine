using HotDrinksMachine.Types;

namespace HotDrinksMachine.HotDrinks
{
    public interface IHotDrinkFactory
    {
        IHotDrink GetHotDrink(HotDrinksEnum hotDrink);
    }
}
