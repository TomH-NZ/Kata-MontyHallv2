using Xunit;
using MontyHallv2.Enums;
using MontyHallv2.Game;
using MontyHallv2.Validation;

namespace MontyHallv2UnitTests.ValidationTests
{
    public class ValidationTestsShould
    {
        [Fact]
        public void ConfirmTheUserInputDoorIsValid()
        {
            //Arrange
            var userInput = Doors.three;
            
            //Act
            var result = InputValidation.UserInputValidation(userInput);

            //Assert
            Assert.True(result);
        }
    }
}