using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Week_5
{
    public class Dungeon
    {
        //title, menu, rooms, room descriptions
        static void Main()
        {
            Console.Title = "Crystal Castle";
            Console.WriteLine("-> Your journey begins... You are filled with determination <-");

            Console.WriteLine("\n-> What do they call you??? <-");
            string name = Console.ReadLine();
            Console.WriteLine("\n{0}..\n{1}..? Right... Okay.", name.Substring(0, 3), name);

            //Create weapon and character
            Weapon playerWeapon = weaponChoice();
            Character player = new Character(name, 75, 3, 75, 10, playerWeapon);

            Console.WriteLine("\nBrave of you to enter the Crystal Castle, may luck be on your side.\nYou will encounter many enemies ahead, proceed with caution");


            //crawl through 10 rooms
            for (int i = 0; i < 10; i++)
            {
                Room currRoom = createRoom(player);
                Character monster = createMonster(currRoom);
                ConsoleKey userChoice = Console.ReadKey(false).Key;

                bool dead = false;
                do
                {
                    do
                    {
                        Console.WriteLine("\nPlease choose an action:\nA.) Attack\nR.) Run Away\nC.) Charm\nP.) Player Info\nM.) Monster Info\nD.) Room Description\n");

                        userChoice = Console.ReadKey(true).Key;

                        switch (userChoice)
                        {
                            case ConsoleKey.A:
                                dead = true;
                                break;
                            case ConsoleKey.R:
                                break;
                            case ConsoleKey.C:
                                break;
                            case ConsoleKey.P:
                                break;
                            case ConsoleKey.M:
                                monster.MonsterDesc();
                                break;
                            case ConsoleKey.D:
                                RoomDesc(currRoom);
                                break;
                            default:
                                Console.WriteLine("Did you even read the options or do you just have bratwursts for fingers?");
                                break;
                        }

                        /*if (userChoice == ConsoleKey.C)
                        {

                        }
                        if (userChoice == ConsoleKey.P)
                        {

                        }*/

                    } while (userChoice != ConsoleKey.A || userChoice != ConsoleKey.R || userChoice != ConsoleKey.C);


                    /*if (player.Health < 1 || monster.Health < 0)
                    {
                        dead = true;
                    }*/

                } while (!dead);
            }
        }


        public static Character createMonster(Room currRoom)
        {
            Random rnd = new Random();
            var monsNames = new List<string>() { "Phoenix", "Flametooth", "The Colossal Brute", "The Blind Glob", "Mike", "Moldsnake", "Corpsemouth", "Minotaur", "Phantommonster", "Jon" };
            int nameSelect = rnd.Next(monsNames.Count);

            var weaponsList = new List<string>() {"Claws", "Sledgehammer", "Katana", "Hurtful words", "Glock-19", "Crossbow", "Thermite", "Baseball bat", "Rubber band gun"};
            int weaponSelect = rnd.Next(weaponsList.Count);

            if (currRoom.RoomLevel < 15)
            {
                Weapon newWeapon = new Weapon(weaponsList[weaponSelect], 1, 6, 20, false, 10);
                Character newMonster = new Character(monsNames[nameSelect], 45, 5, 45, 5, newWeapon);
                monsNames.RemoveAt(nameSelect);
                weaponsList.RemoveAt(weaponSelect);

                return newMonster;
            }
            else if (currRoom.RoomLevel < 31)
            {
                Weapon newWeapon = new Weapon(weaponsList[weaponSelect], 7, 20, 17, false, 10);
                Character newMonster = new Character(monsNames[nameSelect], 45, 4, 45, 5, newWeapon);
                monsNames.RemoveAt(nameSelect);
                weaponsList.RemoveAt(weaponSelect);

                return newMonster;
            }
           else
            {
                Weapon newWeapon = new Weapon(weaponsList[weaponSelect], 15, 35, 15, false, 10);
                Character newMonster = new Character(monsNames[nameSelect], 45, 3, 45, 5, newWeapon);
                monsNames.RemoveAt(nameSelect);
                weaponsList.RemoveAt(weaponSelect);

                return newMonster;
            }

        }

        public static Room createRoom(Character player)
        {
            Random rnd = new Random();
            var roomNames = new List<string>() { "Amphitheater", "Privy", "Trophy Hall", "Crematorium", "Atrium", "Theater", "Armory", "Chapel", "Shrine", "Observatory" };
            var roomSizes = new List<string>() { "very small", "small", "average sized", "large", "very large" };
 
            int nameSelect = rnd.Next(roomNames.Count);
            int sizeSelect = rnd.Next(roomSizes.Count);


            if (player.MaxHealth < 100)
            {
                Room currRoom = new Room(roomNames[nameSelect], roomSizes[sizeSelect], rnd.Next(1,14));
                roomNames.RemoveAt(nameSelect);
                return currRoom;
                
            }
            else if (player.MaxHealth < 150)
            {
                Room currRoom = new Room(roomNames[nameSelect], roomSizes[sizeSelect], rnd.Next(15, 30));
                roomNames.RemoveAt(nameSelect);
                return currRoom;
            }
            else
            {
                Room currRoom = new Room(roomNames[nameSelect], roomSizes[sizeSelect], rnd.Next(31, 50));
                roomNames.RemoveAt(nameSelect);
                return currRoom;
            }  
        }

        public static void RoomDesc(Room currRoom)
        {
            Console.WriteLine("\nYou are currently in The {0}\nThis room is categorized as {1} \nIt has a room level of {2}", currRoom.RoomName, currRoom.RoomSize, currRoom.RoomLevel);
        }

        public static Weapon weaponChoice()
        {
            bool pickWeapon = false;
            do
            {
                Console.WriteLine("\nChoose a weapon that resonates with you:\n B.) Bow & Arrow\n S.) Sword\n A.) Axe\n P.) I don't mean any harm, really... i dont know how i got here.\n");

                ConsoleKey userChoice = Console.ReadKey(true).Key;

                switch (userChoice)
                {
                    case ConsoleKey.B:
                        pickWeapon = true;
                        Console.WriteLine("A bow, really original choice there robinhood. I guess you should give it a name or something.");
                        string bow_name = Console.ReadLine();
                        Console.WriteLine("\n{0}? weird choice but alright. Your bow is now named {0}!", bow_name);
                        Weapon bow_arrow = new Weapon(bow_name, 1, 10, 15, true, 0);
                        return (bow_arrow);
                    case ConsoleKey.S:
                        pickWeapon = true;
                        Console.WriteLine("The sword... Weeb. I guess you should give it a name or something.");
                        string sword_name = Console.ReadLine();
                        Console.WriteLine("\n{0}? Wow, my little sister could have come up with something better. Your sword is now named {0}!", sword_name);
                        Weapon sword = new Weapon(sword_name, 2, 8, 20, false, 0);
                        return (sword);
                    case ConsoleKey.A:
                        pickWeapon = true;
                        Console.WriteLine("An AXE - now that is a good pick, good luck with that. I guess you should give it a name or something.");
                        string axe_name = Console.ReadLine();
                        Console.WriteLine("\n{0}? Interesting choice... Your axe is now named {0}!", axe_name);
                        Weapon axe = new Weapon(axe_name, 3, 8, 25, false, 0);
                        return (axe);
                    case ConsoleKey.P:
                        pickWeapon = true;
                        Console.WriteLine("\nNot into much violence, huh? Me either. \nNo turning back now though, nerd.");
                        Weapon charisma = new Weapon("charisma", 1, 1, 0, false, 10);
                        return (charisma);
                    default:
                        Console.WriteLine("\nDid you even try to read what i said?");
                        return (null);
                }

            } while (!pickWeapon);
        }

    }
}