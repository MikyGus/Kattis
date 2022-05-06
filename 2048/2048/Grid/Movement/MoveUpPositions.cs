using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2048.Grid.Movement
{
    internal class MoveUpPositions : IEnumerator<Point>
    {
        private readonly int _gridSize;
        Point _currentPosition;

        public MoveUpPositions(int gridSize)
        {
            _gridSize = gridSize;
            _currentPosition = new Point(_gridSize,0);
        }

        public Point Current => _currentPosition;

        object IEnumerator.Current => _currentPosition;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            _currentPosition.X++;
            if (HaveExcededGridSize(_currentPosition.X))
            {
                _currentPosition.Y++;
                _currentPosition.X = 0;
            }
            if (HaveExcededGridSize(_currentPosition.Y))
            {
                return false;
            }
            return true;
        }

        public void Reset() => _currentPosition = new Point(_gridSize, 0);

        private bool HaveExcededGridSize(int position) => position >= _gridSize;
    }
}
