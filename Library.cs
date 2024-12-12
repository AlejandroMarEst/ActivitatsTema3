using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatsTema3
{
    public class Library
    {
        // No es pot fer la relacio ja que es necessari una llista de llibres
        public string Name { get; set; }
        public string Ubicacio { get; set; }
        public Library(string name, string ubicacio)
        {
            Name = name;
            Ubicacio = ubicacio;
        }
    }
}
