using _2048.Grid;
using _2048.Grid.MoveDirection;
using _2048.Tests.Fixtures;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _2048.Tests.System.Grid
{
    public class GridNavigatorTests
    {

        [Fact]
        public void MoveGridInDirection_ShouldFixtureLeft_WhenMoveDirectionIsLeft()
        {
            // Arrange
            int GridSize = 4;
            int Index = 0;
            IMoveDirection moveDirection = new MoveDirectionLeft(GridSize);
            IGridArea grid = new GridArea(GridFixturesOriginalAndResult.Start(Index));
            IGridNavigator sut = new GridNavigator(grid);
            // Act
            sut.MoveGridInDirection(moveDirection);

            // Assert
            sut.GetGridArea().Grid.Should().BeEquivalentTo(GridFixturesOriginalAndResult.Result(Index));
        }

        [Fact]
        public void MoveGridInDirection_ShouldReturnFixtureUP_WhenMoveDirectionIsUp()
        {
            // Arrange
            int GridSize = 4;
            int IndexStart = 0;
            int IndexResult = 1;
            IMoveDirection moveDirection = new MoveDirectionUp(GridSize);
            IGridArea grid = new GridArea(GridFixturesOriginalAndResult.Start(IndexStart));
            IGridNavigator sut = new GridNavigator(grid);
            // Act
            sut.MoveGridInDirection(moveDirection);

            // Assert
            sut.GetGridArea().Grid.Should().BeEquivalentTo(GridFixturesOriginalAndResult.Result(IndexResult));
        }

        [Fact]
        public void MoveGridInDirection_ShouldReturnFixtureRight_WhenMoveDirectionIsRight()
        {
            // Arrange
            int GridSize = 4;
            int IndexStart = 0;
            int IndexResult = 2;
            IMoveDirection moveDirection = new MoveDirectionRight(GridSize);
            IGridArea grid = new GridArea(GridFixturesOriginalAndResult.Start(IndexStart));
            IGridNavigator sut = new GridNavigator(grid);
            // Act
            sut.MoveGridInDirection(moveDirection);

            // Assert
            sut.GetGridArea().Grid.Should().BeEquivalentTo(GridFixturesOriginalAndResult.Result(IndexResult));
        }

        [Fact]
        public void MoveGridInDirection_ShouldReturnFixtureDown_WhenMoveDirectionIsDown()
        {
            // Arrange
            int GridSize = 4;
            int IndexStart = 0;
            int IndexResult = 3;
            IMoveDirection moveDirection = new MoveDirectionDown(GridSize);
            IGridArea grid = new GridArea(GridFixturesOriginalAndResult.Start(IndexStart));
            IGridNavigator sut = new GridNavigator(grid);
            // Act
            sut.MoveGridInDirection(moveDirection);

            // Assert
            sut.GetGridArea().Grid.Should().BeEquivalentTo(GridFixturesOriginalAndResult.Result(IndexResult));
        }
    }
}
