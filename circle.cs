/*Circle is a class with property radius and methods setRadius(), \
getRadius(), calcDiameter(), calcArea().Use double precision for everything. 
Write appropriate driver program to test the methods. */
using System;

namespace Dailytask 
{
    class Circle
    {
        public double radius;
     
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Setradius(double radius)
        {
            this.radius = radius;
        }

        public double Getradius()
        {
            return this.radius;
        }

        public double CalcDiameter()
        {
            return (2 * radius);

        }

       
        public double CalcArea()
        {
            return (3.14 * radius * radius);
        }
    }
    class circle
    {
       static void Main(String[] args)
        {
        
            Circle c1 = new Circle(10); 

            c1.CalcDiameter();
            c1.CalcArea();

            Console.WriteLine($"Radius of circle is 10 so its diameter is {c1.CalcDiameter()} and Area is {c1.CalcArea()} ");

            c1.Setradius(2.3); 
            Console.WriteLine($"Radius of circle is so its diameter is {c1.CalcDiameter()} and Area is {c1.CalcArea()} ");
        }
    }
}
