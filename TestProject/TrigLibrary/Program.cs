using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float A, B, C;

            float a = 4;
            float b = 8;
            float c = 9;

            A = TrigMath.ComputeAngle(4, 8, 9);
           
            TrigMath.ComputeAngles(out A, out B, out C, 3f, 3f, 3f);

            A = (float)(A * TrigMath.RadiansToDegrees);
            B = (float)(B * TrigMath.RadiansToDegrees);
            C = (float)(C * TrigMath.RadiansToDegrees);
            Console.ReadKey();

        }
    }
}
