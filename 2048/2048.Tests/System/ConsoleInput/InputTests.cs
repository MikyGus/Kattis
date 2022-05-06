//using _2048.UserData.InputReader;
//using FluentAssertions;
//using System;
//using System.Collections.Generic;
//using Xunit;

//namespace _2048.Tests
//{
//    public class InputTests
//    {
//        public static IEnumerable<object[]> TestData =>
//        new List<object[]>
//        {
//            new object[] 
//            { 
//                new string[] { "1 2 3 4", "5 6 7 8", "9 10 11 12", "13 14 15 16" }, 
//                new int[,] { {1, 5, 9, 13 }, { 2, 6, 10, 14 }, { 3, 7, 11, 15 }, { 4, 8, 12, 16 } } 
//            },
//        };

//        [Theory, MemberData(nameof(TestData))]
//        public void ConvertStringArrayToIntGrid_ShouldReturnIntGrid_WhenCalledWithAStringArray(string[] testValue, int[,] expectedValue)
//        {
//            // Arrange
//            var input = new UserData.InputReader.InputRead((value) => true);
//            // Act
//            var result = input.ConvertStringArrayToIntGrid(testValue,4);
//            // Assert
//            result.Should().BeEquivalentTo(expectedValue);
//        }
//    }
//}
