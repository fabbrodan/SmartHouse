using NUnit.Framework;
using SmartHouseLibrary;

namespace CoffeeMakerTests
{
    public class Tests
    {
       

        [Test]
        public void MakeCoffee_MakingCoffee_ReducesCoffeeAndWaterByTen()
        {
            var sut = new SmartHouse("Best Street 123");
            sut.MoccaMaster.TurnOn();
            Assert.AreEqual(90, sut.MoccaMaster.Water);
            Assert.AreEqual(90, sut.MoccaMaster.CoffeePowder);
        }
    }
}