using MontyHallv2.Game;
using Xunit;

namespace MontyHallv2UnitTests.DoorTests
{
    public class DoorTestsShould
    {
        [Fact]
        public void GenerateThreeDoorsForTheGame()
        {
            //Arrange
            var game = new MontyHallGame();
            
            //Act
            var actual = game.PrizeStorage.Count;
            
            //Assert
            Assert.Equal(3, actual);
        }

        [Fact]
        public void ReturnARandomDoorWhenCalled()
        {
            //Arrange
            
            //Act
            
            //Assert
            
        }
    }
}