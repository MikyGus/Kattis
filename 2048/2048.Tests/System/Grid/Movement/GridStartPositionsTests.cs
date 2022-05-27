using _2048.Grid.MoveDirection;
using _2048.Grid.Movement;
using _2048.Numeric;
using _2048.Tests.Fixtures;
using FluentAssertions;
using Xunit;

namespace _2048.Tests.System.Grid.Movement
{
    public class GridStartPositionsTests
    {

        public class WhenIteratingThroughWithMovenext
        {
            [Fact]
            public void GivenMoveGridLeft_ShouldThenReturnCollectionOfPoint_1x3_To_3x0()
            {
                // Arrange
                GridStartPosition sut = new GridStartPosition(
                    new MoveDirectionLeft(4), 4);
                // Act
                // Assert
                sut.Should().BeEquivalentTo<GridPosition>(GridFixtures.CellArrayWhenGridLeft());
            }

            [Fact]
            public void GivenMoveGridUp_ShouldThenReturnCollectionOfPoint_0x1_To_3x3()
            {
                // Arrange
                GridStartPosition sut = new GridStartPosition(
                    new MoveDirectionUp(4), 4);
                // Act
                // Assert
                sut.Should().BeEquivalentTo<GridPosition>(GridFixtures.CellArrayWhenGridUp());
            }

            [Fact]
            public void GivenMoveGridRight_ShouldThenReturnCollectionOfPoint_2x0_To_0x3()
            {
                // Arrange
                GridStartPosition sut = new GridStartPosition(
                    new MoveDirectionRight(4), 4);
                // Act
                // Assert
                sut.Should().BeEquivalentTo<GridPosition>(GridFixtures.CellArrayWhenGridRight());
            }

            [Fact]
            public void GivenMoveGridDown_ShouldThenReturnCollectionOfPoint_3x2_To_0x0()
            {
                // Arrange
                GridStartPosition sut = new GridStartPosition(
                    new MoveDirectionDown(4), 4);
                // Act
                // Assert
                sut.Should().BeEquivalentTo<GridPosition>(GridFixtures.CellArrayWhenGridDown());
            }


        }


    }
}
