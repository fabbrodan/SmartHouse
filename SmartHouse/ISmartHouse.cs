using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary
{
    public interface ISmartHouse
    {
        void LightsOn();
        void LightsOff();
        void UnlockDoor();
        void LockDoor(Face face);
    }
}
