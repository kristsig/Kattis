using System;
using System.IO;

public class RocketStages
{
    const int N = 11000;
    const double G = 9.8;
    static double[] A = new double[N + 100];

    static int to_i(string s)
    {
        return int.Parse(s);
    }

    public static void Main(string[] args)
    {
        StreamReader inStream = new StreamReader(Console.OpenStandardInput());
        StreamWriter outStream = new StreamWriter(Console.OpenStandardOutput());
        string stg = inStream.ReadLine();
        while (stg != null && !stg.Equals(""))
        {
            int i, j;
            double neginf = -1.0 / 0;
            for (i = 1; i < N; i++)
            {
                A[i] = neginf;
            }
            A[0] = 0;
            int stages = to_i(stg);
            for (i = 0; i < stages; i++)
            {
                string[] vs = inStream.ReadLine().Split();
                int ms = to_i(vs[0]), mf = to_i(vs[1]), th = to_i(vs[2]), fc = to_i(vs[3]);
                for (j = N; j >= 0; j--)
                {
                    int newm = j + ms;
                    int totm = newm + mf;
                    if (totm > 10000)
                        continue;
                    if (th / totm < G)
                        continue;
                    double time = 1.0 * mf / fc;
                    double acc = th * (Math.Log(newm + mf) - Math.Log(newm)) / fc - time * G;
                    acc = acc + A[j];
                    if (acc <= A[newm + mf])
                        continue;
                    A[newm + mf] = acc;
                }
            }
            double mx = 0;
            for (i = 0; i < N; i++)
            {
                if (A[i] > mx)
                    mx = A[i];
            }
            outStream.Write(String.Format("{0}\n", mx.ToString("0")));
            outStream.Flush();
            stg = inStream.ReadLine();
        }
        outStream.Close();
    }
}