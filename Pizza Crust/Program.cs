using System;
namespace Pizza_Crust // George loves cheese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            double R = 0.0; // R Pizza radius
            double C = 0.0; // C Crust not covered in cheese
            while ((line = Console.ReadLine()) != null)
            {
                double percentage = 0.000000000;
                try
                {
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                    R = double.Parse(split[0]);
                    C = double.Parse(split[1]);

                    if (R == C || C == 0 || R == 0)
                    {
                        percentage = 0;
                        Console.WriteLine(percentage.ToString("F9"));
                    }
                    else if ((1 <= C) && (C < R) && (R <= 100)) // Limits 1 <= C <= R <= 10
                    {
                        percentage = (((((Math.PI * (R - C) * (R - C)))) / ((Math.PI * R * R))) * 100);
                        Console.WriteLine(percentage.ToString("F6"));
                    }
                }
                catch { }
            }
        }
    }
}