using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatsTema3
{
    public class PaymentCard
    {
        public double Balance{get; set;}
        public PaymentCard(double balance)
        {
            Balance = balance;
        }
        public override string ToString() => $"The card has a balance of {Balance} euros";
    }
}
