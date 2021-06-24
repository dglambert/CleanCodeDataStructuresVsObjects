using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dglambert.CleanCodeDataStructuresVsObjects.Objects
{
    public class Rectangle : IShape
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
        public double Area()
        {
            return _height * _width;
        }

        public double Perimeter()
        {
            return (2 * _width) + (2 * _height);
        }
    }
}
