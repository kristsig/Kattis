using System;
using System.Linq;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

namespace Adding_Trouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                double a = double.Parse(split[0]);
                double b = double.Parse(split[1]);
                double c = double.Parse(split[2]);
                if ((a + b) == c)
                {
                    Console.WriteLine("correct!");
                }
                else { Console.WriteLine("wrong!"); }
            }
        }
    }
}