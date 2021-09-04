using System;

namespace MyOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string a, b;
            a = "A";
            b = "B";

            Console.WriteLine(a+ " " +b);

            ValueReference.ChangeNames(ref a, ref b);

            Console.WriteLine("After Change >");
            Console.WriteLine(a+ " "+b);

            PersonClass person = new PersonClass();
            person.Name = "Mariam";
            Console.WriteLine(person.Name);

            Dogs myDog = new Dogs();
            myDog.DogName = "Bitch";
            myDog.Bite();

            
            //polymorphism
            Shapes[] shapes = new Shapes[4];
            shapes[0] = new Shapes();
            shapes[1] = new Circles();
            shapes[2] = new Rectangles();
            shapes[3] = new Lines();

            foreach(var shape in shapes)
            {
                shape.Draw();
            }
            


            Console.WriteLine(myDog.DogName);
            
            Console.ReadLine();


        }
    }
}
