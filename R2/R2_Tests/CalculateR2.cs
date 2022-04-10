using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace R2_Tests
{
    public class CalculateR2
    {
        [Theory]
        [InlineData(11,15,19)]
        [InlineData(4,3,2)]
        [InlineData(-1000,0,1000)]
        [InlineData(1000,0,-1000)]
        public void Creation_New_GetsInstance(int r1, int s1, int expectedValue)
        {
            // Arrange
            // Act
            var result = R2.Program.CalculateR2(r1, s1);
            // Assert
            result.Should().Be(expectedValue);
        }
    }
}
