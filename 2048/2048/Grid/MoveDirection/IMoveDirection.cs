using _2048.Numeric;

namespace _2048.Grid.MoveDirection
{
    public interface IMoveDirection
    {
        public GridPosition Vector { get; }
        public GridPosition StartPosition(int positionIndex);
    }
}
