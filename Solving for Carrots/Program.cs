using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Solving_for_Carrots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            if (split.Length >= 2) {
                double N = double.Parse(split[0]);
                double P = double.Parse(split[1]);
                for (int i = 0; i < N; i++) {
                    Console.ReadLine();
                }
                Console.WriteLine(P);
            }
        }
    }
}