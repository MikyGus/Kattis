using System;
using System.Drawing;

namespace _2048.Grid.MoveDirection
{
    public class MoveDirectionRight : IMoveDirection
    {
        private readonly int _gridSize;

        public MoveDirectionRight(int gridSize)
        {
            _gridSize = gridSize;
        }
        public Point Vector => new Point(1,0);

        public Point StartPosition(int positionIndex)
        {
            Point p = new Point();
            _ = Math.DivRem(positionIndex, _gridSize, out int remainder);
            p.X = (int)(_gridSize - Math.Floor(positionIndex / (double)_gridSize) - 2);
            p.Y = remainder;
            return p;
        }
    }
}