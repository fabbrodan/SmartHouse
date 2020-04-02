using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary.Structures
{
    public class Room
    {
        private int _width;
        private int _depth;
        private RoomType _roomType;

        public Room(int Width, int Depth, RoomType type)
        {
            _width = Width;
            _depth = Depth;
            _roomType = type;
        }

        public double GetRoomSize()
        {
            return _width * _depth;
        }

        public RoomType GetRoomType()
        {
            return _roomType;
        }
    }

    public enum RoomType
    {
        BATHROOM,
        BEDROOM,
        LIVINGROOM
    }
}
