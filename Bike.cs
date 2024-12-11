using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace ActivitatsTema3
{
    public class Bike
    {
        public int Speed { set; get; }
        public string Brand { set; get; }
        public string Color { set; get; }
        public int Gears { set; get; }
        public Bike(int speed, string brand, string color, int gears)
        {
            this.Speed = speed;
            this.Brand = brand;
            this.Color = color;
            this.Gears = gears;
        }
    }
}
