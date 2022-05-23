using System;
using System.Drawing;

namespace _2048.Grid.MoveDirection
{
    public class MoveDirectionDown : IMoveDirection
    {
        private readonly int _gridSize;

        public MoveDirectionDown(int gridSize)
        {
            _gridSize = gridSize;
        }
        public Point Vector => new Point(0,1);

        public Point StartPosition(int positionIndex)
        {
            Point p = new Point();
            _ = Math.DivRem(positionIndex, _gridSize, out int remainder);
            p.X = _gridSize - remainder - 1;
            p.Y = (int)(_gridSize - Math.Floor(positionIndex / (double)_gridSize) - 2);
            return p;
        }
    }
}