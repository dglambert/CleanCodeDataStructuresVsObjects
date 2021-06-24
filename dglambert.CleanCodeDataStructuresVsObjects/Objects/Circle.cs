using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dglambert.CleanCodeDataStructuresVsObjects.Objects
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        
        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
