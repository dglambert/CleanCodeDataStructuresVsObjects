using dglambert.CleanCodeDataStructuresVsObjects.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dglambert.CleanCodeDataStructuresVsObjects.Procedures
{
    public class Area
    {
        public static double GetArea(IShape shape)
        {
            string shapeName = shape.GetType().Name;

            switch (shapeName)
            {
                case "Circle":
                    return Math.PI * Math.Pow(((DataStructures.Circle)shape).Radius, 2);
                case "Square":
                    return Math.Pow(((DataStructures.Square)shape).Side, 2);
                case "Rectangle":
                    return ((DataStructures.Rectangle)shape).Height * ((DataStructures.Rectangle)shape).Width; 
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
