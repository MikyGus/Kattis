using _2048.Numeric;
using System;

namespace _2048.Grid.MoveDirection
{
    public class MoveDirectionLeft : IMoveDirection
    {
        private readonly int _gridSize;

        public MoveDirectionLeft(int gridSize)
        {
            _gridSize = gridSize;
        }
        public GridPosition Vector => new GridPosition(-1, 0);

        public GridPosition StartPosition(int positionIndex)
        {
            _ = Math.DivRem(positionIndex, _gridSize, out int remainder);
            GridPosition p = new GridPosition()
            {
                X = (int)(1 + Math.Floor(positionIndex / (double)_gridSize)),
                Y = _gridSize - remainder - 1
            };
            return p;
        }
    }
}