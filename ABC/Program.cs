using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace ABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            numbers.Sort();
            string order = Console.ReadLine();
            int counter = 0;

            string ans = "";
            for (int i = 0; i < order.Length; i++)
            {
                if (i > 0)
                {
                    ans += " ";
                }
                if (order[i] == 'A')
                {
                    ans += numbers[0];
                }
                if (order[i] == 'B')
                {
                    ans += numbers[1];
                }
                if (order[i] == 'C')
                {
                    ans += numbers[2];
                }
            }
            Console.WriteLine(ans);
        }
    }
}