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
            var userSelection = Doors.three;
            
            //Act
            var result = Validation.UserInput(userSelection);

            //Assert
            Assert.True(result);
        }
    }
}