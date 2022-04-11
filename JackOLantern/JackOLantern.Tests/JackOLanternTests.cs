using FluentAssertions;
using System;
using Xunit;

namespace JackOLantern.Tests
{
    public class JackOLanternTests
    {
        [Theory]
        [InlineData(new int[] { 3, 4, 5 }, 60)]
        [InlineData(new int[] { 2, 2, 2 }, 8)]
        [InlineData(new int[] { 3, 1, 5 }, 15)]

        public void PossibleUniqueLanterns_ShouldReturnCorrectNumber_WhenCalledWithAnArrayOfIntegers(int[] values, int expectedValue)
        {
            // Arrange
            // Act
            var result = JackOLantern.Program.PossibleUniqueLanterns(values);
            // Assert
            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData("3 4 5", new int[] { 3, 4, 5 })]
        [InlineData("1 5 7", new int[] { 1, 5, 7 })]
        public void ConvertToIntArrayFromString_ShouldReturnAnIntArray_WhenCalledWithAString(string values, int[] expectedValue)
        {
            // Arrange
            // Act
            var result = Program.ConvertToIntArrayFromString(values);
            // Assert
            result.Should().BeEquivalentTo(expectedValue);
        }
    }
}
