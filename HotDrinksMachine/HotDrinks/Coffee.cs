using System.Collections.Generic;

namespace HotDrinksMachine.HotDrinks
{
    public class Coffee : HotDrink, IHotDrink
    {
        public List<string> Create()
        {
            Actions.Add(BoilWater());
            Actions.Add("Brew the coffee grounds");
            Actions.Add(PourInCup("coffee"));
            Actions.Add("Add sugar and milk");

            return Actions;
        }
    }
}
