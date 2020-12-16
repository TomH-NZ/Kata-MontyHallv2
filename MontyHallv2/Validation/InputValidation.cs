using System;
using MontyHallv2.Enums;
using MontyHallv2.Game;

namespace MontyHallv2.Validation
{
    public static class InputValidation
    {
        public static bool UserInputValidation(Doors userInput)
        {
            return Enum.IsDefined(typeof(Doors), userInput);
        }
    }
}