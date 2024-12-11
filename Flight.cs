using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class Flight : Travel
    {
        public string Company { get; set; }

        public Flight(string company, string origin, string destination, int duration, int passangers) : base(origin, destination, duration, passangers)
        {
            Company = company;
        }
    }
}
