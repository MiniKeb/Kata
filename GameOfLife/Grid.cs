namespace GameOfLife
{
    using System;

    public class Grid
    {
        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public string Render()
        {
            var gridState = string.Empty;
            for(int x = 0; x < Width; x++)
            {
                gridState += "\r\n";
                for(int y = 0; y < Height; y++)
                {
                    gridState += "0";
                }
            }
            return gridState;
        }
    }
}