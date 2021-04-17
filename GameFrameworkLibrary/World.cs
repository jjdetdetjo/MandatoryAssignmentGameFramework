using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Channels;
using System.Xml.Schema;

namespace GameFrameworkLibrary
{
    public abstract class World
    {
        public static int MaxX { get; set; }
        public static int MaxY { get; set; }
        public int XSize { get; set; }
        public int YSize { get; set; }
        public List<Creature> CreatureList = new List<Creature>();
        public static List<Creature> NearbyCreatures = new List<Creature>();
        public List<WorldObject> WorldObjectList = new List<WorldObject>();
        public static List<WorldObject> NearbyObjects = new List<WorldObject>();

        public void RunWorld()
        {
            BuildWorld();
            WorldLoop();
        }

        public void BuildWorld()
        {
            Array[] yAxis = new Array[MaxY];
            for (int y = 0; y < MaxY; y++)
            {
                string[] xAxis = new string[MaxX];
                yAxis[y] = xAxis;
                for (int x = 0; x < MaxX; x++)
                {
                    if (CreatureList.Exists(c => c.Position.Y == y && c.Position.X == x))
                    {
                        Creature creature = CreatureList.Find(c => c.Position.Y == y && c.Position.X == x);
                        xAxis[x] = $"[{creature.Symbol}]";
                    }
                    else if (WorldObjectList.Exists(wo => wo.Position.Y == y && wo.Position.X == x))
                    {
                        WorldObject worldObject = WorldObjectList.Find(wo => wo.Position.Y == y && wo.Position.X == x);
                        xAxis[x] = $"[{worldObject.Symbol}]";
                    }
                    else
                    {
                        xAxis[x] = "[ ]";
                    }
                }
                foreach (var row in xAxis)
                {
                    Console.Write(row);
                }

                Console.WriteLine();
            }
        }

        public void WorldLoop()
        {
            while (true)
            {
                var deadCreatures = CreatureList.FindAll(c => c.MyState.CurrentState == CreatureStates.State.Dead);
                foreach (var creature in deadCreatures)
                {
                    CreatureList.Remove(creature);
                }

                var removedWorldObjects = WorldObjectList.FindAll(wo => wo.Removed);
                foreach (var worldObject in removedWorldObjects)
                {
                    WorldObjectList.Remove(worldObject);
                }

                NearbyCreatures = CreatureList;
                NearbyObjects = WorldObjectList;

                foreach (var creature in CreatureList)
                {
                    Console.Clear();
                    creature.Act();
                    BuildWorld();
                    Thread.Sleep(1500);
                }
            }
        }
    }
}