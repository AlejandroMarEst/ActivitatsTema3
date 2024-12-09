using System;

namespace ActivitatsTema3
{
    public class Biblio
    {
        public string Name { get; set; }
        public string Ubicacio { get; set; }
        public Biblio(string name, string ubicacio)
        {
            this.Name = name;
            this.Ubicacio = ubicacio;
        }
    }
}
