using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace R2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                if (split.Length >= 2)
                {
                    double S = double.Parse(split[1]);
                    double R1 = double.Parse(split[0]);

                    double R2 = (S * 2) - R1;
                    Console.WriteLine(R2);
                }
            }
        }
    }
}