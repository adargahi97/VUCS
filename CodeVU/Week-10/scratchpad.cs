using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Week_10
{
    internal class scratchpad
    {
        static void scratch(string[] args)
        {
            List<int> numbers = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            numbers.Sort();
            Dictionary<int, int> numCount = new Dictionary<int, int>();
            string output = "";

            foreach (int number in numbers)
            {
                if (numCount.ContainsKey(number))
                {
                    numCount[number]++;
                }
                else
                {
                    numCount.Add(number, 1);
                }
            }
            foreach (var kvp in numCount) { Console.Write("| {0} -> {1} times ", kvp.Key, kvp.Value, "\t"); }
        }
    }
}
