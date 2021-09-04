using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class Polymorphism
    {
    }

    class Shapes
    {
        //use virtual keyword in method and ovverride in child classes method names
        public virtual void Draw()
        {
            Console.WriteLine("I am simple shape");
        }
    }

    class Circles:Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am a circle");
        }
    }

    class Rectangles : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am a rectangle");
        }
    }

    class Lines : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am a line");
        }
    }
}
