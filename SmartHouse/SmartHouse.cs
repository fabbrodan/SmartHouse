using System;

namespace SmartHouseLibrary
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
