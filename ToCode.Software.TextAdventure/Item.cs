using System.Collections.Generic;

namespace ToCode.Software.TextAdventure
{
    public class Item
    {
        public string Name { get; set; }
        public List<Event> ItemEvents { get; set; } = new List<Event>();
    }
}