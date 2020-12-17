using System.Collections.Generic;
using MontyHallv2.Enums;

namespace MontyHallv2.Game
{
    public class Storage
    {
        public Dictionary<Doors, string>PrizeStorage = new Dictionary<Doors, string>
        {
            {Doors.one, "joke"},
            {Doors.two, "joke"},
            {Doors.three, "joke"}
        };

        public Storage()
        {
        }
    }
}