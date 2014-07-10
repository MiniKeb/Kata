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
   
   
   ";

            Assert.That(render, Is.EqualTo(expected));
        }

        [Test]
        public void OnPeutAfficherUneGrilleDe5Par5AvecQueDesCellulesMortes()
        {
            var grid = new Grid(5, 5);
            var render = grid.Render();
            var expected = @"
     
     
     
     
     ";
            Assert.That(render, Is.EqualTo(expected));
        }

        [Test]
        public void OnPeutAfficherUneGrilleDe5Par5Avec1CelluleVivante()
        {
            var grid = new Grid(5, 5);
            grid.AddLiveCell(3,3);
            var render = grid.Render();
            var expected = @"
     
     
  O  
     
     ";
            Assert.That(render, Is.EqualTo(expected));
        }

        [Test]
        public void OnPeutPasserALaGenerationSuivanteAvecUneSeuleCelluleVivante()
        {
            var grid = new Grid(5, 5);
            grid.AddLiveCell(3, 3);
            grid.Next();
            var render = grid.Render();            
            var expected = @"
     
     
     
     
     ";
            Assert.That(render, Is.EqualTo(expected));
        }

        [Test]
        public void OnPeutPasserALaGenerationSuivanteAvecChaqueCelluleA2Voisines()
        {
            var grid = new Grid(5, 5);
            grid.AddLiveCell(1, 1);
            grid.AddLiveCell(1, 2);
            grid.AddLiveCell(2, 1);
            grid.Next();
            var render = grid.Render();
            var expected = @"
OO   
OO   
     
     
     ";
            Assert.That(render, Is.EqualTo(expected));
        }

        [Test]
        public void LesCellulesAvecPlusDe3VoisinsMeurent()
        {
            var grid = new Grid(5, 5);
            grid.AddLiveCell(1, 1);
            grid.AddLiveCell(1, 2);
            grid.AddLiveCell(1, 3);
            grid.AddLiveCell(2, 2);
            grid.AddLiveCell(2, 3);
            grid.Next();
            var render = grid.Render();
            var expected = @"
O O  
O O  
     
     
     ";
            Assert.That(render, Is.EqualTo(expected));
        }

        [Test]
        public void LesCellulesAvec2ou3VoisinsRestentVivantesDeManiereStandard()
        {
            var grid = new Grid(5, 5);
            grid.AddLiveCell(1, 1);
            grid.AddLiveCell(1, 2);
            grid.AddLiveCell(1, 3);
            grid.AddLiveCell(2, 2);
            grid.Next();
            var render = grid.Render();
            var expected = @"
OOO  
OOO  
     
     
     ";
            Assert.That(render, Is.EqualTo(expected));
        }

    }
}
