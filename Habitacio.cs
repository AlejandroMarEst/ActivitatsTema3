using System;

namespace ActivitatsTema3
{
    public class Habitacio
    {
        public int Superficie { get; set; }
        public string Tipus{ get; set; }
        public Habitacio(int superficie, string tipus)
        {
            this.Superficie = superficie;
            this.Tipus = tipus;
        }
    }
}
