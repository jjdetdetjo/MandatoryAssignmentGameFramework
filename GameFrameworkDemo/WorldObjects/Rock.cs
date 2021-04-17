using System;
using GameFrameworkLibrary;

namespace GameFrameworkDemo
{
    public class Rock : WorldObject
    {
        public int RockIdCounter { get; set; } = 1;

        public Rock(bool lootable, string name, bool removable, Position position)
        {
            Id = RockIdCounter++;
            Lootable = lootable;
            Name = name;
            Removable = removable;
            Position = position;
            Symbol = "R";
        }

        public override void Looted()
        {
        }
    }
}