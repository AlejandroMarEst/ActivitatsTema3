using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class Lamp
    {
        public string Color { get; set; }

        public int Power { get; set; }

        public Lamp(string color, int power)
        {
            this.Color = color;
            this.Power = power;
        }
    }
}