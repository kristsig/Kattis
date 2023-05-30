using System;

namespace _3D_Printed_Statues
{
    internal class Program
    {
        static int Counting(int n)
        {
            int counter = 0;
            while (n > 0)
            {
                counter++;
                n >>= 1;
            }
            return counter - 1;
        }
        static int Days(int n)
        {
            return n < 4 ? n : (n & (n - 1)) != 0 ? Counting(n << 1 + 1) : Counting(n) + 1;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Days(n));
        }
    }
}