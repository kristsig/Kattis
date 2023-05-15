using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace A_Different_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                int sum = 0;
                List<double> numbers = line.Split(' ').Select(double.Parse).ToList();
                numbers.Sort();
                Console.WriteLine(numbers[1] - numbers[0]);
            }
        }
    }
}