using System;
using System.Collections.Generic;

namespace InterestCalculatorDemo
{
    public class Wallet
    {
        public ICollection<ICreditCard> creditCards;

        public Wallet(ICollection<ICreditCard> creditCards)
        {
            this.creditCards = creditCards;
        }

        public long TotalInterest(){
            long totalInterest = 0;
            foreach(ICreditCard creditCard in creditCards){
                totalInterest += creditCard.TotalInterest();
            }
            return totalInterest;
        }
    }
}
