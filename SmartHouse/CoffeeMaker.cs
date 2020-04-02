using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary
{
    public class CoffeeMaker : IKitchenAppliance
    {
        public int Water { get; private set; }
        public int CoffeePowder { get; private set; }

        //You get some initial water and coffeepowder with you first CofeeMaker
        public CoffeeMaker()
        {
            Water = 100;
            CoffeePowder = 100;
        }

        private void MakeCoffee()
        {
            Water -= 10;
            CoffeePowder -= 10;

        }

        public void RefillCoffeePowder()
        {
            CoffeePowder = 100;

        }

        public void RefillWater()
        {
            Water = 100;
        }

        public void TurnOn()
        {
            MakeCoffee();
        }
    }
}
