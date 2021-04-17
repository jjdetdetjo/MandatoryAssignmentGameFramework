using System.Collections.Generic;
using System.Reflection.Metadata;

namespace GameFrameworkLibrary
{
    public abstract class Creature
    {
        public int Id { get; set; }
        public static int IdCounter { get; set; } = 1;
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int ReceivedDamage { get; set; }
        public AttackItem AttackItem { get; set; }
        public DefenseItem DefenseItem { get; set; }
        public Position Position { get; set; }
        public CreatureStates MyState = new CreatureStates();
        public string Symbol { get; set; }
        public bool ActedThisRound { get; set; } = false;

        public void Act()
        {
            ReceiveDamage();
            MyState.StateFunctions(MyState, MaxHealth, CurrentHealth);
            if (MyState.CurrentState != CreatureStates.State.Dead)
            {
                Hit(World.NearbyCreatures);
                Loot(World.NearbyObjects);
                Move();
            }
        }

        public abstract void Hit(List<Creature> creatureList);

        public abstract void Loot(List<WorldObject> worldObjectList);

        public abstract void ReceiveDamage();

        public abstract void Move();
    }
}