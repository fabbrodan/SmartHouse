using System;
using System.Collections.Generic;
using System.Text;
using SmartHouseLibrary.Interfaces;

namespace SmartHouseLibrary.Appliances
{
    public class Light : IAppliance
    {
        public bool IsOn { get; private set; }

        public Light()
        {
            IsOn = false;
        }
        public void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
            }
        }

        public void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
            }
        }
    }
}
