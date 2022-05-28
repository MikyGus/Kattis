using _2048.Grid.MoveDirection;
using _2048.Numeric;
using FluentAssertions;
using Xunit;

namespace _2048.Tests.System.Grid.MoveDirection
{
    public class MoveDirectionLeftTests
    {
        MoveDirectionLeft _sut;
        public MoveDirectionLeftTests()
        {
            _sut = new MoveDirectionLeft(4);
        }

        [Fact]
        public void Vector_ShouldReturnM1x0_WhenCalled()
        {
            // Arrange
            // Act
            GridPosition result = _sut.Vector;
            // Assert
            result.Should().BeEquivalentTo(new GridPosition(-1, 0));
        }


        [Fact]
        public void StartPosition_ShouldReturn1x0_WhenCalledWithIndex3()
        {
            // Arrange
            // Act
            GridPosition result = _sut.StartPosition(3);
            // Assert
            result.Should().BeEquivalentTo(new GridPosition(1,0));
        }
    }
}
