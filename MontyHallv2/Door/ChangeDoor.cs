using System;
using MontyHallv2.Enums;

namespace MontyHallv2.Door
{
    public class ChangeDoor
    {
        public static Doors NewUserSelection(Doors playerSelection, Doors announcerSelection)
        {
            Doors? output = null;

            foreach (Doors entry in Enum.GetValues(typeof(Doors)))
            {
                if (entry != playerSelection && entry != announcerSelection)
                {
                    output = entry;
                }
            }

            return output.Value;
            //return Doors.three;
        }
    }
}