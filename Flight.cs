using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class Flight
    {
        public string Company { get; set; }
        
        public int Time { get; set; }

        public int Passangers { get; set; }

        public Flight(string company, int time, int passangers)
        {
            this.Company = company;
            this.Time = time;
            this.Passangers = passangers;
        }
    }
}