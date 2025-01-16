using System;
namespace ActivitatsTema3
{
    public class Program
    {
        public static void Main()
        {
            string balance;
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card.ToString());
        }
    }
}