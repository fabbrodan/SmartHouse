using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary.Structures
{
    public class House
    {
        private string _address;
        private List<Room> _roomList;
        private Yard _yard;

        public House(string Address)
        {
            _address = Address;
            _roomList = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            _roomList.Add(room);
        }

        public void AddYard(Yard yard)
        {
            _yard = yard;
        }

        public Yard GetYard()
        {
            return _yard;
        }
    }
}
