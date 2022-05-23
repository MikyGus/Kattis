using _2048.Grid.MoveDirection;
using _2048.Grid.Movement;
using System.Drawing;

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
            GridStartPosition gridStartPositions = new GridStartPosition(direction,_gridArea.GridSize);
            foreach (var position in gridStartPositions)
            {
                System.Console.WriteLine(position);

                // If up
                Point moveVector = new Point(0, -1);

            }
        }

        //private void FurtherstPositionCellValueCanMove(Point startPosition, )
    }
}
