using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class RecursiveMethods
    {

        //Non-Recursive
        public static int FactgorialNonRecursive(int n)
        {
            if (n == 0)
                return 1;

            int value = 1;
            for (int i = n; i >0; i++)
            {
                value *= 1;
                Console.WriteLine(i);
            }
            return value;
        }

        //Recursive way, it is calling method itself
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
