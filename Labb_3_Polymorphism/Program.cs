using System;

namespace Labb_3_Polymorphism
{   
    class Program
    {
        static void Main(string[] args)
        {
            Drawing drawing;

            drawing = new Rectangle();
            Console.WriteLine(drawing);

            drawing = new Circle();
            Console.WriteLine(drawing);

            drawing = new Square();
            Console.WriteLine(drawing);
            
            Console.ReadLine();
        }
    }
}
