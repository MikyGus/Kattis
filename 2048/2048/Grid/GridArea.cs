using System;
using System.Drawing;

namespace _2048.Grid
{
    public class GridArea : IGridArea
    {
        private int[,] _grid;
        private int[,] _gridMerged;
        private readonly int _gridSize;

        public int[,] Grid => _grid;
        public int GridSize => _gridSize; 
        public GridArea(int[,] grid)
        {
            _grid = grid;
            _gridSize = grid.GetUpperBound(0) + 1;
            _gridMerged = new int[_gridSize, _gridSize];
        }

        public bool CanMoveHere(Point originPosition, Point targetPosition)
        {
            if (IsInGrid(originPosition) == false || IsInGrid(targetPosition) == false)
            {
                return false;
            }
            int originValue = _grid[originPosition.X, originPosition.Y];
            int targetValue = _grid[targetPosition.X, targetPosition.Y];
            if (originValue == 0)
            {
                return false;
            }
            if (targetValue == 0)
            {
                return true;
            }
            if (_gridMerged[targetPosition.X,targetPosition.Y] == 1)
            {
                return false;
            }
            return originValue == targetValue;

        }

        public void MoveToPosition(Point originPosition, Point targetPosition)
        {
            int OriginValue = _grid[originPosition.X,originPosition.Y];
            int TargetValue = _grid[targetPosition.X,targetPosition.Y];

            _grid[targetPosition.X,targetPosition.Y] = OriginValue + TargetValue;
            _grid[originPosition.X, originPosition.Y] = 0;

            if (OriginValue == TargetValue)
            {
                _gridMerged[targetPosition.X, targetPosition.Y] = 1;
            }
            
        }

        public void NewRound()
        {
            throw new NotImplementedException();
        }

        private bool IsInGrid(Point pointToCheck)
        {
            if (pointToCheck.X < 0 || 
                pointToCheck.Y < 0 || 
                pointToCheck.X > (_gridSize - 1) || 
                pointToCheck.Y > (_gridSize - 1))
            {
                return false;
            }
            return true;
        }


        //private int[,] _grid;
        //private int[,] _gridMerged;

        //private int _gridSize;
        //public int GridSize => _gridSize;
        //public int[,] Grid => _grid;

        //public GridArea(int[,] grid)
        //{
        //    _grid = grid;
        //    _gridSize = grid.GetUpperBound(0) + 1;
        //    _gridMerged = new int[_gridSize, _gridSize];
        //}

        //private void NewRound()
        //{
        //    Array.Clear(_gridMerged, 0, _gridSize);
        //}
        //private void MarkCellAsMerged(Point cell)
        //{
        //    _gridMerged[cell.X, cell.Y] = 1;
        //}
        //private bool IsCellMerged(Point cell)
        //{
        //    return _gridMerged[cell.X, cell.Y] == 1;
        //}

        //public bool MoveCell(Point origin, Point target)
        //{
        //    int originCellValue = _grid[origin.X, origin.Y];
        //    int targetCellValue = _grid[target.X, target.Y];
        //    if (CanMergeCells(origin,target))
        //    {
        //        _grid[origin.X, origin.Y] = 0;
        //        _grid[target.X, target.Y] = originCellValue + targetCellValue;
        //        MarkCellAsMerged(target);
        //        return true;
        //    }
        //    return false;
        //}



        //public bool CanMergeCells(Point sourceCell, Point targetCell)
        //{
        //    if (_grid[targetCell.X, targetCell.Y] == 0)
        //    {
        //        return true;
        //    }
        //    if (IsCellMerged(targetCell) == false && _grid[sourceCell.X, sourceCell.Y] == _grid[targetCell.X, targetCell.Y])
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }
}
