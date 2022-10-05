using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Week_2
{
    internal class AreaOfShapes
    {
        static void ShapeArea(string[] args)
        { 
            Console.WriteLine("Please enter the shape(Triangle, Quadrilateral, or Cricle):");
            string shape =  Console.ReadLine();

            if (shape == "Triangle" || shape == "triangle"){
                Console.WriteLine("Please enter the length of the smallest side of the triangle");
                string smallest = Console.ReadLine();
                Console.WriteLine("Please enter the length of the second smallest side of the triangle");
                string second = Console.ReadLine();
                Console.WriteLine("Please enter the length of the longest side of the triangle");
                string longest = Console.ReadLine();

                var small = double.Parse(smallest);
                var med = double.Parse(second);
                var large = double.Parse(longest);

                if (Math.Pow(small, 2) + Math.Pow(med, 2) > Math.Pow(large, 2))
                {
                    Console.WriteLine("Acute Triangle");
                }
                else if (Math.Pow(small, 2) + Math.Pow(med, 2) == Math.Pow(large, 2))
                {
                    Console.WriteLine("Right Triangle");
                }
                else if (Math.Pow(small, 2) + Math.Pow(med, 2) < Math.Pow(large, 2))
                {
                    Console.WriteLine("Obtuse Triangle");
                }

                double s = small + med + large / 2;
                double area = Math.Sqrt(s*(s - small)*(s - med)*(s - large));
                Console.WriteLine("Area: {0}", area);
            }


            else if(shape == "Quadrilateral" || shape == "quadrilateral")
            {
                Console.WriteLine("Please enter each lentgth of the four sides");
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double side3 = double.Parse(Console.ReadLine());
                double side4 = double.Parse(Console.ReadLine());
                double area = 0;

                //square
                if (side1 == side2 && side1 == side3  && side1 == side4)
                {
                    Console.WriteLine("Square");
                    area = Math.Pow(side1, 2);
                    Console.WriteLine("Area: {0}", area);
                }
                //rectangle
                else if (side1 == side2 && side3 == side4)
                {
                    Console.WriteLine("Rectangle");
                    area = side1 * side3;
                    Console.WriteLine("Area: {0}", area);
                }
                else if (side1 == side4 && side3 == side2)
                {
                    Console.WriteLine("Rectangle");
                    area = side1 * side3;
                    Console.WriteLine("Area: {0}", area);
                }
                else if (side1 == side3 && side4 == side2)
                {
                    Console.WriteLine("Rectangle");
                    area = side1 * side4;
                    Console.WriteLine("Area: {0}", area);
                }
                //trapezoid
                else if (side1 == side2)
                {
                    Console.WriteLine("Trapezoid");
                    Console.WriteLine("Please enter the height: ");
                    double height = double.Parse(Console.ReadLine());
                    area = 1 / 2 * (side3 + side4) * height;
                    Console.WriteLine("Area: {0}", area);
                }
                else if (side1 == side3)
                {
                    Console.WriteLine("Trapezoid");
                    Console.WriteLine("Please enter the height: ");
                    double height = double.Parse(Console.ReadLine());
                    area = 1/2 * (side2 + side4) * height;
                    Console.WriteLine("Area: {0}", area);
                }
                else if (side1 == side4)
                {
                    Console.WriteLine("Trapezoid");
                    Console.WriteLine("Please enter the height: ");
                    double height = double.Parse(Console.ReadLine());
                    area = 1 / 2 * (side3 + side2) * height;
                    Console.WriteLine("Area: {0}", area);
                }
                else if (side2 == side3)
                {
                    Console.WriteLine("Trapezoid");
                    Console.WriteLine("Please enter the height: ");
                    double height = double.Parse(Console.ReadLine());
                    area = 1 / 2 * (side1 + side4) * height;
                    Console.WriteLine("Area: {0}", area);
                }
                else if (side2 == side4)
                {
                    Console.WriteLine("Trapezoid");
                    Console.WriteLine("Please enter the height: ");
                    double height = double.Parse(Console.ReadLine());
                    area = 1 / 2 * (side3 + side1) * height;
                    Console.WriteLine("Area: {0}", area);
                }
                else if (side3 == side4)
                {
                    Console.WriteLine("Trapezoid");
                    Console.WriteLine("Please enter the height: ");
                    double height = double.Parse(Console.ReadLine());
                    area = 1 / 2 * (side1 + side2) * height;
                    Console.WriteLine("Area: {0}", area);
                }

            }


            else if(shape == "Circle" || shape == "circle")
            {
                Console.WriteLine("Please enter the radius of the circle");
                string radius = Console.ReadLine();
                var r = double.Parse(radius);
                double area = 3.14 * Math.Pow(r, 2);

                if (area > 100)
                {
                    Console.WriteLine("Big Circle");
                }
                else
                {
                    Console.WriteLine("Small Circle");
                }
                Console.WriteLine("Area: {0}", area);
            }

        }
    }
}
