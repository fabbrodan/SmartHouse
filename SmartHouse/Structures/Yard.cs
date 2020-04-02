using System;
using System.Collections.Generic;
using System.Text;
using SmartHouseLibrary.Interfaces;
using SmartHouseLibrary.Appliances;

namespace SmartHouseLibrary.Structures
{
    public class Yard : ISmartHouse
    {
        private int _width;
        private int _depth;
        public int GrassHeight { get; set; }
        public IAppliance LawnMower { get; private set; }

        private List<Light> YardLights;
        public Shed YardShed;

        public Yard(int Width, int Depth)
        {
            _width = Width;
            _depth = Depth;
            YardLights = new List<Light>();
        }

        public double GetYardSize()
        {
            return _width * _depth;
        }

        public void MowLawn()
        {
            LawnMower mower = new LawnMower(this, 10, 10);
            mower.TurnOn();
        }

        public void AddLight(Light light)
        {
            YardLights.Add(light);
        }

        public List<Light> GetLights()
        {
            return YardLights;
        }

        public void LightsOn()
        {
           foreach (Light light in YardLights)
            {
                light.TurnOn();
            }
        }

        public void LightsOff()
        {
            foreach (Light light in YardLights)
            {
                light.TurnOff();
            }
        }

        public void LockDoors()
        {
            YardShed.LockDoor();
        }
    }
}
