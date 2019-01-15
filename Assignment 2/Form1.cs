using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double Input = double.Parse(textBox1.Text);
                double Input2 = double.Parse(textBox2.Text);
                double Input3 = double.Parse(textBox3.Text);
                double answer = Input + Input2 + Input3;
                label1.Text = answer.ToString();


            }

            catch
            {
                MessageBox.Show("Please input a number");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                double Input = double.Parse(textBox4.Text);
                double Input2 = double.Parse(textBox5.Text);
                double answer = 1.0 / (1.0 / Input + 1.0 / Input2 + 1.0);
                label2.Text = answer.ToString();

            }

            catch
            {
                MessageBox.Show("Please input a number");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double Input, Input2, Input3, Input4, Input5;
            try
            {
                Input = double.Parse(textBox1.Text);
            }
            catch
            {
                Input = 0;
            }
            try
            {
                Input2 = double.Parse(textBox2.Text);
            }
            catch
            {
                Input2 = 0;
            }
            try
            {
                Input3 = double.Parse(textBox3.Text);

            }
            catch
            {
                Input3 = 0;
            }
            try
            {
                Input4 = double.Parse(textBox6.Text);
            }
            catch
            {
                Input4 = 0;
            }
            try
            {
                Input5 = double.Parse(textBox7.Text);
            }
            catch
            {
                Input5 = 0;
            }
            double answer = Input + Input2 + Input3 + Input4 + Input5;
            label1.Text = answer.ToString();

        
       
        }
    }

}




