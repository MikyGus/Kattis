using _2048.Tests.Fixtures;
using _2048.UserData;
using _2048.UserData.DataConvertion;
using _2048.UserData.DataValidation;
using _2048.UserData.InputReader;
using FluentAssertions;
using Moq;
using Xunit;

namespace _2048.Tests.System.UserData
{
    public class UserInputGridTests
    {
        Mock<IInputRead> _inputRead;
        Mock<IDataConverter<string, int>> _converter;
        Mock<IDataValidation<int[,]>> _validation;
        IUserInput<int> _sut;

        public UserInputGridTests()
        {
            _inputRead = new Mock<IInputRead>(MockBehavior.Strict);
            _inputRead.SetupSequence(x => x.RetreiveData())
                .Returns("2 0 0 2")
                .Returns("2 2 0 0")
                .Returns("4 2 0 0")
                .Returns("4 2 2 2");

            _converter = new Mock<IDataConverter<string, int>>(MockBehavior.Strict);
            _converter.SetupSequence(x => x.Convert(It.IsAny<string[]>()))
                .Returns(GridFixtures.Origin());

            _validation = new Mock<IDataValidation<int[,]>>(MockBehavior.Strict);
            _validation.Setup(x => x.IsValid(It.IsAny<int[,]>())).Returns(true);

            _sut = new UserInput(_inputRead.Object, _converter.Object);
        }

        [Fact]
        public void ReadGridInput_ShouldReturnValidIntegerArray_WhenCalled()
        {
            // Arrange
            // Act
            var result = _sut.ReadGridInput(_validation.Object,4);
            // Assert
            result.Should().BeEquivalentTo(GridFixtures.Origin());
        }

        [Fact]
        public void ReadGridInput_ShouldInvokeMethods_WhenCalled()
        {
            // Arrange
            // Act
            _ = _sut.ReadGridInput(_validation.Object, 4);
            // Assert
            _inputRead.Verify(x => x.RetreiveData(), Times.Exactly(4));
            _converter.Verify(x => x.Convert(It.IsAny<string[]>()), Times.Once());
            _validation.Verify(x => x.IsValid(It.IsAny<int[,]>()), Times.Once());
        }
    }
}
