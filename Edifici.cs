using System;

namespace ActivitatsTema3
{
    public class Edifici
    {
        public string Nom { get; set; }
        public int NumApt { get; set; }
        public Edifici(string name, int num)
        {
            this.Nom = name;
            this.NumApt = num;
        }
    }
}
