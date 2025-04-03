using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using practice_project.Math;

namespace practice_project
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var a = 29;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a : {0}, b: {1}", a, b));

            var array1 = new[] { 1, 2, 3 };
            var array2 = array1;
            array2[1] = 4;
            Console.WriteLine(string.Format("array1[1]: {0}, array2[1]: {1}", array1[1], array2[1]));
        }
    }
      
}
