using System;

namespace Train_Passengers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            long C = 0;
            long n = 0;
            long entering = 0;
            long exiting = 0;
            long whaiting = 0;
            long onboard = 0;
            long station = 0;
            bool possibility = true;
            string possible = "possible";
            string impossible = "impossible";
            while ((line = Console.ReadLine()) != null)
            {
                if (line.Length >= 3)
                {
                    try
                    {
                        int counter = 0;
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] == ' ')
                            {
                                counter += 1;
                            }
                        }

                        if (counter == 1)
                        {
                            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                            C = Int64.Parse(split[0]);
                            n = Int64.Parse(split[1]);
                            entering = 0;
                            exiting = 0;
                            whaiting = 0;
                            onboard = 0;
                            station = 0;
                            if ((C >= 1) && (C <= (long)Math.Pow(10, 9)) && (2 <= n) && n <= 100)
                            {
                                possibility = true;
                            }
                            else
                            {
                                possibility = false;
                            }
                        }

                        if (counter == 2)
                        {
                            station += 1;
                            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                            exiting = Int64.Parse(split[0]);
                            entering = Int64.Parse(split[1]);
                            whaiting = Int64.Parse(split[2]);

                            if (onboard < exiting)
                            {
                                possibility = false;
                            }
                            onboard -= exiting;

                            onboard += entering;

                            if (station == n && onboard != 0)
                            {
                                possibility = false;
                            }
                            if (onboard > C || onboard < 0)
                            {
                                possibility = false;
                            }
                            if (station == n && whaiting > 0)
                            {
                                possibility = false;
                            }
                            if (onboard < C && whaiting != 0)
                            {
                                possibility = false;
                            }


                            if (station == n)
                            {
                                if (possibility == true)
                                {
                                    Console.WriteLine(possible);
                                }
                                if (possibility == false)
                                {
                                    Console.WriteLine(impossible);
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
        }
    }
}