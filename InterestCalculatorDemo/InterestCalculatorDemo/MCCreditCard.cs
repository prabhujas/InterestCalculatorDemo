using System;
namespace InterestCalculatorDemo
{
    public class MCCreditCard:ICreditCard
    {
        public MCCreditCard()
        {
        }

        public int GetInteresetRate()
        {
            return 5;
        }
    }
}
