using System;
using System.Collections.Generic;
using System.Text;
using SmartHouseLibrary.Interfaces;
using SmartHouseLibrary.Appliances;

namespace SmartHouseLibrary.Structures
{
    public class Shed
    {
        public int Height { get; }
        public int Width { get; }
        public int Depth { get; }

        public Door ShedDoor { get; }
        public Shed(int height, int width, int depth, Door door)
        {
            Height = height;
            Width = width;
            Depth = depth;
            ShedDoor = door;
        }

        public void LockDoor()
        {
            ShedDoor.LockDoor();
        }

        public void UnlockDoor(Face face)
        {
            ShedDoor.UnlockDoor(face);
        }
        
    }
}
