using _2048.UserData;
using _2048.UserData.DataConvertion;
using _2048.UserData.DataValidation;
using _2048.UserData.InputReader;
using FluentAssertions;
using Moq;
using Xunit;

namespace _2048.Tests.System.UserData
{
    public class UserInputTests
    {
        string inputFromUser = "1";
        int directionFromUser = 1;
        Mock<IInputRead> _inputRead;
        Mock<IDataConverter<string, int>> _converter;
        Mock<IDataValidation<int>> _validation;
        IUserInput<int> _sut;

        public UserInputTests()
        {
            _inputRead = new Mock<IInputRead>(MockBehavior.Strict);
            _inputRead.Setup(x => x.RetreiveData()).Returns(inputFromUser);
            _converter = new Mock<IDataConverter<string, int>>(MockBehavior.Strict);
            _converter.Setup(x => x.Convert(It.IsAny<string>())).Returns(directionFromUser);
            _validation = new Mock<IDataValidation<int>>(MockBehavior.Strict);
            _validation.Setup(x => x.IsValid(It.IsAny<int>())).Returns(true);
            _sut = new UserInput(_inputRead.Object, _converter.Object);
        }

        [Fact]
        public void ReadSingleInput_ShouldReturnValidInteger_WhenCalled()
        {
            // Arrange
            // Act
            var result = _sut.ReadSingleInput(_validation.Object);
            // Assert
            result.Should().Be(directionFromUser);
        }


        [Fact]
        public void ReadSingleInput_ShouldInvokeMethods_WhenCalled()
        {
            // Arrange
            // Act
            _ = _sut.ReadSingleInput(_validation.Object);
            // Assert
            _inputRead.Verify(x => x.RetreiveData(), Times.Once());
            _converter.Verify(x => x.Convert(It.IsAny<string>()), Times.Once());
            _validation.Verify(x => x.IsValid(It.IsAny<int>()), Times.Once());
        }
    }
}
