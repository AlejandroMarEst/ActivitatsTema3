using System;
using System.Runtime.ConstrainedExecution;
namespace ActivitatsTema3
{
    public class Program
    {
        public static void Main()
        {
            Bike bike1 = new Bike(80,"Torrente","Red",8);
            Console.WriteLine("{0}, {1}, {2}, {3}", bike1.Speed,bike1.Gears,bike1.Color,bike1.Brand);
        }
    }
}