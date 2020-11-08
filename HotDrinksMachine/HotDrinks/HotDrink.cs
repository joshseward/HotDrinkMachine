using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinksMachine.HotDrinks
{
    public abstract class HotDrink
    {
        protected List<string> Actions = new List<string>();
        protected string BoilWater()
        {
            return "Boil Water";
        }

        protected string PourInCup(string drink)
        {
            return $"Pour {drink} in the cup";
        }
    }
}
