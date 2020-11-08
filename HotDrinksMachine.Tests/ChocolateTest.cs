using HotDrinksMachine.HotDrinks;
using NUnit.Framework;

namespace HotDrinksMachine.Tests
{
    public class ChocolateTest : HotDrinkTestBase
    {
        [SetUp]
        public void Setup()
        {
            _drink = new Chocolate();
        }

        [Test]
        public override void Create_Action_Count_Test()
        {
            var result = _drink.Create();

            Assert.AreEqual(3, result.Count);
        }

        [TestCase(0, "Boil Water")]
        [TestCase(1, "Add drinking chocolate powder to the water")]
        [TestCase(2, "Pour chocolate in the cup")]
        public override void Create_Action_Position_Test(int position, string expectedAction)
        {
            var result = _drink.Create();

            Assert.AreEqual(expectedAction, result[position]);
        }
    }
}