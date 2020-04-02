using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse
{
    public class Face
    {
        int Width;
        int Height;
        Colors color;
    }

    internal struct Colors
    {
        private string Color;

        public void SetColor(string color)
        {
            Color = color;
        }

        public string GetColor()
        {
            return Color;
        }
    }
}
