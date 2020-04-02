using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary.Interfaces
{
    public interface ISmartHouse
    {
        void LightsOn();
        void LightsOff();
        void LockDoors();
    }
}
