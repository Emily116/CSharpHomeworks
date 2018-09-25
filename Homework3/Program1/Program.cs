using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public abstract class Shape
    {
        public abstract void create();
        public abstract double Area();
    }
    public class Triangle : Shape
    {
        double height; double bases;
        public Triangle()
        {
            string s1 = (Console.ReadLine());
            string s2 = (Console.ReadLine());
            bases = Double.Parse(s1);
            height = Double.Parse(s2);
        }
        public override void create()
        {
            Console.WriteLine("draw a triangle");
        }
        public override double Area()
        {
            return bases * height / 2;
        }
    }
    public class Circle : Shape
    {
        const double PI = 3.14159;
        double radius;
        public Circle()
        {
            string s = (Console.ReadLine());
            radius = Double.Parse(s);
        }
        public override void create()
        {
            Console.WriteLine("draw a circle");
        }
        public override double Area()
        {
            return PI * radius * radius;
        }
    }
    public class Rectangle : Shape
    {
        double bases; double height;
        public Rectangle()
        {
            string s1 = (Console.ReadLine());
            string s2 = (Console.ReadLine());
            bases = Double.Parse(s1);
            height = Double.Parse(s2);
        }
        public override void create()
        {
            Console.WriteLine("draw a rectangle");
        }
        public override double Area()
        {
            return bases * height;
        }
    }
    public class Square : Shape
    {
        double side;
        public Square()
        {
            string s = (Console.ReadLine());
            side = Double.Parse(s);
        }
        public override void create()
        {
            Console.WriteLine("draw a square");
        }
        public override double Area()
        {
            return side * side;
        }
    }
    class ShapeFactory
    {
        public static Shape createShape(String name)
        {
            if(name.Equals("triangle"))
            {
                return new Triangle();
            }
            if (name.Equals("circle"))
            {
                return new Circle();
            }
            if (name.Equals("rectangle"))
            {
                return new Triangle();
            }
            if (name.Equals("square"))
            {
                return new Triangle();
            }
            else
            {
                return null;
            }
        }
    }
    class Program
    {
        //const double PI = 3.14159;
        static void Main(string[] args)
        {
            try
            {
                Shape obj = ShapeFactory.createShape("triangle");
                //obj = ShapeFactory.createShape("circle");
                //obj = ShapeFactory.createShape("rectangle");
                //obj = ShapeFactory.createShape("square");
                obj.create();
                Console.WriteLine("The area is " + obj.Area());
            }
            catch(System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
