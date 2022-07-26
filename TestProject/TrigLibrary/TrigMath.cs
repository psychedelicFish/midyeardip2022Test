using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigLibrary
{
    internal class TrigMath
    {
        public static double DegreesToRadians { get => Math.PI / 180; } //This is PI / 180
        public static double RadiansToDegrees { get => 180 / Math.PI; }

        
        
        public static void ComputeAngles(out float A, out float B, out float C,
                                  in float a, in float b, in float c)
        {
            //(b ^ 2 + c ^ 2 - a ^ 2) / 2bc
            A = ComputeAngle(a, b, c);

            B = ComputeAngle(b, a, c);

            C = ComputeAngle(c, a, b);

        }


        /// <summary>
        ///opposite is the opposite side to the angle you want to calculate using acos
        ///</summary>
        public static float ComputeAngle(float opposite, float other1, float other2)
        {
            return (float)Math.Acos(((other1 * other1) + (other2 * other2) - (opposite * opposite)) / (2 * other1 * other2));
        }










     
  


    }
}
