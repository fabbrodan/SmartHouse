using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary
{
    public class Resident
    {
        private string _name;
        private Face _face;

        public Resident(string name)
        {
            _name = name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetFace(Face face)
        {
            _face = face;
        }

        public Face GetFace()
        {
            return _face;
        }
    }
}
