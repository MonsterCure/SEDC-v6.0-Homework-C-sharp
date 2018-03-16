using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public override double Perimeter()
        {
            double perimeter = 2 * Math.PI * _radius;
            Console.WriteLine($"The perimeter of the circle with a radius of {_radius} is {perimeter}");
            return perimeter;
        }

        public override double Area()
        {
            double area = Math.Pow(_radius, 2) * Math.PI;
            Console.WriteLine($"The area of the circle with a radius of {_radius} is {area}");
            return area;
        }
    }
}
