using System;

namespace SmartHouse
{
    public class SmartHouse
    {
        public CoffeeMaker MoccaMaster { get; set; }

        public void TurnOnKitchenAppliance(IKitchenAppliance appliance)
        {
            appliance.TurnOn();
        }
    }
}
