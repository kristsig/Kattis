using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Take_Two_Stones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            long stones = 0;
            while ((line = Console.ReadLine()) != null)
            {
                try
                {
                    stones = long.Parse(line);
                    if (stones % 2 == 0)
                    {
                        Console.WriteLine("Bob");
                    }
                    else { Console.WriteLine("Alice"); }
                }
                catch { }
            }
        }
    }
}