using System;
using System.Collections.Generic;

namespace InterestCalculatorDemo
{
    public class Person
    {
        ICollection<Wallet> wallets;

        public Person()
        {
        }

        public Person(ICollection<Wallet> wallets)
        {
            this.Wallets = wallets;
        }

        public ICollection<Wallet> Wallets { get => wallets; set => wallets = value; }

        public long GetTotalInterest()
        {
            long totalInterest = 0;
            foreach (Wallet wallet in Wallets)
            {
                totalInterest += wallet.TotalInterest();
            }
            return totalInterest;
        }

    }
}
