using System;
using System.Collections.Generic;
using System.Text;
using SmartHouseLibrary.Interfaces;

namespace SmartHouseLibrary.Appliances
{
    public class CoffeeMaker : IAppliance
    {
        public int Water { get; private set; }
        public int CoffeePowder { get; private set; }
        public bool IsRunning { get; private set; }

        //You get some initial water and coffeepowder with you first CofeeMaker
        public CoffeeMaker()
        {
            Water = 100;
            CoffeePowder = 100;
            IsRunning = false;
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
            if (!IsRunning)
            {
                IsRunning = true;
            }
            MakeCoffee();
        }

        public void TurnOff()
        {
            if (IsRunning)
            {
                IsRunning = false;
            }
        }
    }
}
