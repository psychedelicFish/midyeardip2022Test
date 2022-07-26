using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsFormula
{
    internal class Formula
    {
        //   𝑓(𝑥) = 𝑥2 + 2𝑥 – 7 

        public float Quadratic(float x)
        {
            return x * x + 2 * x - 7;
        }

        public struct Point
        {
            public Point(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

            public float x;
            public float y;

            public static Point operator+(Point lhs, Point rhs)
            {
                return new Point(lhs.x + rhs.x, lhs.y + rhs.y);
            }

            public static Point operator*(Point lhs, float rhs)
            {
                return new Point(lhs.x * rhs, lhs.y * rhs);
            }

            public static Point operator*(float lhs, Point rhs)
            {
                return rhs * lhs;
            }


        }

        //𝐷(𝑃1,𝑃2) = √((𝑥2 −𝑥1)2 +(𝑦2 −𝑦1)2) 

        public float Pythagoras(Point a, Point b)
        {
            return (float)Math.Sqrt(((a.x - b.x) * (a.x - b.x)) + ((a.y - b.y) * (a.y - b.y)));
        }

        //𝐿(𝑠,𝑒,𝑡) =  𝑠+𝑡(𝑒−𝑠)
        //
        public float LinearBlend(float s, float e, float t)
        {
            return s + t * (e - s);
        }


        //𝐵(𝑡,𝑃0,𝑃1,𝑃2,𝑃3)=  (1−𝑡) ^3 * 𝑃0 +3 * (1−𝑡) ^ 2 * 𝑡 * 𝑃1 +3 * (1−𝑡) * 𝑡 ^ 2 * 𝑃2 +𝑡 ^ 3 * 𝑃3  

        public Point BezierCurve(float t, Point p1, Point p2, Point p3, Point p4)
        {
            return (float)(Math.Pow(1 - t, 3)) * p1 + 3 * (float)Math.Pow(1 - t, 2) * t * p2 + 3 * (1 - t) * (float)Math.Pow(t, 2) * p3 + (float)Math.Pow(t, 3) * p4;


        }


    }
}
