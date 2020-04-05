using System.Collections.Generic;

namespace ToCode.Software.TextAdventure
{
    public class Event
    {
        public Action TriggerAction { get; set; }
        public List<Item> RequiredItems { get; set; }
        public List<Location> RequiredLocations { get; set; }
        public string Response { get; set; }
        public delegate void UpdateGame();
    }
}