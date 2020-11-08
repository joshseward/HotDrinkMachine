using System.Collections.Generic;

namespace HotDrinksMachine.HotDrinks
{
    public class Chocolate : HotDrink, IHotDrink
    {
        public List<string> Create()
        {
            Actions.Add(BoilWater());
            Actions.Add("Add drinking chocolate powder to the water");
            Actions.Add(PourInCup("chocolate"));

            return Actions;
        }
    }

}
