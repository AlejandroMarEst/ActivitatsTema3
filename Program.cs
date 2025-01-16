using System;
namespace ActivitatsTema3
{
    public class Program
    {
        public static void Main()
        {
            const string Obj = "{0}, {1}, {2}, {3}, {4}, {5}";
            Furniture Table = new Furniture(80f,30.99,true,"Table schneider","Wood","Yellow");
            string info = Table.GetInfo();
            Console.WriteLine(info);
        }
    }
}