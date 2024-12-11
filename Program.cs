using System;
using System.Runtime.ConstrainedExecution;
namespace ActivitatsTema3
{
    public class Program
    {
        public static void Main()
        {
            Cat michi = new Cat("Ashley", 18, "Calico", "Spagetti");
            Console.WriteLine("{0}, {1}, {2}, {3}", michi.Name, michi.Age, michi.Breed, michi.FavFood);
            michi.Eat();
        }
    }
}