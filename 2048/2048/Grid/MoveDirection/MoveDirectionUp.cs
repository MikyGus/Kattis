using _2048.Numeric;
using System;

namespace _2048.Grid.MoveDirection
{
    public class MoveDirectionUp : IMoveDirection
    {
        private readonly int _gridSize;

        public MoveDirectionUp(int gridSize)
        {
            _gridSize = gridSize;
        }
        public GridPosition Vector => new GridPosition(0, -1);

        public GridPosition StartPosition(int positionIndex)
        {
            GridPosition p = new GridPosition();
            _ = Math.DivRem(positionIndex, _gridSize, out int remainder);
            p.X = remainder;
            p.Y = (int)(1 + Math.Floor(positionIndex / (double)_gridSize));
            return p;
        }
    }
}