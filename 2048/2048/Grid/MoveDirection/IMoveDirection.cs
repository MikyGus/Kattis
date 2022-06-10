using _2048.Numeric;

namespace _2048.Grid.MoveDirection
{
    public interface IMoveDirection
    {
        GridPosition Vector { get; }
        GridPosition StartPosition(int positionIndex);
    }
}
