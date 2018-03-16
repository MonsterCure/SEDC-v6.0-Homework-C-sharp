using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Triangle : Shape
    {
        private double _base;
        private double _side1;
        private double _side2;

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }
        public double Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }
        public double Side2
        {
            get { return _side2; }
            set { _side2 = value; }
        }

        public Triangle(double baseLenght, double side1, double side2)
        {
            this._base = baseLenght;
            this._side1 = side1;
            this._side2 = side2;
        }

        public override double Perimeter()
        {
            double perimeter = _base + _side1 + _side2;
            Console.WriteLine($"The perimeter of the triangle with sides {_base}, {_side1} and {_side2} is {perimeter}");
            return perimeter;
        }

        public override double Area()
        {
            double halfPerimeter = (_base + _side1 + _side2) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - _base) * (halfPerimeter - _side1) * (halfPerimeter - _side2));
            Console.WriteLine($"The area of the triangle with with sides {_base}, {_side1} and {_side2} is {area}");
            return area;
        }
    }
}
