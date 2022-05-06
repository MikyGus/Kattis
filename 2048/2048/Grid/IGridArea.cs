using System.Drawing;

namespace _2048.Grid
{
    public interface IGridArea
    {
        int[,] Grid { get; }
        int GridSize { get; }
        void NewRound();
        bool CanMoveHere(Point originPosition, Point targetPosition);
        void MoveToPosition(Point originPosition, Point targetPosition);

        //int GridSize { get; }

        ///// <summary>
        ///// Moves/Merges cells
        ///// </summary>
        ///// <param name="origin"></param>
        ///// <param name="target"></param>
        ///// <returns>Returns true if move is successfull</returns>
        //bool MoveCell(Point origin, Point target);
        //bool IsInGrid(Point pointToCheck);
        //bool CanMergeCells(Point cell1, Point cell2);
        //int[,] Grid { get; }
    }
}