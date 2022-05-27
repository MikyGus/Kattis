using _2048.Grid.MoveDirection;
using _2048.Numeric;
using System.Collections;
using System.Collections.Generic;

namespace _2048.Grid.Movement
{
    internal class GridStartPositionsEnumerator : IEnumerator<GridPosition>
    {
        private readonly IMoveDirection _moveGridDirection;
        private readonly int _gridSize;
        private int _index = -1;

        public GridStartPositionsEnumerator(IMoveDirection moveGridDirection, int gridSize)
        {
            _moveGridDirection = moveGridDirection;
            _gridSize = gridSize;
        }

        public GridPosition Current => CurrentPoint();

        object IEnumerator.Current => CurrentPoint();

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            _index++;
            return IsInsideGrid(_index);
        }

        public void Reset()
        {
            _index = -1;
        }

        private GridPosition CurrentPoint()
        {
            return _moveGridDirection.StartPosition(_index);
        }

        private bool IsInsideGrid(int index)
        {
            int maxIndex = ((_gridSize - 1) * _gridSize) - 1;
            return index <= maxIndex;
        }
    }
}
