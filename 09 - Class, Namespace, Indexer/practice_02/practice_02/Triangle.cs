using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Triangle
    {
        private int _side1;
        private int _side2;
        private int _side3;

        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }

        public int Side2
        {
            get { return _side2; }
            set { _side2 = value; }
        }

        public int Side3
        {
            get { return _side3; }
            set
            {
                if (IsValidTriangle(_side1, _side2, value))
                    _side3 = value;
                else
                    Console.WriteLine("it is not valid triangle");
            }
        }

        private bool IsValidTriangle(int side1, int side2, int side3)
        {
            return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
        }

        public int Perimeter()
        {
            if (!IsValidTriangle(_side1, _side2, _side3)) return -1;
            return _side1 + _side2 + _side3;
        }

        public double Area()
        {
            double semiPerimeter = Perimeter() / 2.0;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
        }
    }
}