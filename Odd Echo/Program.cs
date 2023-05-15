using System;
using System.Collections;
using System.Collections.Generic;

namespace Odd_Echo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> echo = new List<string>();
            double N = double.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine();
                if (i % 2 == 0)
                {
                    echo.Add(line);
                }
            }
            for(int i = 0; i < echo.Count; i++)
            {
                Console.WriteLine(echo[i]);
            }
        }
    }
}