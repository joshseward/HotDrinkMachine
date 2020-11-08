using HotDrinksMachine.HotDrinks;
using NUnit.Framework;

namespace HotDrinksMachine.Tests
{
    public class CoffeTest : HotDrinkTestBase
    {
        [SetUp]
        public void Setup()
        {
            _drink = new Coffee();
        }

        [Test]
        public override void Create_Action_Count_Test()
        {
            var result = _drink.Create();

            Assert.AreEqual(4, result.Count);
        }

        [TestCase(0, "Boil Water")]
        [TestCase(1, "Brew the coffee grounds")]
        [TestCase(2, "Pour coffee in the cup")]
        [TestCase(3, "Add sugar and milk")]
        public override void Create_Action_Position_Test(int position, string expectedAction)
        {
            var result = _drink.Create();

            Assert.AreEqual(expectedAction, result[position]);
        }
    }
}