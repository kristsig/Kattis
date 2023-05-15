using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Two_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                int sum = 0;
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                for (int i = 0; i < split.Length; i++)
                {
                    sum += int.Parse(split[i]);
                }
                Console.WriteLine(sum);
            }
        }
    }
}