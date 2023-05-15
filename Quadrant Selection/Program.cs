using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Quadrant_Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0) { Console.WriteLine(1); }
            if (x < 0 && y > 0) { Console.WriteLine(2); }
            if (x < 0 && y < 0) { Console.WriteLine(3); }
            if (x > 0 && y < 0) { Console.WriteLine(4); }
        }
    }
}