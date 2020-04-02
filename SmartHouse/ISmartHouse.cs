using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse
{
    public interface ISmartHouse
    {
        void LightsOn();
        void LightsOff();
        void UnlockDoor(Face face);
        void LockDoor();
    }
}
