using System;
using MontyHallv2.Enums;

namespace MontyHallv2.ValidationProcesses
{
    public static class Validation
    {
        public static bool UserDoorSelection(Doors userSelection)
        {
            return Enum.IsDefined(typeof(Doors), userSelection);
        }

        public static bool ChangeDoorInput(ChangeDoorOption userInput)
        {
            return Enum.IsDefined((typeof(ChangeDoorOption)), userInput);
        }
    }
}