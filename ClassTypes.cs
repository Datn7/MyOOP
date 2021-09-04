using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class ClassTypes
    {
        void GetClass()
        {

        }
    }

    class A 
    {
        public string Name { get; set; }

        class NestedClass
        {
            //don't do this shit.
        }

    }


    sealed class SealedClass
    {
        //sealed class cant be inherited, can't be parent
    }

    static class StaticClass
    {
        //static class only has static members
        //cant create instance of it
        //they are sealed
    }

    partial class PartialClass
    {
        //partial class can be reated in seperated file as well with same and and it will work.
    }
}
