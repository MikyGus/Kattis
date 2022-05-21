using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2048.Grid.Movement
{
    public class GridStartPosition : IEnumerable<Point>
    {
        private readonly int _moveGridDirection;
        private readonly int _gridSize;

        public GridStartPosition(int moveGridDirection, int gridSize)
        {
            _moveGridDirection = moveGridDirection;
            _gridSize = gridSize;
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return new GridStartPositionsEnumerator(_moveGridDirection,_gridSize);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new GridStartPositionsEnumerator(_moveGridDirection, _gridSize);
        }

    }
}
