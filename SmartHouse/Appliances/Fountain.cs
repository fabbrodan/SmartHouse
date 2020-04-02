using System;
using System.Collections.Generic;
using System.Text;
using SmartHouseLibrary.Interfaces;

namespace SmartHouseLibrary.Appliances
{
    public class Fountain : IAppliance
    {
        public bool IsRunning { get; private set; }

        public Fountain()
        {
            IsRunning = false;
        }
        public void TurnOff()
        {
            if (IsRunning)
            {
                IsRunning = false;
            }
        }

        public void TurnOn()
        {
            if (!IsRunning)
            {
                IsRunning = true;
            }
        }
    }
}
