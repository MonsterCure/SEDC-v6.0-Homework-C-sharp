using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Rectangle : Shape
    {
        private double _width;
        private double _length;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public double Height
        {
            get { return _length; }
            set { _length = value; }
        }

        public Rectangle(double width, double length)
        {
            this._width = width;
            this._length = length;
        }

        public override double Perimeter()
        {
            double perimeter = 2* (_width + _length);
            Console.WriteLine($"The perimeter of the rectangle with width {_width} and length {_length} is {perimeter}");
            return perimeter;
        }

        public override double Area()
        {
            double area = _width * _length;
            Console.WriteLine($"The area of the rectangle with width {_width} and length {_length} is {area}");
            return area;
        }
    }
}
