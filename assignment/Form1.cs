using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Width = double.Parse(width.Text);
                double Length = double.Parse(length.Text);
                double Height = double.Parse(height.Text);
                double volume = Width * Length * Height;
                double area = 2.0 * (Length * Height + Length * Width + Width * Height);
                label2.Text = "area =" + area;
                label1.Text = "volume =" + volume;
            }
            catch
            {
                MessageBox.Show("error");
            }
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBox1.Text);
                double surfacearea = (4 * (Math.PI * radius * radius));
                double volume = (4.0 / 3.0 * (Math.PI * radius * radius * radius));
                label3.Text = "Surface area = " + surfacearea;
                label4.Text = "volume = " + volume;
                
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(Radius.Text);
                double height = double.Parse(TextBox6.Text);
                double Surfacearea = (Math.PI * radius * ( radius + Math.Sqrt (height * height + radius + radius )));
                double volume = ((1.0 / 3.0) * Math.PI * radius * radius * height);
                label5.Text = "surface area = " + Surfacearea;
                label6.Text = "volume = " + volume;
            }
            catch
            {
                MessageBox.Show("error");
            }
                
        }
    }
}
