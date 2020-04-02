using System;
using System.Collections.Generic;

namespace SmartHouse
{
    public class SmartHouse : ISmartHouse
    {
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

        public void UnlockDoor(Face face)
        {
            if (MatchFace(face))
            {
                
            }
        }

        private bool MatchFace(Face face)
        {
            foreach (var resident in _residents)
            {
                if (resident.GetFace() == face)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
