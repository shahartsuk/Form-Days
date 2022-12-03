using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFromsApp.HW3._12
{
    internal class Triangle : IShape
    {
        public string Color()
        {
            return "c";
        }
        public int Thick()
        {
            return 0;
        }
        public int Width()
        {
            return 0;
        }
        public int Height()
        {
            return 0;
        }
        public int Vertices() { return 3; }
    }
}
