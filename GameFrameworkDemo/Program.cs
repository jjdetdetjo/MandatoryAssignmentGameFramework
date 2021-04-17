using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using GameFrameworkDemo.DefenseItems;
using GameFrameworkLibrary;

namespace GameFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jeg kan simpelthen ikke lige gennemskue hvordan jeg initialiserer mine klasser fra xml filen
            //Men jeg kan se at filen er oprettet og jeg kan hente specifikke elementer fra den

            //XElement worldxml =
            //    XElement.Load(
            //        @"C:\Users\Jonas\source\repos\MandatoryAssignmentGameFramework\GameFrameworkDemo\bin\Debug\netcoreapp3.1\config.xml");

            //var thisWorld = worldxml.Element("World");
            //Console.WriteLine(thisWorld);

            //XElement goblinxml =
            //    XElement.Load(
            //        @"C:\Users\Jonas\source\repos\MandatoryAssignmentGameFramework\GameFrameworkDemo\bin\Debug\netcoreapp3.1\config.xml");

            //var thisGoblins = goblinxml.Elements("Goblin");

            //foreach (var goblin in thisGoblins)
            //{
            //    Console.WriteLine(goblin);
            //}



            //xml config filen bliver lavet her

            //var configXML = new XDocument();
            //var rootElement = new XElement("MyWorld");
            //configXML.Add(rootElement);

            //List<MyWorld> world = new List<MyWorld>();
            //world.Add(new MyWorld(20, 20));

            //foreach (MyWorld thisworld in world)
            //{
            //    var worldElem = new XElement("World");
            //    var maxXElem = new XElement("MaxX", thisworld.XSize);
            //    var maxYElem = new XElement("MaxY", thisworld.YSize);
            //    worldElem.Add(maxXElem);
            //    worldElem.Add(maxYElem);
            //    rootElement.Add(worldElem);
            //}

            //List<Goblin> goblins = new List<Goblin>();
            //goblins.Add(new Goblin("Gobbo", 20, new Position(4, 5), new Bow(), new Fists()));
            //goblins.Add(new Goblin("Gobla", 20, new Position(7, 5), new Bow(), new Fists()));
            //goblins.Add(new Goblin("Gubbur", 20, new Position(11, 5), new Bow(), new Fists()));

            //foreach (Goblin goblin in goblins)
            //{
            //    var goblinElem = new XElement("Goblin");
            //    var nameElem = new XElement("Name", goblin.Name);
            //    var healthElem = new XElement("Health", goblin.MaxHealth);
            //    var xPositionElem = new XElement("XPosition", goblin.Position.X);
            //    var yPositionElem = new XElement("YPosition", goblin.Position.Y);
            //    var attackElem = new XElement("Attack", goblin.AttackItem);
            //    var defenseElem = new XElement("Defense", goblin.DefenseItem);
            //    goblinElem.Add(nameElem);
            //    goblinElem.Add(healthElem);
            //    goblinElem.Add(xPositionElem);
            //    goblinElem.Add(yPositionElem);
            //    goblinElem.Add(attackElem);
            //    goblinElem.Add(defenseElem);
            //    rootElement.Add(goblinElem);
            //}

            //List<Human> humans = new List<Human>();
            //humans.Add(new Human("Frank", 50, new Position(4, 15), new Sword(), new Shield()));
            //humans.Add(new Human("Bob", 50, new Position(10, 15), new Sword(), new Shield()));
            //humans.Add(new Human("Chad", 50, new Position(15, 15), new Sword(), new Shield()));

            //foreach (Human human in humans)
            //{
            //    var humanElem = new XElement("Human");
            //    var nameElem = new XElement("Name", human.Name);
            //    var healthElem = new XElement("Health", human.MaxHealth);
            //    var xPositionElem = new XElement("XPosition", human.Position.X);
            //    var yPositionElem = new XElement("YPosition", human.Position.Y);
            //    var attackElem = new XElement("Attack", human.AttackItem);
            //    var defenseElem = new XElement("Defense", human.DefenseItem);
            //    humanElem.Add(nameElem);
            //    humanElem.Add(healthElem);
            //    humanElem.Add(xPositionElem);
            //    humanElem.Add(yPositionElem);
            //    humanElem.Add(attackElem);
            //    humanElem.Add(defenseElem);
            //    rootElement.Add(humanElem);
            //}

            //List<Chest> chests = new List<Chest>();
            //chests.Add(new Chest(true, "Big Chest", true, new Position(15, 16), new Sword(), new Fists()));
            //chests.Add(new Chest(true, "Big Chest", true, new Position(11, 6), new Sword(), new Shield()));

            //foreach (Chest chest in chests)
            //{
            //    var chestElem = new XElement("Chest");
            //    var lootableElem = new XElement("Lootable", chest.Lootable);
            //    var nameElem = new XElement("Name", chest.Name);
            //    var removeableElem = new XElement("Removeable", chest.Removable);
            //    var xPositionElem = new XElement("XPosition", chest.Position.X);
            //    var yPositionElem = new XElement("YPosition", chest.Position.Y);
            //    var attackElem = new XElement("Attack", chest.AttackItem);
            //    var defenseElem = new XElement("Defense", chest.DefenseItem);
            //    chestElem.Add(lootableElem);
            //    chestElem.Add(nameElem);
            //    chestElem.Add(removeableElem);
            //    chestElem.Add(xPositionElem);
            //    chestElem.Add(yPositionElem);
            //    chestElem.Add(attackElem);
            //    chestElem.Add(defenseElem);
            //    rootElement.Add(chestElem);
            //}

            //List<Rock> rocks = new List<Rock>();
            //rocks.Add(new Rock(false, "Big Rock", false, new Position(1, 1)));
            //rocks.Add(new Rock(false, "Big Rock", false, new Position(2, 1)));
            //rocks.Add(new Rock(false, "Big Rock", false, new Position(3, 1)));
            //rocks.Add(new Rock(false, "Big Rock", false, new Position(1, 2)));
            //rocks.Add(new Rock(false, "Big Rock", false, new Position(1, 3)));

            //foreach (Rock rock in rocks)
            //{
            //    var rockElem = new XElement("Rock");
            //    var lootableElem = new XElement("Lootable", rock.Lootable);
            //    var nameElem = new XElement("Name", rock.Name);
            //    var removeableElem = new XElement("Removeable", rock.Removable);
            //    var xPositionElem = new XElement("XPosition", rock.Position.X);
            //    var yPositionElem = new XElement("YPosition", rock.Position.Y);
            //    var attackElem = new XElement("Attack", rock.AttackItem);
            //    var defenseElem = new XElement("Defense", rock.DefenseItem);
            //    rockElem.Add(lootableElem);
            //    rockElem.Add(nameElem);
            //    rockElem.Add(removeableElem);
            //    rockElem.Add(xPositionElem);
            //    rockElem.Add(yPositionElem);
            //    rockElem.Add(attackElem);
            //    rockElem.Add(defenseElem);
            //    rootElement.Add(rockElem);
            //}

            //configXML.Save("config.xml");

            //Console.WriteLine(configXML);
            //Console.ReadKey();


            //initialisering af klasser direkte i koden

            MyWorld myWorld = new MyWorld(20, 20);
            Goblin gobbo = new Goblin("Gobbo", 20, new Position(10, 4), new Bow(), new Fists());
            myWorld.CreatureList.Add(gobbo);
            Goblin gubba = new Goblin("Gubba", 20, new Position(10, 7), new Bow(), new Fists());
            myWorld.CreatureList.Add(gubba);
            Human frank = new Human("Frank", 50, new Position(1, 1), new Sword(), new Shield());
            myWorld.CreatureList.Add(frank);
            Rock rock = new Rock(false, "Rock", false, new Position(3, 7));
            myWorld.WorldObjectList.Add(rock);
            Chest goldenChest = new Chest(true, "Golden Chest", true, new Position(7, 7), null, new Shield());
            myWorld.WorldObjectList.Add(goldenChest);
            myWorld.RunWorld();

        }
    }
}
