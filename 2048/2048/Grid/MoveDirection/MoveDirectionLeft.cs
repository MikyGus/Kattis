using System;
using System.Drawing;

namespace _2048.Grid.MoveDirection
{
    public class MoveDirectionLeft : IMoveDirection
    {
        private readonly int _gridSize;

        public MoveDirectionLeft(int gridSize)
        {
            _gridSize = gridSize;
        }
        public Point Vector => new Point(-1,0);

        public Point StartPosition(int positionIndex)
        {
            Point p = new Point();
            _ = Math.DivRem(positionIndex, _gridSize, out int remainder);
            p.X = (int)(1 + Math.Floor(positionIndex / (double)_gridSize));
            p.Y = _gridSize - remainder - 1;
            return p;
        }
    }
}