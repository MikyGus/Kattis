using _2048.Numeric;

namespace _2048.Grid
{
    public interface IGridArea
    {
        int[,] Grid { get; }
        int GridSize { get; }
        void NewRound();
        bool CanMoveHere(GridPosition originPosition, GridPosition targetPosition);
        void MoveToPosition(GridPosition originPosition, GridPosition targetPosition);
        bool IsInGrid(GridPosition position);
        bool CanMerge(GridPosition originPosition, GridPosition targetPosition);
    }
}