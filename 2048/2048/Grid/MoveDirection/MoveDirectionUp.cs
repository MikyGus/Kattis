using System;
using System.Drawing;

namespace _2048.Grid.MoveDirection
{
    public class MoveDirectionUp : IMoveDirection
    {
        private readonly int _gridSize;

        public MoveDirectionUp(int gridSize)
        {
            _gridSize = gridSize;
        }
        public Point Vector => new Point(0,-1);

        public Point StartPosition(int positionIndex)
        {
            Point p = new Point();
            _ = Math.DivRem(positionIndex, _gridSize, out int remainder);
            p.X = remainder;
            p.Y = (int)(1 + Math.Floor(positionIndex / (double)_gridSize));
            return p;
        }
    }
}