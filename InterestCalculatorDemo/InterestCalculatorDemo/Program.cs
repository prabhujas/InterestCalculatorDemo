using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InterestCalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
       
          

            ICreditCard creditCard1 = new VisaCreditCard(100);
            ICreditCard creditCard2 = new MCCreditCard(100);
            ICreditCard creditCard3 = new DiscoverCreditCard(100);
            ICollection<ICreditCard> cards = new Collection<ICreditCard>();
            cards.Add(creditCard1);
            cards.Add(creditCard2);
            cards.Add(creditCard3);

            Wallet wallet1 = new Wallet(cards);
            ICollection<Wallet> wallets = new Collection<Wallet>();
            wallets.Add(wallet1);

            Person person = new Person(wallets);

            Console.WriteLine("Hello Person1's Interest is " + person.GetTotalInterest());



        }
    }
}
