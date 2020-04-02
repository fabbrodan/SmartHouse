using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse
{
    public class Room
    {
        private int _width;
        private int _depth;

        public Room(int Width, int Depth)
        {
            _width = Width;
            _depth = Depth;
        }

        public double GetRoomSize()
        {
            return _width * _depth;
        }
    }
}
