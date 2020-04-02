using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary
{
    public class House : SmartHouse
    {
        private string _address;
        private List<Room> _roomList;

        public House(string Address)
        {
            _address = Address;
        }

        public void AddRoom(Room room)
        {
            _roomList.Add(room);
        }
    }
}
