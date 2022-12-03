using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFromsApp.HW3._12
{
    internal class Circle : IShape
    {
        public string Color()
        {
            return "c";
        }
        public int Thick()
        {
            return 0;
        }
        public int radius()
        {
            return 0;
        }
        public int Vertices() { return 0; }
        public void Roll()
        {
            MessageBox.Show("Sircle have rounded ribs");
        }
    }
}
