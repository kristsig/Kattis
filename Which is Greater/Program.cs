using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Which_is_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                try
                {
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    long a = long.Parse(split[0]);
                    long b = long.Parse(split[1]);
                    if (a > b)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
                catch { }
            }
        }
    }
}