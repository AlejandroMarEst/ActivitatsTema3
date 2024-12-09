using System;
using System.Runtime.ConstrainedExecution;
namespace ActivitatsTema3
{
    public class Program
    {
        public static void Main()
        {
            Player Messi = new Player("Messi", 50);
            Team Barca = new Team("Barca");
            Console.WriteLine(Messi.Name);
            Console.WriteLine(Barca.TeamName);
        }
    }
}