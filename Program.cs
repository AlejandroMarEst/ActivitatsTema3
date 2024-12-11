using System;
using System.Runtime.ConstrainedExecution;
namespace ActivitatsTema3
{
    public class Program
    {
        public static void Main()
        {
            const string Obj = "{0}, {1}, {2}, {3}, {4}";
            const string Filler = "Only four items";
            Flight Malasia192 = new Flight("Malasya Airlines", "Malasya", "New York", 600, 150);
            Console.WriteLine(Obj, Malasia192.Company, Malasia192.Origin, Malasia192.Destination, Malasia192.Duration, Malasia192.Passangers);
            Card As = new Card("Spades", 1, "Poker", 5);
            Console.WriteLine(Obj, As.Type, As.Value, As.Name, As.Players, Filler);
            Lamp Led = new Lamp("Blue", 500, 50, 20);
            Console.WriteLine(Obj, Led.Color, Led.Power, Led.Height, Led.Width, Filler);
        }
    }
}