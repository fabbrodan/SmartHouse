using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse
{
    public interface ISmartHouse
    {
        void LightsOn();
        void LightsOff();
        void UnlockDoor();
        void LockDoor(Face face);
    }
}
