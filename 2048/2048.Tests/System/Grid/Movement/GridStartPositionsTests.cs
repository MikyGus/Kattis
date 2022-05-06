using _2048.Grid.Movement;
using _2048.Tests.Fixtures;
using FluentAssertions;
using System.Drawing;
using Xunit;

namespace _2048.Tests.System.Grid.Movement
{
    public class GridStartPositionsTests
    {

        public class WhenIteratingThroughWithMovenext
        {
            [Fact]
            public void GivenMoveGridUp_ShouldThenReturnCollectionOfPoint_0x1_To_3x3()
            {
                // Arrange
                GridStartPosition sut = new GridStartPosition(1, 4);
                // Act
                // Assert
                sut.Should().BeEquivalentTo<Point>(GridFixtures.CellArrayWhenGridUp());
            }

            [Fact]
            public void GivenMoveGridLeft_ShouldThenReturnCollectionOfPoint_1x0_To_3x3()
            {
                // Arrange
                GridStartPosition sut = new GridStartPosition(0, 4);
                // Act
                // Assert
                sut.Should().BeEquivalentTo<Point>(GridFixtures.CellArrayWhenGridLeft());
            }

        }


    }
}
