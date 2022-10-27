using System;
using System.Collections;
using System.Collections.Generic;

namespace Week_5
{
    public class Dungeon
    {
        //title, menu, rooms, room descriptions
        public void Main(string[] args)
        {
            Console.Title = "Crystal Castle";
            Console.WriteLine("-> Your journey begins... You are filled with determination <-\n");

            Console.WriteLine("\n-> What do they call you??? <-");
            string name = Console.ReadLine();
            Console.WriteLine("\n{0}..\n{1}..? Right... Okay.", name.Substring(0, 3), name);

            //Create weapon and character
            Weapon playerWeapon = weaponChoice();
            Character player = new Character(name, 75, 1, 1, 1, playerWeapon);

            Console.WriteLine("Brave of you to enter the Crystal Castle, may luck be on your side.\nYou will encounter many enemies ahead, proceed with caution");


            bool dead = false;
            do
            {
                Action();

            } while (!dead);

        }
                                    /*
                                * TODO:
                                Create instances of character for your monsters
                                Create an array to store your monsters
                                Randomly select room and the monster in it
                                Handle doing battle between your player and the monster in the room
                                Check the player's and monster's life
                                Handle if the player or monster wins
                                */


        public void Action()
        {
            Console.WriteLine("\nPlease choose an action:\n A.) Attack\n R.) Run Away\n C.) Charm\nP.) Player Info\n M.) Monster Info\n X.) Exit\n");

            ConsoleKey userChoice = Console.ReadKey(true).Key;

            switch (userChoice)
            {
                case ConsoleKey.A:
                    break;
                case ConsoleKey.R:
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.P:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.X:
                    break;
                default:
                    Console.WriteLine("Thou hast chosen an improper option, indeed. Will thoust try again?");
                    break;
            }
        }

        public Room createRoom(Character player)
        {
            Random rnd = new Random();
            var roomNames = new List<string>() { "Amphitheater", "Privy", "Trophy Hall", "Crematorium", "Atrium", "Theater", "Armory", "Chapel", "Shrine", "Observatory" };
            var roomSizes = new List<string>() { "very small", "small", "average sized", "large", "very large" };
 
            int nameSelect = rnd.Next(roomNames.Count);
            int sizeSelect = rnd.Next(roomSizes.Count);


            if (player.MaxHealth < 100)
            {
                Room currRoom = new Room(roomNames[nameSelect], roomSizes[sizeSelect], 10);
                roomNames.RemoveAt(nameSelect);
                return currRoom;
                
            }
            else if (player.MaxHealth < 150)
            {
                Room currRoom = new Room(roomNames[nameSelect], roomSizes[sizeSelect], 20);
                roomNames.RemoveAt(nameSelect);
                return currRoom;
            }
            else
            {
                Room currRoom = new Room(roomNames[nameSelect], roomSizes[sizeSelect], 30);
                roomNames.RemoveAt(nameSelect);
                return currRoom;
            }


            

        }

        public void RoomDesc(Room currRoom)
        {
            Console.WriteLine("\nYou are currently in The {0}\nThis room is categorized as {1} \n It has a room level of {2}", currRoom.RoomName, currRoom.RoomSize, currRoom.RoomLevel);
        }

        public Weapon weaponChoice()
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
                        Console.WriteLine("{0}? weird choice but alright. Your bow is now named {0}!", bow_name);
                        Weapon bow_arrow = new Weapon(bow_name, 1, 10, 15, true, 0);
                        return (bow_arrow);
                    case ConsoleKey.S:
                        pickWeapon = true;
                        Console.WriteLine("The sword... Weeb. I guess you should give it a name or something.");
                        string sword_name = Console.ReadLine();
                        Console.WriteLine("{0}? Wow, my little sister could have come up with something better. Your sword is now named {0}!", sword_name);
                        Weapon sword = new Weapon(sword_name, 2, 8, 20, false, 0);
                        return (sword);
                    case ConsoleKey.A:
                        pickWeapon = true;
                        Console.WriteLine("An AXE - now that is a good pick, good luck with that. I guess you should give it a name or something.");
                        string axe_name = Console.ReadLine();
                        Console.WriteLine("{0}? Interesting choice... Your axe is now named {0}!", axe_name);
                        Weapon axe = new Weapon(axe_name, 3, 8, 25, false, 0);
                        return (axe);
                    case ConsoleKey.P:
                        pickWeapon = true;
                        Console.WriteLine("Not into much violence, huh? Me either. \nNo turning back now though, nerd.");
                        Weapon charisma = new Weapon("charisma", 1, 1, 0, false, 10);
                        return (charisma);
                    default:
                        Console.WriteLine("Did you even try to read what i said?");
                        return (null);
                }

            } while (!pickWeapon);
        }

    }
}