using Xunit;
using MontyHallv2.Enums;
using MontyHallv2.Game;
using MontyHallv2.ValidationProcesses;

namespace MontyHallv2UnitTests.ValidationTests
{
    public class ValidationTestsShould
    {
        [Fact]
        public void ConfirmTheUserDoorSelectionIsValid()
        {
            //Arrange
            var userSelection = Doors.three;
            
            //Act
            var result = Validation.UserDoorSelection(userSelection);

            //Assert
            Assert.True(result);
        }
    }
}