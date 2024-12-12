using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatsTema3
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Passangers { get; set; }
        public Vehicle(string name, string type, string color, int passangers){
            Name = name;
            Type = type;
            Color = color;
            Passangers = passangers;
        }
    }
}
