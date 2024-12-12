using System;
using System.Runtime.ConstrainedExecution;
namespace ActivitatsTema3
{
    public class Program
    {
        public static void Main()
        {
            const string Obj = "{0}, {1}, {2}, {3}, {4}";
            Newspaper Times = new Newspaper("New York Times","New York Time","12/12/2024",2,50,"New York Times","News");
            Times.ReadCover(Times);
        }
    }
}