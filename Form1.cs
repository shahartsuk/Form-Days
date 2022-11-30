using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFromsApp.CW30._11;

namespace WindowsFromsApp
{
    public partial class Form1 : Form
    {
        IItem[] items = new IItem[5];
        int counter = 0;
        public enum WorkDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            string drinks="";
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    MessageBox.Show("No drinks in the list.");
                    return;
                }
                else if (items[i] is Kinly) drinks += ("Kinly cost:" + items[i].GetPrice() + "$\n");
                else drinks += ("Cola cost:" + items[i].GetPrice() + "$\n");
            }
            for (int i = 0; i < items.Length; i++)
            {
                items[i]=null;
                counter = 0;
            }
            MessageBox.Show(drinks);
        }
        private void colaButton_Click(object sender, EventArgs e)
        {
            Cola cola = new Cola();
            cola.GetPrice();
            if(counter < 5)
            {
                items[counter] = cola;
                counter++;
            }
        }
        private void kinlyButton_Click(object sender, EventArgs e)
        {
            Kinly kinly = new Kinly();
            kinly.GetPrice();
            if (counter < 5)
            {
                items[counter] = kinly;
                counter++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = (NameBox.Text + " " + DayBox.Text + " " + AgeBox.Text);

            StreamWriter sr = File.AppendText(@"C:\Users\shaha\source\repos\WindowsFromsApp\WindowsFromsApp\FormTask.txt");

            sr.WriteLine(str);

            sr.Close();

            NameBox.Text = "";
            DayBox.Text = "";
            AgeBox.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            WorkDays fromString;
            string[] str;
            string[] strBox = new string[3];
            string fileName = @"C:\Users\shaha\source\repos\WindowsFromsApp\WindowsFromsApp\FormTask.txt";
            str = File.ReadAllLines(fileName);

            strBox[0] = str[0].Split(' ')[0];
            strBox[1] = str[0].Substring(strBox[0].Length+1).Split(' ')[0];
            strBox[2] = str[0].Substring(strBox[0].Length + strBox[1].Length+2).Split(' ')[0];

            NameBox.Text = strBox[0];
            DayBox.Text = strBox[1];
            AgeBox.Text = strBox[2];

           // fromString = (WorkDays)Enum.Parse(typeof(WorkDays), strBox[1]);
        }
        private void NameBox_MouseClick(object sender, MouseEventArgs e)
        {
            NameBox.Text = "";
        }

        private void DayBox_MouseClick(object sender, MouseEventArgs e)
        {
            DayBox.Text = "";
        }

        private void AgeBox_MouseClick(object sender, MouseEventArgs e)
        {
            AgeBox.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
    
}
