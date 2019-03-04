using System;
namespace InterestCalculatorDemo
{
    public class DiscoverCreditCard:ICreditCard
    {
        private long balance;

        public DiscoverCreditCard(long balance)
        {
            this.Balance = balance;
        }

        public long Balance { get => balance; set => balance = value; }

        public int GetInteresetRate()
        {
            return 1;
        }

        public long TotalInterest()
        {
            return (Balance * GetInteresetRate() / 100);
        }
    }
}
