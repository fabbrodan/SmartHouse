using System;
using System.Collections.Generic;
using SmartHouseLibrary.Interfaces;
using SmartHouseLibrary.Appliances;

namespace SmartHouseLibrary.Structures
{
    public class SmartHouse : House, ISmartHouse
    {

        public CoffeeMaker MoccaMaster { get; set; }

        public void TurnOnAppliance(IAppliance appliance)
        {
            appliance.TurnOn();
        }

        private List<Resident> _residents;
        private List<Door> _doors;
        private List<Light> _lights;
        public SmartHouse(string Address) : base(Address)
        {
            _residents = new List<Resident>();
            _doors = new List<Door>();
            _lights = new List<Light>();
        }

        public void AddDoor(Door door)
        {
            _doors.Add(door);
        }

        public List<Door> GetDoors()
        {
            return _doors;
        }

        public void AddLight(Light light)
        {
            _lights.Add(light);
        }

        public List<Light> GetLights()
        {
            return _lights;
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
            foreach (Light light in _lights)
            {
                light.TurnOff();
            }
        }

        public void LightsOn()
        {
            foreach(Light light in _lights)
            {
                light.TurnOn();
            }
        }

        public void LockDoors()
        {
            foreach(Door door in _doors)
            {
                door.LockDoor();
            }
        }
    }
}
