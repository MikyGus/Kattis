using _2048.Grid;
using _2048.Tests.Fixtures;
using FluentAssertions;
using System.Drawing;
using Xunit;

namespace _2048.Tests.System.Grid
{
    public class GridAreaTests
    {
        IGridArea _sut;
        public GridAreaTests()
        {
            _sut = new GridArea(GridFixtures.Origin());
        }


        [Fact]
        public void CanMoveHere_ShouldReturnFalse_WhenPositionsIsOutsideGrid()
        {
            // Arrange
            Point origin = new Point(0,0);
            Point target = new Point(5,5);
            // Act
            bool result =_sut.CanMoveHere(origin, target);
            // Assert
            result.Should().BeFalse();
        }


        [Fact]
        public void CanMoveHere_ShouldReturnFalse_WhenValuesAreDifferent()
        {
            // Arrange
            Point origin = new Point(0,0);
            Point target = new Point(1,1);
            // Act
            bool result = _sut.CanMoveHere(origin, target);
            // Assert
            result.Should().BeFalse();
        }


        [Fact]
        public void CanMoveHere_ShouldReturnFalse_WhenOriginValueIsZero()
        {
            // Arrange
            Point origin = new Point(1, 0);
            Point target = new Point(1, 1);
            // Act
            bool result = _sut.CanMoveHere(origin, target);
            // Assert
            result.Should().BeFalse();
        }


        [Fact]
        public void CanMoveHere_ShouldReturnTrue_WhenTargetValueIsZero()
        {
            // Arrange
            Point origin = new Point(1, 1);
            Point target = new Point(1, 0);
            // Act
            bool result = _sut.CanMoveHere(origin, target);
            // Assert
            result.Should().BeTrue();
        }


        [Fact]
        public void CanMoveHere_ShouldReturnFalse_WhenTargetCellAllreadyHaveMerged()
        {
            // Arrange
            _sut.MoveToPosition(new Point(0,1), new Point(0,0));
            Point origin = new Point(0, 2);
            Point target = new Point(0, 0);
            // Act
            bool result = _sut.CanMoveHere(origin, target);
            // Assert
            result.Should().BeFalse();
        }


        [Fact]
        public void MoveToPosition_ShouldMoveCellValueIn1x1To1x0_WhenCalledToMoveCell1x1To1x0()
        {
            // Arrange
            Point origin = new Point(1, 1);
            Point target = new Point(1, 0);
            // Act
            _sut.MoveToPosition(origin, target);
            // Assert
            _sut.Grid.Should().BeEquivalentTo(GridFixtures.Result_Cell1x1Up());
        }


        [Fact]
        public void GridSize_ShouldReturn4_WhenGridIs4x4()
        {
            // Arrange
            // Act
            // Assert
            _sut.GridSize.Should().Be(4);
        }
        //[Fact]
        //public void GridSize_ShouldReturn4_WhenWhenCalledWithA4x4Grid()
        //{
        //    // Arrange

        //    // Act
        //    int result = _sut.GridSize;
        //    // Assert
        //    result.Should().Be(4);
        //}


        //[Fact]
        //public void MoveCell_ShouldMoveCellvalueInGridToNewPosition_WhenCalledWithNewPositions()
        //{
        //    // Arrange
        //    Point origin = new Point(1, 1);
        //    Point target = new Point(1, 0);
        //    // Act
        //    _sut.MoveCell(origin, target);
        //    // Assert
        //    _sut.Grid.Should().BeEquivalentTo(GridFixtures.Result_Cell1x1Up());
        //}

        //[Theory]
        //[InlineData(0, 0, true)]
        //[InlineData(-1, 0, false)]
        //[InlineData(1, 1, true)]
        //[InlineData(3, 3, true)]
        //[InlineData(0, 5, false)]
        //[InlineData(5, 3, false)]
        //[InlineData(5, 7, false)]
        //[InlineData(4, 4, false)]
        //[InlineData(-1, -1, false)]
        //public void IsPointInsideGrid_ShouldReturnTrue_WhenPointIsInsideGrid(int x, int y, bool expectedIsInsideGrid)
        //{
        //    // Arrange
        //    IGridArea sut = new GridArea(GridFixtures.Origin());
        //    Point cellToTest = new Point(x, y);
        //    // Act
        //    bool result = sut.IsInGrid(cellToTest);
        //    // Assert
        //    result.Should().Be(expectedIsInsideGrid);
        //}

        //[Theory]
        //[InlineData(1, 0, 0, 0, false)]
        //[InlineData(1, 1, 1, 0, true)]
        //[InlineData(0, 1, 0, 0, true)]
        //public void CanMergeCells_ShouldReturnTrue_WhenPointContainsSameValueAndNotMergedThisRun(
        //    int sourceX, int sourceY, int targetX, int targetY, bool expectedValue)
        //{
        //    // Arrange
        //    IGridArea sut = new GridArea(GridFixtures.Origin());
        //    Point sourceCell = new Point(sourceX, sourceY);
        //    Point targetCell = new Point(targetX, targetY);
        //    // Act
        //    bool result = sut.CanMergeCells(sourceCell, targetCell);
        //    // Assert
        //    result.Should().Be(expectedValue);
        //}


        //[Fact]
        //public void CanMergeCells_ShouldFalse_WhenCellIsAlreadyMerdeThisRound()
        //{
        //    // Arrange
        //    IGridArea sut = new GridArea(GridFixtures.Origin());
        //    bool haveMovedCell = sut.MoveCell(new Point(1, 2), new Point(1, 3));
        //    haveMovedCell.Should().BeTrue();
        //    // Act
        //    bool result = sut.CanMergeCells(new Point(1, 1), new Point(1, 3));
        //    // Assert
        //    result.Should().BeFalse();
        //}
    }
}
