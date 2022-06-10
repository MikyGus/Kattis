using _2048.Numeric;
using System;

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

        public bool CanMoveHere(GridPosition originPosition, GridPosition targetPosition)
        {
            if (IsInGrid(originPosition) == false || IsInGrid(targetPosition) == false)
            {
                return false;
            }
            else if (PositionIsEmpty(originPosition))
            {
                return false;
            }
            else if (PositionIsEmpty(targetPosition))
            {
                return true;
            }
            else if (PositionIsMerged(targetPosition))
            {
                return false;
            }
            return PositionsHaveEqualValue(originPosition, targetPosition);
        }

        public void MoveToPosition(GridPosition originPosition, GridPosition targetPosition)
        {
            if (IsInGrid(originPosition) == false || IsInGrid(targetPosition) == false)
            {
                return;
            }
            int OriginValue = _grid[originPosition.X, originPosition.Y];
            int TargetValue = _grid[targetPosition.X, targetPosition.Y];

            _grid[targetPosition.X, targetPosition.Y] = OriginValue + TargetValue;
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

        public bool IsInGrid(GridPosition pointToCheck)
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


        private bool PositionIsEmpty(GridPosition gridPosition)
        {
            return _grid[gridPosition.X, gridPosition.Y] == 0;
        }

        private bool PositionIsMerged(GridPosition gridPosition)
        {
            return _gridMerged[gridPosition.X, gridPosition.Y] == 1;
        }

        private bool PositionsHaveEqualValue(GridPosition position1, GridPosition position2)
        {
            return _grid[position1.X, position1.Y] == _grid[position2.X, position2.Y];
        }

        public bool CanMerge(GridPosition originPosition, GridPosition targetPosition)
        {
            return PositionsHaveEqualValue(originPosition, targetPosition) &&
                PositionIsMerged(targetPosition) == false &&
                PositionIsEmpty(targetPosition) == false;
        }
    }
}
