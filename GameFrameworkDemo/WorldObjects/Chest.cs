using System;
using GameFrameworkLibrary;

namespace GameFrameworkDemo
{
    public class Chest : WorldObject
    {
        public int ChestIdCounter { get; set; } = 1;

        public Chest(bool lootable, string name, bool removable, Position position, AttackItem attackItem, DefenseItem defenseItem)
        {
            Id = ChestIdCounter++;
            Lootable = lootable;
            Name = name;
            Removable = removable;
            Position = position;
            Symbol = "C";
            AttackItem = attackItem;
            DefenseItem = defenseItem;
        }

        public override void Looted()
        {
            if (DefenseItem == null && AttackItem == null)
            {
                Removed = true;
            }
        }
    }
}