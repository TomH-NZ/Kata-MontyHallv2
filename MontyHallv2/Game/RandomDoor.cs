using System;
using MontyHallv2.Enums;

namespace MontyHallv2.Game
{
    public class RandomDoor : IRandomDoor
    {
        public Doors Generator()
        {
            var randomDoor = new Random().Next(1, 4) switch
            {
                1 => Doors.one,
                2 => Doors.two,
                3 => Doors.three
            };

            return randomDoor;
        }
    }
}