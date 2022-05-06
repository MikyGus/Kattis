using _2048.Tests.Fixtures;
using _2048.UserData.DataValidation;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _2048.Tests.System.UserData.DataValidation
{
    public class GridDataValidationTests
    {

        [Fact]
        public void IsValid_ShouldReturnTrue_WhenGridArrayContainsValidIntegers()
        {
            // Arrange
            GridDataValidation sut = new GridDataValidation();
            // Act
            bool result = sut.IsValid(GridFixtures.GridDataValid());
            // Assert
            result.Should().BeTrue(); 
        }

        [Fact]
        public void IsValid_ShouldReturnFalse_WhenGridArrayContainsInValidIntegers()
        {
            // Arrange
            GridDataValidation sut = new GridDataValidation();
            // Act
            bool result = sut.IsValid(GridFixtures.GridDataInValid());
            // Assert
            result.Should().BeFalse();
        }
    }
}
