using System;
namespace InterestCalculatorDemo
{
    public class DiscoverCreditCard:ICreditCard
    {
        public DiscoverCreditCard()
        {
        }

        public int GetInteresetRate()
        {
            return 1;
        }
    }
}
