using System.Collections.Generic;
using MontyHallv2.Enums;

namespace MontyHallv2.Game
{
    public class MontyHallGame
    {
        private Doors PlayerSelection { get; }
        public MontyHallGame(Doors playerSelection)
        {
            PlayerSelection = playerSelection;
        }
        
        public Dictionary<Doors, string>PrizeStorage = new Dictionary<Doors, string>
        {
            {Doors.one, "joke"},
            {Doors.two, "joke"},
            {Doors.three, "joke"}
        };

        public void UpdatePrizeLocation(IRandomDoor randomDoor)
        {
            var seriousPrizeLocation = randomDoor.Generator();
            
            PrizeStorage[seriousPrizeLocation] = "serious";
        }
    }
}