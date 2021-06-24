using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dglambert.CleanCodeDataStructuresVsObjects.Objects
{
    public interface IShape : IHasArea, IHasPerimeter
    {
    }

    public interface IHasArea
    {
        double Area();
    }

    public interface IHasPerimeter
    {
        double Perimeter();
    }

    public interface IHasCenter
    {
        double Center();
    }
}
