using System;

namespace ActivitatsTema3
{
    public class Lamp : Furniture
    {
        public int Power { get; set; }

        public Lamp(string color, int power, int height, int width) : base (color, height, width)
        {
            Power = power;
        }
    }
}