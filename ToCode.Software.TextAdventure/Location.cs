using System.Collections.Generic;
using System.Drawing;

namespace ToCode.Software.TextAdventure
{
    public class Location
    {
        public Point Coordinates { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Event> LocationEvents { get; set; }
    }
}