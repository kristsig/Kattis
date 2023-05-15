using System;
using System.Collections;

namespace Autori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string acronym = "";
                string[] split = line.Split(new char[] { '-' }, StringSplitOptions.None);
                if (split.Length > 0)
                {
                    for (int i = 0; i < split.Length; i++)
                    {
                        acronym += split[i][0];
                    }
                }
                Console.WriteLine(acronym);
            }
        }
    }
}