using System;

namespace Exercise14_Inheritance
{
    // Base Class
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape");
        }
    }

    // Derived Class - Circle
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    // Derived Class - Rectangle
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Shape circle = new Circle();
            Shape rectangle = new Rectangle();

            Console.WriteLine("Base Class:");
            shape.Draw();

            Console.WriteLine();

            Console.WriteLine("Derived Classes:");
            circle.Draw();
            rectangle.Draw();
        }
    }
}