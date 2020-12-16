using System;
using MontyHallv2.Enums;
using MontyHallv2.Game;

namespace MontyHallv2.Validation
{
    public static class Validation
    {
        public static bool UserInput(Doors userSelection)
        {
            return Enum.IsDefined(typeof(Doors), userSelection);
        }
    }
}