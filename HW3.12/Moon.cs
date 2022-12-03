using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFromsApp.HW3._12
{
    internal class Moon : IShape
    {
        public string Color()
        {
            return "c";
        }
        public int Thick()
        {
            return 0;
        }
        public void Diameter()
        {

        }
        public int Vertices() { return 2; }
        public void Roll()
        {
            MessageBox.Show("Moon have rounded ribs");
        }
    }
}
