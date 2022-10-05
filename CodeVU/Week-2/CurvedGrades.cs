using System;

namespace Week_2
{
    internal class CurvedGrades
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the total points of the assignment: ");
            double totalPoints = Double.Parse(Console.ReadLine());

            double highestScore = 0;

            Console.WriteLine("Enter the scores for each of the 5 students");
            double student1 = Double.Parse(Console.ReadLine());
            if (student1 > highestScore) { highestScore = student1; }
            double s1uncurvedperc = student1 / totalPoints;

            double student2 = Double.Parse(Console.ReadLine());
            if (student2 > highestScore) { highestScore = student1; }
            double s2uncurvedperc = student2 / totalPoints;

            double student3 = Double.Parse(Console.ReadLine());
            if (student3 > highestScore) { highestScore = student1; }
            double s3uncurvedperc = student3 / totalPoints;

            double student4 = Double.Parse(Console.ReadLine());
            if (student4 > highestScore) { highestScore = student1; }
            double s4uncurvedperc = student4 / totalPoints;

            double student5 = Double.Parse(Console.ReadLine());
            if (student5 > highestScore) { highestScore = student1; }
            double s5uncurvedperc = student5 / totalPoints;

            double s1curved = student1 / highestScore;
            double s2curved = student2 / highestScore;
            double s3curved = student3 / highestScore;
            double s4curved = student4 / highestScore;
            double s5curved = student5 / highestScore;
            double curvedAvg = (s1curved + s2curved + s3curved + s4curved + s5curved) / 5;


            Console.WriteLine(String.Format("Uncurved Points      |{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|", "Student 1", "Student 2", "Student 3", "Student 4", "Student 5"));
            Console.WriteLine(String.Format("Uncurved Points      |{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|", student1, student2, student3, student4, student5));
            Console.WriteLine(String.Format("Uncurved Percentages |{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|", String.Format("{0:P0}", s1uncurvedperc), String.Format("{0:P0}", s2uncurvedperc), String.Format("{0:P0}", s3uncurvedperc), String.Format("{0:P0}", s4uncurvedperc), String.Format("{0:P0}", s5uncurvedperc)));
            Console.WriteLine(String.Format("Curved Percentages   |{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|", String.Format("{0:P0}", s1curved), String.Format("{0:P0}", s2curved), String.Format("{0:P0}", s3curved), String.Format("{0:P0}", s4curved), String.Format("{0:P0}", s5curved)));
            Console.WriteLine(String.Format("Curved Points        |{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|", (s1curved*100).ToString("0.##"), (s2curved * 100).ToString("0.##"), (s3curved * 100).ToString("0.##"), (s4curved * 100).ToString("0.##"), (s5curved * 100).ToString("0.##")));

        }
    }
}
