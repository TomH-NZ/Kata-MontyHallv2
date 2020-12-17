

namespace MontyHallv2.Game
{
    public class MontyHallGame
    {
        public MontyHallGame()
        {
            _storage = new Storage();
        }

        private readonly Storage _storage;

        public Storage Storage => _storage;

        public void UpdatePrizeLocation(IRandomDoor randomDoor)
        {
            var seriousPrizeLocation = randomDoor.Generator();

            Storage.PrizeStorage[seriousPrizeLocation] = "serious";
        }
    }
}