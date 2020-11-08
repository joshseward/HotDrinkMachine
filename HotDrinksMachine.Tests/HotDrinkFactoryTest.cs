using HotDrinksMachine.HotDrinks;
using HotDrinksMachine.Types;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HotDrinksMachine.Tests
{
    public class HotDrinkFactoryTest
    {
        private IHotDrinkFactory _factory;
        private IServiceProvider _provider;

        [SetUp]
        public void Setup()
        {
            _provider = NSubstitute.Substitute.For<IServiceProvider>();

            _provider.GetService(Arg.Is<Type>(x => x == typeof(Chocolate))).Returns(new Chocolate());
            _provider.GetService(Arg.Is<Type>(x => x == typeof(Coffee))).Returns(new Coffee());
            _provider.GetService(Arg.Is<Type>(x => x == typeof(LemonTea))).Returns(new LemonTea());

            _factory = new HotDrinkFactory(_provider);
        }

        public class TestCase
        {
            public HotDrinksEnum HotDrink { get; set; }
            public IHotDrink ExpectedDrink { get; set; }
            public string Description { get; set; }
            public override string ToString()
            {
                return Description;
            }
        }

        protected static IEnumerable<TestCase> TestCaseData 
        {
            get
            {
                yield return new TestCase
                {
                    ExpectedDrink = new Coffee(),
                    HotDrink = HotDrinksEnum.Coffee,
                    Description = "Coffee"
                };
                yield return new TestCase
                {
                    ExpectedDrink = new Chocolate(),
                    HotDrink = HotDrinksEnum.Chocolate,
                    Description = "Chocolate"
                };
                yield return new TestCase
                {
                    ExpectedDrink = new LemonTea(),
                    HotDrink = HotDrinksEnum.LemonTea,
                    Description = "LemonTea"
                };
            }
        }


        [TestCaseSource(nameof(TestCaseData))]
        public void Get_Hot_Drink_Test(TestCase data)
        {
            var result = _factory.GetHotDrink(data.HotDrink);

            Assert.AreEqual(data.ExpectedDrink.GetType(), result.GetType());
        }
    }
}