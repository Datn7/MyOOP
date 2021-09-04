using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class ValueReference
    {
        public static void ChangeNames(ref string one, ref string two)
        {
            one = "Gio";
            two = "Mari";
            Console.WriteLine($"{one} \n {two}");
        }
    }
}
