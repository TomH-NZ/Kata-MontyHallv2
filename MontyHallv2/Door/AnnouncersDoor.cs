using System;
using System.Collections.Generic;
using MontyHallv2.Enums;
using MontyHallv2.Game;

namespace MontyHallv2.Door
{
    public static class AnnouncersDoor
    {
        public static Doors AnnouncersSelection(Doors userSelection, Dictionary<Doors, string> montyHallPrizes)
        {
            Doors? output = null;
            
            foreach (Doors entry in Enum.GetValues(typeof(Doors)))
            {
                if (entry != userSelection || montyHallPrizes[entry] != "serious")
                {
                    output = entry;
                }
            }

            return output.Value;
            //return Doors.one;
        }
    }
}