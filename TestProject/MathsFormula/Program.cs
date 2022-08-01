using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsFormula
{
    internal class Program
    {
        static long lastTime = 0;
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            float result = 1;
            for(int i = 1; i < 10000000; i++)
            {
                result *= i;
            }
            sw.Stop();

            float ems = sw.ElapsedMilliseconds;
            float emsperop = ems / 10000000;

            Console.Write("Elapsed milliseconds after loop over 10000000 multiplies: " + ems);
            Console.Write(" or " + emsperop + " ms per multiply");
            Console.ReadLine();

        }
    }
}
