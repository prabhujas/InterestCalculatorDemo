using System;
namespace InterestCalculatorDemo
{
    public class VisaCreditCard:ICreditCard
    {
        private long balance;

        public VisaCreditCard()
        {
        }

        public VisaCreditCard(long balance)
        {
            this.Balance = balance;
        }

        public long Balance { get => balance; set => balance = value; }

        public int GetInteresetRate()
        {
            return 10;
        }

        public long TotalInterest()
        {
            return (Balance * GetInteresetRate() / 100);
        }
    }
}
