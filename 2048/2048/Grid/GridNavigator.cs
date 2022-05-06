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

        public void MoveGridInDirection(int direction)
        {
            GridStartPosition gridStartPositions = new GridStartPosition(direction,_gridArea.GridSize);
            foreach (var position in gridStartPositions)
            {
                System.Console.WriteLine(position);
            }
        }
    }
}
