using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class Abstraction
    {
        void Write()
        {
            AbstractLines line= new AbstractLines();
            line.SayHi();
        }
    }

    abstract class AbstractShapes
    {
        abstract public void Draw();
        public void SayHi()
        {
            Console.Write("Hi from the abstract class");
        }
    }

    class AbstractLines : AbstractShapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawn line");
        }
    }
}
