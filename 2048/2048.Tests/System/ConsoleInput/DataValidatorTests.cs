//using _2048.UserData;
//using FluentAssertions;
//using Xunit;

//namespace _2048.Tests
//{
//    public class DataValidatorTests
//    {
//        [Theory]
//        // Valid values: { 0, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 }
//        [InlineData(0, true)] // 0 == Empty
//        [InlineData(1, false)]
//        [InlineData(2, true)]
//        [InlineData(3, false)]
//        [InlineData(4, true)]
//        public void IsValid2048Data_ShouldReturnTrue_WhenValueIsAmongTheValidList_ElseFalse(int value, bool expextedIsValid)
//        {
//            // Arrange
//            var validator = new DataValidator();
//            // Act
//            bool result = validator.IsValid2048Data(value);
//            // Assert
//            result.Should().Be(expextedIsValid);
//        }

//        [Theory]
//        [InlineData(0,true)]
//        [InlineData(1,true)]
//        [InlineData(3,true)]
//        [InlineData(-1,false)]
//        [InlineData(4,false)]
//        public void IsValidDirection_ShouldReturnTrue_WhenValueIsInclusiveBetween0And3(int value, bool expectedIsValid)
//        {
//            // Arrange
//            DataValidator validator = new DataValidator();
//            // Act
//            bool result = validator.IsValidDirection(value);
//            // Assert
//            result.Should().Be(expectedIsValid);
//        }
//    }
//}
