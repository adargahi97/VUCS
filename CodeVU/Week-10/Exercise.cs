using System;
using System.Collections.Generic;
using System.Text;

namespace Week_10
{
    internal class Exercise
    {
        public static void Main(string[] args)
        {
            IDictionary<string, List<decimal>> morty = new Dictionary<string, List<decimal>>();
            IDictionary<string, List<decimal>> charlie = new Dictionary<string, List<decimal>>();
            IDictionary<string, List<decimal>> opie = new Dictionary<string, List<decimal>>();

            morty["homework"] = new List<decimal> { };
            morty["quizzes"] = new List<decimal> { };
            morty["tests"] = new List<decimal> { };

            charlie["homework"] = new List<decimal> { };
            charlie["quizzes"] = new List<decimal> { };
            charlie["tests"] = new List<decimal> { };

            opie["homework"] = new List<decimal> { };
            opie["quizzes"] = new List<decimal> { };
            opie["tests"] = new List<decimal> { };

            List<Dictionary> students = new List<Dictionary>{ morty, charlie, opie };

            Random rnd = new Random();
            foreach (Dictionary student in students) { foreach (IDictionary<string, List<decimal>> mark in student)}


        }
    }
} 
