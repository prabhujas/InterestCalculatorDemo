using System;
namespace InterestCalculatorDemo
{
    public class VisaCreditCard:ICreditCard
    {
        public VisaCreditCard()
        {
        }

        public int GetInteresetRate()
        {
            return 10;
        }
    }
}
