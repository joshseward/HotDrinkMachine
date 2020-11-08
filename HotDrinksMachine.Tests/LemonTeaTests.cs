using HotDrinksMachine.HotDrinks;
using NUnit.Framework;

namespace HotDrinksMachine.Tests
{
    [TestFixture]
    public class LemonTeaTest: HotDrinkTestBase
    {
        [SetUp]
        public void Setup()
        {
            _drink = new LemonTea();
        }

        [Test]
        public override void Create_Action_Count_Test()
        {
            var result = _drink.Create();

            Assert.AreEqual(4, result.Count);
        }

        [TestCase(0, "Boil Water")]
        [TestCase(1, "Steep the water in the tea")]
        [TestCase(2, "Pour tea in the cup")]
        [TestCase(3, "Add Lemon")]
        public override void Create_Action_Position_Test(int position, string expectedAction)
        {
            var result = _drink.Create();

            Assert.AreEqual(expectedAction, result[position]);
        }
    }
}