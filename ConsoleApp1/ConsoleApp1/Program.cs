using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Josh";
            string t = (string)s.Reverse();
            
            Vector3 myVector2 = new Vector3(1,1,1);

           

            Console.ReadKey();
            

        }
    }

    internal class MyList<T> : List<T>
    {

        public new void Add(T item)
        {

        }



    }
}
