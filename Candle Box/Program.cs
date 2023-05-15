using System;
using System.Diagnostics;

namespace Candle_Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageDifference = 0, candleBoxRita = 0, candleBoxTheo = 0;

            int startAgeRita = 4;
            int startAgeTheo = 3;
            int candlesToRemove = 0;
            try
            {
                ageDifference += int.Parse(Console.ReadLine());
                candleBoxRita += int.Parse(Console.ReadLine());
                candleBoxTheo += int.Parse(Console.ReadLine());

                if ((ageDifference >= 1 && ageDifference <= 20))
                {
                    if ((candleBoxRita >= 4 && candleBoxRita <= 1000))
                    {
                        if ((candleBoxTheo >= 0 && candleBoxTheo <= 1000))
                        {
                            int candlesTotal = candleBoxRita + candleBoxTheo;
                            int currentAgeRita = startAgeRita;
                            int currentAgeTheo = startAgeTheo;
                            int candleCountRita = 0;
                            int candleCountTheo = 0;
                            int candleCount = 0;
                            while (candleCount < candlesTotal)
                            {
                                candleCountRita += currentAgeRita;
                                if (currentAgeRita - currentAgeTheo >= ageDifference)
                                {
                                    candleCountTheo += currentAgeTheo;
                                    currentAgeTheo++;
                                }
                                candleCount = candleCountRita + candleCountTheo;
                                currentAgeRita++;
                            }
                            candlesToRemove = candleBoxRita - candleCountRita;
                        }
                    }
                }
                Console.WriteLine(candlesToRemove);
            }
            catch { }// (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}