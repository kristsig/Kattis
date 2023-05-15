using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _0_1_Sequences
{
    internal class Program
    {
        public static int MOD = 1000000007;
        public static List<int> MEM = new List<int> { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096 };
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double result = Inversions(input);
            Console.WriteLine(result);
        }
        public static long mod_pow2(int n)
        {
            while (n >= MEM.Count)
            {
                MEM.Add((MEM[MEM.Count - 1] * 2) % MOD);
            }
            return MEM[n];
        }
        public static long Inversions(string s)
        {
            long total = 0;
            long zeros = 0;
            int questions = 0;
            foreach (char c in s.Reverse())
            {
                if (c == '1')
                {
                    long z = zeros * mod_pow2(questions);
                    long q = (questions == 0) ? 0 : questions * mod_pow2(questions - 1);
                    total = (total + z + q) % MOD;
                }
                else if (c == '0')
                {
                    zeros += 1;
                }
                else
                {
                    total *= 2;
                    long z = zeros * mod_pow2(questions);
                    long q = (questions == 0) ? 0 : questions * mod_pow2(questions - 1);
                    total = (total + z + q) % MOD;
                    questions += 1;
                }
            }
            return total;
        }
    }
}