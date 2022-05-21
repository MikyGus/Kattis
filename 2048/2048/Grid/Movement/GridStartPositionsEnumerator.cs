using _2048.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2048.Grid.Movement
{
    internal class GridStartPositionsEnumerator : IEnumerator<Point>
    {
        private readonly int _moveGridDirection;
        private readonly int _gridSize;
        private int _index = -1;

        public GridStartPositionsEnumerator(int moveGridDirection, int gridSize)
        {
            _moveGridDirection = moveGridDirection;
            _gridSize = gridSize;
        }

        public Point Current => CurrentPoint();

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

        private Point CurrentPoint()
        {
            Point p = new Point();
            _ = Math.DivRem(_index, _gridSize, out int remainder);
            switch (_moveGridDirection)
            {
                case 0: //Left
                    p.X = (int)(1 + Math.Floor(_index / (double)_gridSize));
                    p.Y = _gridSize - remainder - 1;
                    break;
                case 1: //Up
                    p.X = remainder;
                    p.Y = (int)(1 + Math.Floor(_index / (double)_gridSize));
                    break;
                case 2: //Right
                    p.X = (int)(_gridSize - Math.Floor(_index / (double)_gridSize) -2);
                    p.Y = remainder;
                    break;
                case 3: // Down
                    p.X = _gridSize - remainder - 1;
                    p.Y = (int)(_gridSize - Math.Floor(_index / (double)_gridSize) - 2);
                    break;
                default:
                    throw new InvalidMoveDirection(_moveGridDirection);
            }
            return p;
        }

        private bool IsInsideGrid(int index)
        {
            int maxIndex = ((_gridSize - 1) * _gridSize) - 1;
            return index <= maxIndex;
        }
    }
}
