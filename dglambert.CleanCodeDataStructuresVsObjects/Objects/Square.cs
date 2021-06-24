using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dglambert.CleanCodeDataStructuresVsObjects.Objects
{
    public class Square : IShape
    {
        private readonly double _side;
        public Square(double side)
        {
            _side = side;
        }

        public double Area()
        {
            return Math.Pow(_side, 2);
        }

        public double Perimeter()
        {
            return _side * 4;
        }
    }
}
