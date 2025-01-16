using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ActivitatsTema3
{
    public class Furniture : Ikea
    {
        public float? Weight { get; set; }
        public bool? Set { get; set; }
        public string? Material { get; set; }
        public string Colour { get; set; }
        public Furniture(float? weight, double price, bool? set, string name, string material, string colour, string? description) : base(name, price, description)
        {
            Weight = weight;
            Price = price;
            Set = set;
            Name = name;
            Material = material;
            Colour = colour;
            Description = description;
        }
        public Furniture(double price, string name, string colour) : this(null, price, null, name, null, colour, null) { }
        public Furniture() : this(null, 20.00, null, "Shnicer Table", null, "Red", null) { }
        public string GetInfo()
        {
            string Info = $"Name: {Name}, Colour: {Colour}, Material: {Material}, Price: {Price}, Weight: {Weight}, Set: {Set}";
            return Info;
        }
    }
}