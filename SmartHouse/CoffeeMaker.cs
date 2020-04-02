﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse
{
    class CoffeeMaker
    {
        public int Water { get; set; }
        public int CoffeePowder { get; set; }

        //You get som einitial water and coffeepowder with you first CofeeMaker
        public CoffeeMaker()
        {
            Water = 100;
            CoffeePowder = 100;
        }

        public void MakeCoffee()
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

    }
}
