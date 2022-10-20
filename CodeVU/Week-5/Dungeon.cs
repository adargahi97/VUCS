using System;

namespace Week_5
{
    public class Dungeon
    {
        //title, menu, rooms, room descriptions
        public static void Main(string[] args)
        {
            Console.Title = "DUNGEON OF DOOM";
            Console.WriteLine("Your journey begins...\n");

            Console.WriteLine("WHO GOES THERE? STATE YOUR NAME");
            string name = Console.ReadLine();

            Character user = new Character(name, 1, 1, 1, null);

            /*
                * TODO:
                x Create a do-while loop for the menu choices (The user can choose to attack, run away, player info, monster info, or exit)
                Create a loop for the room with an exit bool
                x Catch the user's input
                Write a function to get the room description
                Create an instance of character for your player
                Create instances of character for your monsters
                Create an array to store your monsters
                Randomly select room and the monster in it
                Handle doing battle between your player and the monster in the room
                Check the player's and monster's life
                Handle if the player or monster wins
                */

            bool exit = false;

            do
            {
                Console.WriteLine("\nPleasechose an action:\n A.) Attack\n R.) Run Away\n P.) Player Info\n M.) Monster Info\n X.) Exit\n");

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

    }
}