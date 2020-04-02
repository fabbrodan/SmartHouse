using System;
using System.Collections.Generic;
using System.Text;
using SmartHouseLibrary.Interfaces;
using SmartHouseLibrary.Structures;

namespace SmartHouseLibrary.Appliances
{
    public class LawnMower : IAppliance
    {
        private Yard _yard;
        public bool IsRunning = false;
        private int _homeX;
        private int _homeY;
        private int _currentX;
        private int _currentY;
        public LawnMower(Yard yard, int StartPositionX, int StartPositionY)
        {
            _yard = yard;
            _homeX = StartPositionX;
            _homeY = StartPositionY;
        }

        public void TurnOff()
        {
            _currentX = _homeX;
            _currentY = _homeY;
            IsRunning = false;
        }

        public void TurnOn()
        {
            if (IsRunning == false)
            {
                IsRunning = true;
            }
            MowLawn(_yard);
        }

        private void MowLawn(Yard yard)
        {
            yard.GrassHeight = 5;
        }
    }
}
