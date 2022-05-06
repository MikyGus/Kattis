using _2048.UserData.DataValidation;
using FluentAssertions;
using Xunit;

namespace _2048.Tests.System.UserData.DataValidation
{
    public class DirectionDataValidationTests
    {
        [Theory]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(3, true)]
        [InlineData(-1, false)]
        [InlineData(4, false)]
        public void IsValidDirection_ShouldReturnTrue_WhenValueIsInclusiveBetween0And3(int value, bool expectedIsValid)
        {
            // Arrange
            DirectionDataValidation sut = new DirectionDataValidation();
            // Act
            bool result = sut.IsValid(value);
            // Assert
            result.Should().Be(expectedIsValid);
        }
    }
}
