using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Diamond : Shape
    {
        private double _diagonal1;
        private double _diagonal2;

        public double Diagonal1
        {
            get { return _diagonal1; }
            set { _diagonal1 = value; }
        }
        public double Diagonal2
        {
            get { return _diagonal2; }
            set { _diagonal2 = value; }
        }

        public Diamond(double diagonal1, double diagonal2)
        {
            this._diagonal1 = diagonal1;
            this._diagonal2 = diagonal2;
        }

        public override double Perimeter()
        {
            double perimeter = 2 * (_diagonal1 + _diagonal2);
            Console.WriteLine($"The perimeter of the diamond shape with one diagonal of {_diagonal1} and another of {_diagonal2} is {perimeter}");
            return perimeter;
        }

        public override double Area()
        {
            double area = (_diagonal1 * _diagonal2) / 2;
            Console.WriteLine($"The area of the diamond shape with one diagonal of {_diagonal1} and another of {_diagonal2} is {area}");
            return area;
        }
    }
}
