using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class Inheritance
    {        
    }

    public class Animal
    {
        public string AnimalName { get; set; }

        public void Bite()
        {
            Console.WriteLine("Bite AF");
        }
    }

    public class Dogs: Animal
    {
        public string DogName { get; set; }
        public string DogColor { get; set; }
        
        public void TakeAShit()
        {
            Console.WriteLine("Dog Took a Shit!");
        }
    }
}
