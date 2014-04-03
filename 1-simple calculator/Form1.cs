using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double value1, value2;
            

            try
            {
                value1 = Convert.ToDouble(textBox_value1.Text);
                value2 = Convert.ToDouble(textBox_value2.Text);

                double result = 0;

                if (radioButton_add.Checked)
                {
                    result = value1 + value2;
                }
                if (radioButton_Subs.Checked)
                {
                    result = value1 - value2;
                }
                if (radioButton_mult.Checked)
                {
                    result = value1 * value2;
                }
                if (radioButton_div.Checked)
                {
                    result = value1 / value2;
                }

                //textBox_result.Text = Convert.ToString(result);
                label_result.Text = Convert.ToString(result);
                MessageBox.Show("Calculation Completed...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not valid numbers."+ ex.ToString());
            }

            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

     

        
    }
}
