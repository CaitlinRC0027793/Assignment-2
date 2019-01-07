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


    }

}




