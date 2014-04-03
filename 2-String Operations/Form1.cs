using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String givenString = textBox1.Text;

            if (givenString.StartsWith("Dr."))
            {
                textBox2.Text = givenString + "," + "is a Doctor";
            }
            else
            {
                textBox2.Text = givenString + "," + "is NOT a Doctor";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           String newStr = textBox3.Text.Replace(" j","");

           textBox2.Text = String.Concat("####", newStr, "######");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int length = textBox4.Text.Length;

            String newStr = textBox4.Text.Substring(5);

            int indx = textBox4.Text.IndexOf('*');

            //textBox2.Text = String.Concat("The Substring is: ", newStr );
            textBox2.Text = String.Concat("* index is: ", indx);

            int indx2 = textBox4.Text.IndexOf('*', indx+1);            
            textBox2.Text += String.Concat("* index is: ", indx2);
        }
    }
}
