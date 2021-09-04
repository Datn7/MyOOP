using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    public class Methods
    {
        public static void PerformOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            Console.WriteLine($"{x} + {y} = {addResult}");
        }

        public static string AddString(string a, string b)
        {
            string addedResult = "";
            addedResult = a + b;
            return addedResult;
        }

        public static string GetName(string name)
        {
            name = Console.ReadLine();
            return "Hi" + name;
        }

        
    }
  
}
