using System;
using NUnit.Framework;

using Potter;

namespace PotterTests
{
    [TestFixture]
    public class PotterTests
    {
        [Test]
        public void DoitIndiquerUnPrixPourUnLivre()
        {
            var book = new Book("MonTitre");
            var cart = new Cart();
            cart.AddBook(book);

            Assert.That(cart.GetPrice(), Is.EqualTo(8));
        }

        [Test]
        public void DoitIndiquerUnPrixPourDeuxLivresIdentiques()
        {
            var book = new Book("MonTitre");
            var cart = new Cart();
            cart.AddBook(book);
            cart.AddBook(book);

            Assert.That(cart.GetPrice(), Is.EqualTo(16));
        }

        [Test]
        public void DoitIndiquerUnPrixPourDeuxLivresDifferent()
        {
            var book = new Book("L'école des sorciers");
            var book2 = new Book("Philosophal Stone");
            var cart = new Cart();
            cart.AddBook(book);
            cart.AddBook(book2);
            Assert.That(cart.GetPrice(), Is.EqualTo(15.2m));
        }

        [Test]
        public void DoitIndiquerUnPrixPourTroisLivresDifferent()
        {
            var book = new Book("L'école des sorciers");
            var book2 = new Book("Philosophal Stone");
            var book3 = new Book("Prisonnier Azkaban");
            var cart = new Cart();
            cart.AddBook(book);
            cart.AddBook(book2);
            cart.AddBook(book3);
            Assert.That(cart.GetPrice(), Is.EqualTo(21.6m));
        }

        [Test]
        public void DoitIndiquerUnPrixPourQuatreLivresDifferent()
        {
            var book = new Book("L'école des sorciers");
            var book2 = new Book("Philosophal Stone");
            var book3 = new Book("Prisonnier Azkaban");
            var book4 = new Book("La coupe de feu");
            var cart = new Cart();
            cart.AddBook(book);
            cart.AddBook(book2);
            cart.AddBook(book3);
            cart.AddBook(book4);
            Assert.That(cart.GetPrice(), Is.EqualTo(25.6m));
        }

        [Test]
        public void DoitIndiquerUnPrixPourCinqLivresDifferent()
        {
            var book = new Book("L'école des sorciers");
            var book2 = new Book("Philosophal Stone");
            var book3 = new Book("Prisonnier Azkaban");
            var book4 = new Book("La coupe de feu");
            var book5 = new Book("L'ordre du phenix");
            var cart = new Cart();
            cart.AddBook(book);
            cart.AddBook(book2);
            cart.AddBook(book3);
            cart.AddBook(book4);
            cart.AddBook(book5);
            Assert.That(cart.GetPrice(), Is.EqualTo(30m));
        }

        [Test]
        public void DoitIndiquerUnPrixPourDeuxLivreIdentiquesEtUnDifferent()
        {
            var book = new Book("L'école des sorciers");
            var book2 = new Book("L'école des sorciers");
            var book3 = new Book("Philosophal Stone");
            var cart = new Cart();
            cart.AddBook(book);
            cart.AddBook(book2);
            cart.AddBook(book3);
            Assert.That(cart.GetPrice(), Is.EqualTo(23.2m));
        }

        [Test]
        public void DoitIndiquerUnPrixPour2X2Plus1()
        {
            var book = new Book("L'école des sorciers");
            
            var book2 = new Book("Philosophal Stone");
            var book2Bis = new Book("Philosophal Stone");

            var book3 = new Book("Prisonnier Azkaban");
            var book3Bis = new Book("Prisonnier Azkaban");
            
            
            var cart = new Cart();
            cart.AddBook(book);
            cart.AddBook(book2);
            cart.AddBook(book3);
            
            cart.AddBook(book2Bis);
            cart.AddBook(book3Bis);
            
            Assert.That(cart.GetPrice(), Is.EqualTo(36.8m));
        }

        [Test]
        public void DoitIndiquerUnPrixPour3X2Plus1()
        {
            var book = new Book("L'école des sorciers");

            var book2 = new Book("Philosophal Stone");
            var book2Bis = new Book("Philosophal Stone");
            var book2Ter = new Book("Philosophal Stone");

            var book3 = new Book("Prisonnier Azkaban");
            var book3Bis = new Book("Prisonnier Azkaban");
            var book3Ter = new Book("Prisonnier Azkaban");


            var cart = new Cart();
            cart.AddBook(book);
            cart.AddBook(book2);
            cart.AddBook(book3);
            
            cart.AddBook(book2Bis);
            cart.AddBook(book3Bis);

            cart.AddBook(book2Ter);
            cart.AddBook(book3Ter);

            Assert.That(cart.GetPrice(), Is.EqualTo(52m));
        }
    }
}
