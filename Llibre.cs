using System;

namespace ActivitatsTema3
{
    public class Llibre
    {
        public string Titol { get; set; }
        public string Autor { get; set; }
        public Llibre(string name, string nameAutor)
        {
            this.Titol = name;
            this.Autor = nameAutor;
        }
    }
}
