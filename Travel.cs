using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class Travel
    {
        public string Origin { get; set; }

        public string Destination { get; set; }
       
        public int Duration { get; set; }

        public int Passangers { get; set; }

        public Travel(string origin, string destination, int duration, int passangers)
        {
            Origin = origin;
            Destination = destination;
            Duration = duration;
            Passangers = passangers;
        }
    }
}