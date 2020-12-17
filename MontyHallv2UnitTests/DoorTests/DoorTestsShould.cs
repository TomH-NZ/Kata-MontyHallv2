using MontyHallv2.Door;
using MontyHallv2.Enums;
using MontyHallv2.Game;
using Xunit;

namespace MontyHallv2UnitTests.DoorTests
{
    public class DoorTestsShould
    {
        private class StubForRandomDoorOne :IRandomDoor
        {
            public Doors Generator()
            {
                return Doors.one;
            }
        }
        
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
        public void ReturnSeriousPrizeAfterUpdatingDictionary()
        {
            //Arrange
            var game = new MontyHallGame();

            //Act
            game.UpdatePrizeLocation(new StubForRandomDoorOne());

            //Assert
            Assert.Equal("serious", game.PrizeStorage[Doors.one]);

        }

        [Fact]
        public void DisplayJokePrizeForAnnouncersDoor()
        {
            //Arrange
            var game = new MontyHallGame();

            //Act
            var result = AnnouncersDoor.AnnouncersSelection(Doors.one, game.PrizeStorage);

            //Assert
            Assert.Equal("joke", game.PrizeStorage[result]);
        }
    }
}