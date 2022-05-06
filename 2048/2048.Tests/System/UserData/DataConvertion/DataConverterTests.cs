using _2048.UserData.DataConvertion;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace _2048.Tests.System.UserData.DataConvertion
{
    public class DataConverterTests
    {

        [Fact]
        public void Convert_ShouldReturn42_WhenInputStringIs42()
        {
            // Arrange
            IDataConverter<string, int> sut = new DataConverter();
            // Act
            int result = sut.Convert("42");
            // Assert
            result.Should().Be(42);
        }


        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[]
                {
                    new string[] { "1 2 3 4", "5 6 7 8", "9 10 11 12", "13 14 15 16" },
                    new int[,] { {1, 5, 9, 13 }, { 2, 6, 10, 14 }, { 3, 7, 11, 15 }, { 4, 8, 12, 16 } }
                },
            };

        [Theory, MemberData(nameof(TestData))]
        public void Convert_ShouldReturnIntGrid_WhenCalledWithAStringArray(string[] testValue, int[,] expectedValue)
        {
            // Arrange
            IDataConverter<string, int> sut = new DataConverter();
            // Act
            var result = sut.Convert(testValue);
            // Assert
            result.Should().BeEquivalentTo(expectedValue);
        }
    }
}
