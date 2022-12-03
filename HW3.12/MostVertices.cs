using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFromsApp.HW3._12
{
    internal class MostVertices
    {
        public IShape Vertices(IShape shape1,IShape shape2)
        {
            if (shape1 is Rectangle) return shape1;
            else if (shape2 is Rectangle) return shape2;
            else if (shape1 is Triangle) return shape1;
            else return shape2;
        }
    }
}
