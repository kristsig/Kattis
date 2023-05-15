using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Jack_O__Lantern_Juxtaposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                double sum = 1;
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                if (split.Length > 0)
                {
                    sum = double.Parse(split[0]);
                    for(int i = 1; i < split.Length; i++)
                    {
                        sum = (sum * double.Parse(split[i]));
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}