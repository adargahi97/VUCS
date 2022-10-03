using System;

namespace module1
{
    internal class module1
    {
        static void lab1(string[] args)
        {
            int num = 0;
            string word = "hello";
            bool vucs = true;
            char initial = 'a';
            double money = 20.21;
            int? bleh = null;
            byte time = 29;
            object hi = null;
            long numba = 12910291031;
            short numb = 293;

        }
        static void lab2(string[] args)
        {
            Console.WriteLine("What is your favorite season? ");
            string favSeason = Console.ReadLine();
            Console.WriteLine("What is your favorite car? ");
            string favCar = Console.ReadLine();
            Console.WriteLine("What is your favorite TV Show? ");
            string favTvShow = Console.ReadLine();
            Console.WriteLine("How much did you spend on streaming services last year? ");
            string amtSpent = Console.ReadLine();

            var price = double.Parse(amtSpent);

        }
        static void lab3(string[] args)
        {
            Console.WriteLine("Enter a place: ");
            string place = Console.ReadLine();
            Console.WriteLine("Enter a verb: ");
            string verb = Console.ReadLine();
            Console.WriteLine("Enter a adjective: ");
            string adj = Console.ReadLine();
            Console.WriteLine("Enter a noun: ");
            string noun = Console.ReadLine();

            Console.WriteLine("Jonathan was {0} to {1} when he saw a {3} and thought, man... that thing is {4}", verb, place, noun, adj);

        }
        static void lab4(string[] args)
        {
            byte puddle = 100;
            short pond = 29456;
            int lake = 100000;
            long ocean = 5;





        }
    }
}
