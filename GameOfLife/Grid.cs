namespace GameOfLife
{
    using System;
    using System.Collections.Generic;

    public class Grid
    {
        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
            LiveCells = new List<Cell>();
        }

        public int Width { get; private set; }

        public int Height { get; private set; }

        private List<Cell> LiveCells { get; set; }

        public string Render()
        {
            var gridState = string.Empty;
            for (int x = 0; x < Width; x++)
            {
                gridState += "\r\n";
                for (int y = 0; y < Height; y++)
                {
                    if (LiveCells.Contains(new Cell(x, y)))
                    {
                        gridState += "€";
                    }
                    else
                    {
                        gridState += "_";   
                    }                    
                }
            }
            return gridState;
        }

        public void AddLiveCell(int x, int y)
        {
            LiveCells.Add(new Cell(x-1, y-1));
        }

        public void Next()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var cell = new Cell(x, y);
                    int alivedNeighbours = GetAliveNeighboursCount(cell);
                    if (alivedNeighbours == 3 && !LiveCells.Contains(cell))
                    {
                        LiveCells.Add(cell);
                    }
                    else if ((alivedNeighbours == 2 || alivedNeighbours == 3) && LiveCells.Contains(cell))
                    {
                        // nothing fuck you
                    }
                    else
                    {
                        LiveCells.Remove(cell);
                    }
                }
            }
        }

        private int GetAliveNeighboursCount(Cell cell)
        {
            int count = 0;
            if(LiveCells.Contains(new Cell(cell.X-1,cell.Y)))
            {
                count++;
            }
            if (LiveCells.Contains(new Cell(cell.X + 1, cell.Y)))
            {
                count++;
            }
            if (LiveCells.Contains(new Cell(cell.X - 1, cell.Y - 1)))
            {
                count++;
            }
            if (LiveCells.Contains(new Cell(cell.X, cell.Y - 1)))
            {
                count++;
            }
            if (LiveCells.Contains(new Cell(cell.X + 1, cell.Y - 1)))
            {
                count++;
            }
            if (LiveCells.Contains(new Cell(cell.X - 1, cell.Y + 1)))
            {
                count++;
            }
            if (LiveCells.Contains(new Cell(cell.X, cell.Y + 1)))
            {
                count++;
            }
            if (LiveCells.Contains(new Cell(cell.X + 1, cell.Y + 1)))
            {
                count++;
            }

            return count;
        }
    }

    public class Cell
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        protected bool Equals(Cell other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Cell)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (this.X * 397) ^ this.Y;
            }
        }
    }
}