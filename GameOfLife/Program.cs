using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(10, 10);
            
            Console.Write(grid.Render());
            Console.ReadKey();
        }
    }
}
