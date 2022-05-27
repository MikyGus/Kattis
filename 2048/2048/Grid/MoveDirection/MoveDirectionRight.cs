using _2048.Numeric;
using System;

namespace _2048.Grid.MoveDirection
{
    public class MoveDirectionRight : IMoveDirection
    {
        private readonly int _gridSize;

        public MoveDirectionRight(int gridSize)
        {
            _gridSize = gridSize;
        }
        public GridPosition Vector => new GridPosition(1, 0);

        public GridPosition StartPosition(int positionIndex)
        {
            _ = Math.DivRem(positionIndex, _gridSize, out int remainder);
            GridPosition p = new GridPosition()
            {
                X = (int)(_gridSize - Math.Floor(positionIndex / (double)_gridSize) - 2),
                Y = remainder
            };
            return p;
        }
    }
}