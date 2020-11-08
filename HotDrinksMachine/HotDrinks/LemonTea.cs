using System.Collections.Generic;

namespace HotDrinksMachine.HotDrinks
{
    public class LemonTea : HotDrink, IHotDrink
    {
        public List<string> Create()
        {
            Actions.Add(BoilWater());
            Actions.Add("Steep the water in the tea");
            Actions.Add(PourInCup("tea"));
            Actions.Add("Add Lemon");

            return Actions;
        }
    }

}
