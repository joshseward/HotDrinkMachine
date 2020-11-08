using HotDrinksMachine.HotDrinks;

namespace HotDrinksMachine.Tests
{
    public abstract class HotDrinkTestBase 
    {
        protected IHotDrink _drink;

        public abstract void Create_Action_Position_Test(int position, string expectedAction);
        public abstract void Create_Action_Count_Test();
    }
}