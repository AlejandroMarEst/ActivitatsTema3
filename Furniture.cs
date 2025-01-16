using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ActivitatsTema3
{
    public class Furniture
    {
        public float Weight { get; set; }
        public double Price { get; set; }
        public bool Set { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Colour { get; set; }
        public Furniture(float weight, double price, bool set, string name, string material, string colour) 
        {
            Weight = weight;
            Price = price;
            Set = set;
            Name = name;
            Material = material;
            Colour = colour;
        }
        public string GetInfo()
        {
            string Info = $"Name: {Name}, Colour: {Colour}, Material: {Material}, Price: {Price}, Weight: {Weight}, Set: {Set}";
            return Info;
        }
    }
}