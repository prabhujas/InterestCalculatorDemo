using System;
namespace InterestCalculatorDemo
{
    public class MCCreditCard:ICreditCard
    {
        private long balance;

        public MCCreditCard(long balance)
        {
            this.Balance = balance;
        }

        public long Balance { get => balance; set => balance = value; }

        public int GetInteresetRate()
        {
            return 5;
        }

        public long TotalInterest()
        {
            return (Balance * GetInteresetRate() / 100);
        }
    }
}
