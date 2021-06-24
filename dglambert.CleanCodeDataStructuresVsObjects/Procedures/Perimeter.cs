using dglambert.CleanCodeDataStructuresVsObjects.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dglambert.CleanCodeDataStructuresVsObjects.Procedures
{
    public static class Perimeter
    {
        public static double GetPerimeter(IShape shape)
        {

            string shapeName = shape.GetType().Name;

            switch (shapeName)
            {
                case "Circle":
                    return 2 * Math.PI * ((DataStructures.Circle)shape).Radius;
                case "Square":
                    return ((DataStructures.Square)shape).Side * 4;
                case "Rectangle":
                    return (2 * ((DataStructures.Rectangle)shape).Width) + (2 * ((DataStructures.Rectangle)shape).Height);
                default:
                    throw new NotImplementedException();
            }

        }
    }
}
