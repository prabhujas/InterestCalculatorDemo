using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
namespace InterestCalculatorDemo.Tests
{
    [TestFixture]
    public class PersonTest
    {
        [Test]
        public void CalculateInterestForPersonWith3Cards()
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

            Assert.AreEqual(16, person.GetTotalInterest());

        }


        [Test]
        public void CalculateInterestForPersonWith2DifferentWallets()
        {

            ICreditCard visaCard = new VisaCreditCard(100);
            ICreditCard masterCard = new MCCreditCard(100);
            ICreditCard discoverCard = new DiscoverCreditCard(100);
            ICollection<ICreditCard> cardcollection1 = new Collection<ICreditCard>();
            ICollection<ICreditCard> cardcollection2 = new Collection<ICreditCard>();

            cardcollection1.Add(visaCard);
            cardcollection1.Add(discoverCard);
            Wallet wallet1 = new Wallet(cardcollection1);

            cardcollection2.Add(masterCard);         
            Wallet wallet2 = new Wallet(cardcollection2);

            ICollection<Wallet> wallets = new Collection<Wallet>();
            wallets.Add(wallet1);
            wallets.Add(wallet2);

            Person person = new Person(wallets);

            Assert.AreEqual(16, person.GetTotalInterest());

        }


         [Test]
        public void CalculateInterestFor2DifferentsPersonWith2DifferentWallets()
        {

            ICreditCard visaCard = new VisaCreditCard(100);
            ICreditCard masterCard = new MCCreditCard(100);
            ICreditCard discoverCard = new DiscoverCreditCard(100);
            ICollection<ICreditCard> cardcollection1 = new Collection<ICreditCard>();
            ICollection<ICreditCard> cardcollection2 = new Collection<ICreditCard>();

            cardcollection1.Add(visaCard);
            cardcollection1.Add(masterCard);
            cardcollection1.Add(masterCard);
            Wallet wallet1 = new Wallet(cardcollection1);

            cardcollection2.Add(masterCard);       
            cardcollection2.Add(visaCard);  
            Wallet wallet2 = new Wallet(cardcollection2);

            ICollection<Wallet> walletCollection1 = new Collection<Wallet>();
            walletCollection1.Add(wallet1);
            Person person1 = new Person(walletCollection1);

            ICollection<Wallet> walletCollection2 = new Collection<Wallet>();
            walletCollection2.Add(wallet2);
            Person person2 = new Person(walletCollection2);

            Assert.AreEqual(20, person1.GetTotalInterest());
            Assert.AreEqual(15, person2.GetTotalInterest());

        }
    }
}
