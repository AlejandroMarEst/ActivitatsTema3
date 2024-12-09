using System;
using System.Runtime.ConstrainedExecution;
namespace ActivitatsTema3
{
    public class Program
    {
        public static void Main()
        {
            Llibre Fnaf = new Llibre("Fnaf", "Scott Cawthorn");
            Biblio Librarby = new Biblio("Librarby","Meridiana");
            Console.WriteLine(Fnaf.Titol);
            Console.WriteLine(Librarby.Name);
        }
    }
}