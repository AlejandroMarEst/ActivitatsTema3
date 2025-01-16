using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatsTema3
{
    public class Ikea
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public Ikea(string name, double price, string? description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
