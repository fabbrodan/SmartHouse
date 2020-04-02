using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary.Structures
{
    public class Door
    {
        public string DoorName { get; set; }
        private SmartHouse house;
        public Door(SmartHouse House, string Name)
        {
            DoorName = Name;
            house = House;
        }
        public void LockDoor()
        {
            throw new NotImplementedException();
        }

        public bool UnlockDoor(Face face)
        {
            bool unLocked = false;

            if (MatchFace(face))
            {
                unLocked = true;
            }

            return unLocked;
        }

        private bool MatchFace(Face face)
        {
            foreach (var resident in house.GetResidents())
            {
                if (resident.GetFace().CompareTo(face) == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
