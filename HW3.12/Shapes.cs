using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFromsApp.HW3._12
{
    public partial class Shapes : Form
    {
        IShape[] ShapesArr = new IShape[100];
        int counter = 0;
        public Shapes()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(CircleBox.Checked)
            {
                Circle circle = new Circle();
                ShapesArr[counter] = circle;
            }
            else if(EllipseBox.Checked)
            {
                Ellipse ellipse = new Ellipse();
                ShapesArr[counter] = ellipse;
            }
            else if(MoonBox.Checked)
            {
                Moon moon = new Moon();
                ShapesArr[counter] = moon;
            }
            else if(RectangleBox.Checked)
            {
                Rectangle rectangle = new Rectangle();
                ShapesArr[counter] = rectangle;
            }
            else
            {
                Triangle triangle = new Triangle();
                ShapesArr[counter] = triangle;
            }
            CircleBox.Checked = false;
            EllipseBox.Checked = false;
            MoonBox.Checked= false;
            RectangleBox.Checked = false;
            TriangleBox.Checked = false;
            counter++;
        }

        private void ShowResult_Click(object sender, EventArgs e)
        {
            int VerticesCounter = 0;
            for (int i = 0; i < counter; i++)
            {
                VerticesCounter += ShapesArr[i].Vertices();
            }
            Result.Text = ("There is " + VerticesCounter.ToString() + " Vertices in the Shapes Array");
        }

        private void RectangleBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
