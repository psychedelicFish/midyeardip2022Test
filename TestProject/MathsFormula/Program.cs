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

            Console.Write(sw.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}
