using System.Collections.Generic;

namespace ToCode.Software.TextAdventure
{
    public class Player
    {
        public string Name { get; set; } = "Player";
        public List<Item> Inventory { get; set; } = new List<Item>();
        public Location CurrentLocation { get; set; }
    }
}