using _2048.Grid.MoveDirection;
using _2048.Numeric;

namespace _2048.Grid
{
    internal class GridNavigator : IGridNavigator
    {
        private readonly IGridArea _gridArea;

        public GridNavigator(IGridArea gridArea)
        {
            _gridArea = gridArea;
        }

        public void MoveGridInDirection(IMoveDirection direction)
        {
            for (int i = 0; i < NumberOfStartPositions(_gridArea.GridSize); i++)
            {
                GridPosition startPosition = direction.StartPosition(i);
                GridPosition checkPosition = startPosition + direction.Vector;
                while (_gridArea.IsInGrid(startPosition))
                {

                }

            }
        }

        private int NumberOfStartPositions(int gridSize)
        {
            return (gridSize * gridSize) - gridSize;
        }

        //private void FurtherstPositionCellValueCanMove(Point startPosition, )
    }
}
