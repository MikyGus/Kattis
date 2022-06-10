using _2048.Grid.MoveDirection;
using _2048.Numeric;

namespace _2048.Grid
{
    public class GridNavigator : IGridNavigator
    {
        private readonly IGridArea _gridArea;

        public GridNavigator(IGridArea gridArea)
        {
            _gridArea = gridArea;
        }

        public void MoveGridInDirection(IMoveDirection direction)
        {
            int numberOfStartPositions = NumberOfStartPositions(_gridArea.GridSize);
            for (int i = 0; i < numberOfStartPositions; i++)
            {
                GridPosition startPosition = direction.StartPosition(i);
                GridPosition moveTo = FindMoveToPosition(startPosition, direction);
                if (moveTo.IsEqualTo(startPosition) == false)
                {
                    _gridArea.MoveToPosition(direction.StartPosition(i),moveTo);
                }
            }
        }

        private int NumberOfStartPositions(int gridSize)
        {
            return (gridSize * gridSize) - gridSize;
        }


        private GridPosition FindMoveToPosition(GridPosition startPosition, IMoveDirection direction)
        {
            int k = 1;
            GridPosition lastOkPosition = startPosition;
            GridPosition checkPosition = startPosition + direction.Vector;
            while (_gridArea.CanMoveHere(startPosition, checkPosition))
            {
                if (_gridArea.CanMerge(startPosition,checkPosition))
                {
                    return checkPosition;
                }
                lastOkPosition = checkPosition;
                checkPosition = startPosition + (direction.Vector * ++k);
            }
            return lastOkPosition;
        }

        public IGridArea GetGridArea()
        {
            return _gridArea;
        }
    }
}
