using _2048.Grid.MoveDirection;
using _2048.Numeric;
using FluentAssertions;
using Xunit;

namespace _2048.Tests.System.Grid.MoveDirection
{
    public class MoveDirectionDownTests
    {
        MoveDirectionDown _sut;
        public MoveDirectionDownTests()
        {
            _sut = new MoveDirectionDown(4);
        }

        [Fact]
        public void Vector_ShouldReturn0x1_WhenCalled()
        {
            // Arrange
            // Act
            GridPosition result = _sut.Vector;
            // Assert
            result.Should().BeEquivalentTo(new GridPosition(0, 1));
        }


        [Fact]
        public void StartPosition_ShouldReturn0x2_WhenCalledWithIndex3()
        {
            // Arrange
            // Act
            GridPosition result = _sut.StartPosition(3);
            // Assert
            result.Should().BeEquivalentTo(new GridPosition(0,2));
        }
    }
}
