using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsTema3
{
    public class Furniture
    {
        public string Color { get; set; }
        
        public int Height { get; set; }

        public int Width { get; set; } 

        public Furniture(string color, int height, int width)
        {
            Color = color;
            Height = height; 
            Width = width;
        }
    }
}