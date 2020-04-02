using System;
using System.Collections.Generic;

namespace SmartHouseLibrary
{
    public class SmartHouse : ISmartHouse
    {

        public CoffeeMaker MoccaMaster { get; set; }

        public void TurnOnKitchenAppliance(IKitchenAppliance appliance)
        {
            appliance.TurnOn();
        }

        private List<Resident> _residents;
        public SmartHouse()
        {
            _residents = new List<Resident>();
        }

        public void AddResident(Resident resident)
        {
            _residents.Add(resident);
        }

        public void RemoveResident(Resident resident)
        {
            _residents.Remove(resident);
        }

        public List<Resident> GetResidents()
        {
            return _residents;
        }
        public void LightsOff()
        {
            throw new NotImplementedException();
        }

        public void LightsOn()
        {
            throw new NotImplementedException();
        }

        public void LockDoor()
        {
            
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
            foreach (var resident in _residents)
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
