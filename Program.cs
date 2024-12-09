using System;
using System.Runtime.ConstrainedExecution;
namespace ActivitatsTema3
{
    public class Program
    {
        public static void Main()
        {
            Edifici Hotel = new Edifici("Fnaf", 17);
            Habitacio Room = new Habitacio(207,"Meridiana");
            Console.WriteLine(Hotel.Nom);
            Console.WriteLine(Room.Superficie);
        }
    }
}