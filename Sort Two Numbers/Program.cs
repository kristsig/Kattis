using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Sort_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<long> numbers = new List<long>();
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                if (split.Length > 0)
                {
                    for(int i = 0; i < split.Length; i++)
                    {
                        numbers.Add(long.Parse(split[i]));
                    }
                    numbers.Sort();
                    Console.Write(numbers[0]);
                    for(int x=1; x<numbers.Count; x++)
                    {
                        Console.Write(" " + numbers[x]);
                    }
                    Console.WriteLine();
                    numbers.Clear();
                }
            }
        }
    }
}