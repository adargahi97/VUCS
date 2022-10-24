using System;

namespace Week_5
{
    public class Dungeon
    {
        //title, menu, rooms, room descriptions
        public static void Main(string[] args)
        {
            Console.Title = "Crystal Castle";
            Console.WriteLine("-> Your journey begins... You are filled with determination <-\n");

            Console.WriteLine("\n-> What do they call you??? <-");
            string name = Console.ReadLine();

            Character player = new Character(name, 1, 1, 1, null);

            Console.WriteLine("\n...\n{0}..\n{1}..? Right... Okay.", name.Substring(0,3), name);

            /*
                * TODO:
                Write a function to get the room description
                Create an instance of character for your player
                Create instances of character for your monsters
                Create an array to store your monsters
                Randomly select room and the monster in it
                Handle doing battle between your player and the monster in the room
                Check the player's and monster's life
                Handle if the player or monster wins
                */
            bool pickWeapon = false;
            do
            {
                Console.WriteLine("\nChoose a weapon that resonates with you:\n B.) Bow & Arrow\n S.) Sword\n A.) Axe\n P.) I don't mean any harm, really... i dont know how i got here.\n X.) Exit\n");

                ConsoleKey userChoice = Console.ReadKey(true).Key;

                switch (userChoice)
                {
                    case ConsoleKey.B:
                        pickWeapon = true;
                        Console.WriteLine("A bow, really original choice there robinhood. I guess you should give it a name or something.");
                        string bow_name = Console.ReadLine();
                        Weapon bow_arrow = new Weapon(bow_name,1,5,30,true);
                        break;
                    case ConsoleKey.S:
                        pickWeapon = true;
                        Console.WriteLine("The sword! . I guess you should give it a name or something.");
                        string sword_name = Console.ReadLine();
                        break;
                    case ConsoleKey.A:
                        pickWeapon = true;
                        break;
                    case ConsoleKey.P:
                        pickWeapon = true;
                        break;
                    case ConsoleKey.X:
                        break;
                    default:
                        Console.WriteLine("Did you even try to read what i said?");
                        break;
                }

            } while (!pickWeapon);



            bool exit = false;
            do
            {
                Console.WriteLine("\nPlease choose an action:\n A.) Attack\n R.) Run Away\n P.) Player Info\n M.) Monster Info\n X.) Exit\n");

                ConsoleKey userChoice = Console.ReadKey(true).Key;

                switch (userChoice)
                {
                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.R:
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

            } while (!exit);
        }
        public string roomDescription()
        {
            string roomDescription = Console.ReadLine();
            return roomDescription;
        }

    }
}