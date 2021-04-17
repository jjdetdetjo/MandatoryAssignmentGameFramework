using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using GameFrameworkLibrary;

namespace GameFrameworkDemo
{
    public class Goblin : Creature
    {
        public Goblin(string name, int health, Position position, AttackItem attackItem, DefenseItem defenseItem)
        {
            Id = IdCounter++;
            Name = name;
            MaxHealth = health;
            CurrentHealth = MaxHealth;
            Position = position;
            Symbol = "G";
            AttackItem = attackItem;
            DefenseItem = defenseItem;
            MyState.CurrentState = CreatureStates.State.Healthy;
        }
        public override void Hit(List<Creature> creatureList)
        {
            List<Creature> EnemyCreatures = creatureList.FindAll(c => c.Id != Id || c.Symbol != Symbol);
            Creature creature = EnemyCreatures.Find(c =>
                c.Position.Y <= Position.Y + AttackItem.Range && c.Position.Y >= Position.Y - AttackItem.Range && c.Position.X <= Position.X + AttackItem.Range && c.Position.X >= Position.X - AttackItem.Range);
            if (creature != null)
            {
                creature.ReceivedDamage = AttackItem.AttackValue;
                Console.WriteLine($"{creature.Name} was hit by {this.Name} for {this.AttackItem.AttackValue} damage");
                ActedThisRound = true;
            }
        }

        public override void Loot(List<WorldObject> worldObjectList)
        {
            if (ActedThisRound == false)
            {
                WorldObject worldObject = worldObjectList.Find(wo =>
                    wo.Position.Y <= Position.Y + 1 && wo.Position.Y >= Position.Y - 1 &&
                    wo.Position.X <= Position.X + 1 && wo.Position.X >= Position.X - 1);
                if (worldObject != null && worldObject.Lootable == true)
                {
                    if (worldObject.AttackItem != null && worldObject.AttackItem.AttackValue > AttackItem.AttackValue)
                    {
                        AttackItem = worldObject.AttackItem;
                        worldObject.AttackItem = null;
                        Console.WriteLine($"{Name} has looted a {AttackItem.Name}");
                    }

                    if (worldObject.DefenseItem != null && worldObject.DefenseItem.DefenseValue > DefenseItem.DefenseValue)
                    {
                        DefenseItem = worldObject.DefenseItem;
                        worldObject.DefenseItem = null;
                        Console.WriteLine($"{Name} has looted a {DefenseItem.Name}");
                    }
                    worldObject.Looted();
                    ActedThisRound = true;
                }
            }
        }

        public override void ReceiveDamage()
        {
            int damageTaken = ReceivedDamage - DefenseItem.DefenseValue;
            if (damageTaken <= 0)
            {
                damageTaken = 1;
            }
            CurrentHealth = CurrentHealth - damageTaken;
            ReceivedDamage = 0;
        }

        public override void Move()
        {
            if (ActedThisRound == false)
            {
                Random moveRandom = new Random(DateTime.Now.Millisecond);
                int moveInt = moveRandom.Next(1, 40);
                if (moveInt <= 10 && Position.Y != 0)
                {
                    Position.Y--;
                    Console.WriteLine($"{Name} has moved up");
                }
                else if (moveInt <= 20 && Position.X != MyWorld.MaxX)
                {
                    Position.X++;
                    Console.WriteLine($"{Name} has moved right");
                }
                else if (moveInt <= 30 && Position.Y != MyWorld.MaxY)
                {
                    Position.Y++;
                    Console.WriteLine($"{Name} has moved down");
                }
                else if (moveInt <= 40 && Position.X != 0)
                {
                    Position.X--;
                    Console.WriteLine($"{Name} has moved left");
                }
                else
                {
                    Move();
                }
            }

            ActedThisRound = false;
        }
    }
}