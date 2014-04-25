using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class GameOfLifeTests
    {
        [Test]
        public void IlDoitExisterUneGrille()
        {
            var grid = new Grid(10, 10);

            Assert.That(grid.Width, Is.EqualTo(10));
            Assert.That(grid.Height, Is.EqualTo(10));
        }

        [Test]
        public void OnPeutAfficherUneGrilleDe3Par3AvecQueDesCellulesMortes()
        {
            var grid = new Grid(3, 3);
            var render = grid.Render();

            var expected = @"
000
000
000";

            Assert.That(render, Is.EqualTo(expected));
        }

        [Test]
        public void OnPeutAfficherUneGrilleDe5Par5AvecQueDesCellulesMortes()
        {
            var grid = new Grid(5, 5);
            var render = grid.Render();
            var expected = @"
00000
00000
00000
00000
00000";
            Assert.That(render, Is.EqualTo(expected));
        }
    }
}
