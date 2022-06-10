using _2048.Grid;

namespace _2048.UserData.OutputWriter
{
    public interface IOutputWrite
    {
        void WriteData(IGridArea gridArea);
    }
}
