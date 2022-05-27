using _2048.Grid.MoveDirection;
using _2048.Numeric;
using System.Collections;
using System.Collections.Generic;

namespace _2048.Grid.Movement
{
    public class GridStartPosition : IEnumerable<GridPosition>
    {
        private readonly IMoveDirection _moveGridDirection;
        private readonly int _gridSize;

        public GridStartPosition(IMoveDirection moveGridDirection, int gridSize)
        {
            _moveGridDirection = moveGridDirection;
            _gridSize = gridSize;
        }

        public IEnumerator<GridPosition> GetEnumerator()
        {
            return new GridStartPositionsEnumerator(_moveGridDirection, _gridSize);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new GridStartPositionsEnumerator(_moveGridDirection, _gridSize);
        }

    }
}
