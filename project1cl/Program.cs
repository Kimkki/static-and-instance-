using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1cl
{
    class Circle
    {
        static float _PI;
        int Radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        static Circle()
        {
            Circle._PI = 3.145F;
        }

        public float CalculateArea()
        {
            return Circle._PI * this.Radius * this.Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float area = c1.CalculateArea();

            Console.WriteLine("Area = {0} ", area);
        }
    }
}
