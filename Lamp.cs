using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class Lamp : Furniture
    {
        public int Power { get; set; }

        public Lamp(string color, int power, int height, int width) : base(color, height, width)
        {
            Color = color;
            Power = power;
            Height = height;
            Width = width;
        }
    }
}