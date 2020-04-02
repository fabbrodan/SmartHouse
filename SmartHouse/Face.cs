using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseLibrary
{
    public class Face : IComparable
    {
        private int _width;
        private int _height;
        private Colors _eyecolor;
        private Colors _haircolor;

        public Face(int Width, int Height, Colors EyeColor, Colors HairColor)
        {
            _width = Width;
            _height = Height;
            _eyecolor = EyeColor;
            _haircolor = HairColor;
        }

        public int CompareTo(object obj)
        {
            if (obj is Face f)
            {
                if ((f.GetHeight() == this._height)
                    && (f.GetWidth() == this._width)
                    && (f.GetHairColor().GetColor() == this._haircolor.GetColor())
                    && (f.GetEyeColor().GetColor() == this._eyecolor.GetColor()))
                {
                    return 1;
                }
            }

            return -1;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }
        public Colors GetHairColor()
        {
            return _haircolor;
        }

        public Colors GetEyeColor()
        {
            return _eyecolor;
        }

    }

    public struct Colors
    {
        private string _color;

        public Colors(string Color)
        {
            _color = Color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }
    }
}
