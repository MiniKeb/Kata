using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(50, 50);

            grid.AddLiveCell(5, 1);
            grid.AddLiveCell(6, 1);
            grid.AddLiveCell(5, 2);
            grid.AddLiveCell(6, 2);

            grid.AddLiveCell(5, 11);
            grid.AddLiveCell(6, 11);
            grid.AddLiveCell(7, 11);
            grid.AddLiveCell(4, 12);
            grid.AddLiveCell(8, 12);
            grid.AddLiveCell(3, 13);
            grid.AddLiveCell(9, 13);
            grid.AddLiveCell(3, 14);
            grid.AddLiveCell(9, 14);

            grid.AddLiveCell(6, 15);
            grid.AddLiveCell(4, 16);
            grid.AddLiveCell(8, 16);
            grid.AddLiveCell(5, 17);
            grid.AddLiveCell(6, 17);
            grid.AddLiveCell(7, 17);
            grid.AddLiveCell(6, 18);
            
            grid.AddLiveCell(3, 21);
            grid.AddLiveCell(4, 21);
            grid.AddLiveCell(5, 21);
            grid.AddLiveCell(3, 22);
            grid.AddLiveCell(4, 22);
            grid.AddLiveCell(5, 22);
            grid.AddLiveCell(2, 23);
            grid.AddLiveCell(6, 23);
            grid.AddLiveCell(1, 25);
            grid.AddLiveCell(2, 25);
            grid.AddLiveCell(6, 25);
            grid.AddLiveCell(7, 25);
            
            grid.AddLiveCell(3, 35);
            grid.AddLiveCell(4, 35);
            grid.AddLiveCell(3, 36);
            grid.AddLiveCell(4, 36);


            var i = 0;
            Console.WriteLine("Génération {0}", i);
            Console.WriteLine(grid.Render());

            Console.ReadLine();
            
            while (grid.Next())
            {
                Thread.Sleep(10);
                Console.Clear();
                Console.WriteLine("Génération {0}", ++i);
                Console.WriteLine(grid.Render());
            }
            
            Console.ReadKey();
        }
    }
}
