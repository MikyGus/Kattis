using _2048.Numeric;
using System;

namespace _2048.Grid.MoveDirection
{
    public class MoveDirectionDown : IMoveDirection
    {
        private readonly int _gridSize;

        public MoveDirectionDown(int gridSize)
        {
            _gridSize = gridSize;
        }
        public GridPosition Vector => new GridPosition(0, 1);

        public GridPosition StartPosition(int positionIndex)
        {
            _ = Math.DivRem(positionIndex, _gridSize, out int remainder);
            GridPosition p = new GridPosition
            {
                X = _gridSize - remainder - 1,
                Y = (int)(_gridSize - Math.Floor(positionIndex / (double)_gridSize) - 2)
            };
            return p;
        }
    }
}