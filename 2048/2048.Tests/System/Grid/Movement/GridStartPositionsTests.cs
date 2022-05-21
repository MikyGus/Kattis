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
            public void GivenMoveGridLeft_ShouldThenReturnCollectionOfPoint_1x3_To_3x0()
            {
                // Arrange
                GridStartPosition sut = new GridStartPosition(0, 4);
                // Act
                // Assert
                sut.Should().BeEquivalentTo<Point>(GridFixtures.CellArrayWhenGridLeft());
            }

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
            public void GivenMoveGridRight_ShouldThenReturnCollectionOfPoint_2x0_To_0x3()
            {
                // Arrange
                GridStartPosition sut = new GridStartPosition(2, 4);
                // Act
                // Assert
                sut.Should().BeEquivalentTo<Point>(GridFixtures.CellArrayWhenGridRight());
            }

            [Fact]
            public void GivenMoveGridDown_ShouldThenReturnCollectionOfPoint_3x2_To_0x0()
            {
                // Arrange
                GridStartPosition sut = new GridStartPosition(3, 4);
                // Act
                // Assert
                sut.Should().BeEquivalentTo<Point>(GridFixtures.CellArrayWhenGridDown());
            }


        }


    }
}
