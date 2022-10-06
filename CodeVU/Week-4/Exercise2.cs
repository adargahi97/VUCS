using System;
using System.Threading.Channels;
using Microsoft.VisualBasic.CompilerServices;

namespace CodeVU
{
    class Exercise2
    {
        static void exceptionhandling(string[] args)
        {

            Console.WriteLine("Select an operation.\n1) AddValues\n2) SubtractValues\n3) MultiplyValues\n4) DivideValues\n5) RemainderValues\n");
            string userChoice = Console.ReadLine();
            int valueOne = 0;
            int valueTwo = 0;

            try
            {
                Console.WriteLine("Enter a number.");
                valueOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number.");
                valueTwo = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("That is not a number.");
            }
            catch (ArgumentNullException f)
            {
                Console.WriteLine("Please enter a number");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Number is out of range.");
            }

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine($"Result={AddValues(valueOne, valueTwo)}");
                    break;
                case "2":
                    Console.WriteLine($"Result={SubtractValues(valueOne, valueTwo)}");
                    break;
                case "3":
                    Console.WriteLine($"Result={MultiplyValues(valueOne, valueTwo)}");
                    break;
                case "4":
                    Console.WriteLine($"Result={DivideValues(valueOne, valueTwo)}");
                    break;
                case "5":
                    Console.WriteLine($"Result={RemainderValues(valueOne, valueTwo)}");
                    break;
                default:
                    break;
            }
        }

        static int AddValues(int valueOne, int valueTwo)
        {
            return valueOne + valueTwo;
        }

        static int SubtractValues(int valueOne, int valueTwo)
        {
            return valueOne - valueTwo;
        }

        static int MultiplyValues(int valueOne, int valueTwo)
        {
            return valueOne * valueTwo;
        }

        static int DivideValues(int valueOne, int valueTwo)
        {
            return valueOne / valueTwo;
        }

        static int RemainderValues(int valueOne, int valueTwo)
        {
            return valueOne % valueTwo;
        }
    }
}