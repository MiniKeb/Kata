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
    }
}
