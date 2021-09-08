using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{


    //delegate calls are little bit faster than direct calls of methods.
    //delegates an be mustitasked. initiale it and make it null. use += to variable to add more methods.
    public delegate void AboutShitInfoDelegate();

    delegate void DisplayAnonymousInfo();

    class Delegates
    {
        //declare anonymous method that has no name
        DisplayAnonymousInfo anonymousInfoMethod = delegate { Console.WriteLine("I am anonymous AF"); };

        public static void DisplayInformation()
        {
            Console.WriteLine("Info About Shit: Daaaaaaaaang");
        }

        public static void DisplayInformation(string shitName)
        {
            Console.WriteLine("Info About Shit: Daaaaaaaaang" + shitName);
        }

        //Func is built in delegate that can have up to 16 params
        //Action is same but does not return shit.
        //Predicate is combination of those but must take one input param and returns boolean.
    }
}
