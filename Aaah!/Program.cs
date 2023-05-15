using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Aaah_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aOftheDay = Console.ReadLine();
            string aRequiredbydoctor = Console.ReadLine();

            if (aOftheDay.Length >= aRequiredbydoctor.Length)
            {
                Console.WriteLine("go");
            }
            else { Console.WriteLine("no"); }
        }
    }
}