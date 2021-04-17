using System;
using System.Runtime.InteropServices.ComTypes;

namespace GameFrameworkLibrary
{
    public abstract class WorldObject
    {
        public int Id { get; set; }
        public int IdCounter { get; set; } = 1;
        public bool Lootable { get; set; }
        public string Name { get; set; }
        public bool Removable { get; set; }
        public bool Removed { get; set; } = false;
        public AttackItem AttackItem { get; set; }
        public DefenseItem DefenseItem { get; set; }
        public Position Position { get; set; }
        public string Symbol { get; set; }

        public void Act()
        {
            Looted();
        }

        public abstract void Looted();
    }
}