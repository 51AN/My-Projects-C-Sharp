using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string store1,store2;
        bool switchCtrl1 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void additionOnClick(object sender, EventArgs e)
        {
            

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            string res = Convert.ToString(num1 + num2);

            textBox3.Text = res;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearOnClick(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();  
            textBox3.Clear();
            store1 = " ";
            store2 = " ";
            switchCtrl1 = true;
        }

        private void terminateOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subOnClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            string res = Convert.ToString(num1 - num2);

            textBox3.Text = res;
        }

        private void multOnClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            string res = Convert.ToString(num1 * num2);

            textBox3.Text = res;
        }

        private void DevideOnClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            string res = Convert.ToString(num1 / num2);

            textBox3.Text = res;
        }

        private void one(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "1";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "1";
                textBox2.Text = store2;

            }
        }
        private void two(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "2";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "2";
                textBox2.Text = store2;

            }
        }

        private void three(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "3";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "3";
                textBox2.Text = store2;

            }
        }

        private void four(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "4";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "4";
                textBox2.Text = store2;

            }
        }

        private void five(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "5";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "5";
                textBox2.Text = store2;

            }
        }

        private void six(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "6";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "6";
                textBox2.Text = store2;

            }
        }

        private void seven(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "7";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "7";
                textBox2.Text = store2;

            }
        }

        private void eight(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "8";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "8";
                textBox2.Text = store2;

            }
        }

        private void nine(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "9";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "9";
                textBox2.Text = store2;

            }
        }

        private void zero(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + "0";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + "0";
                textBox2.Text = store2;

            }
        }

       

        private void SwitchOnClick1(object sender, EventArgs e)
        {
            switchCtrl1 = true;
           
        }

        private void CofCalc(object sender, EventArgs e)
        {
            if(switchCtrl1 == true)
            {
                store1 = store1.Remove(store1.Length - 1);
                textBox1.Text = store1;
            }
            else
            {
                store2 = store2.Remove(store2.Length - 1);
                textBox2.Text = store2;

            }
        }

        private void decimal_button(object sender, EventArgs e)
        {
            if (switchCtrl1 == true)
            {
                store1 = store1 + ".";
                textBox1.Text = store1;

            }
            else
            {
                store2 = store2 + ".";
                textBox2.Text = store2;

            }
        }

        private void ModulusOnClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            string res = Convert.ToString(num1 % num2);

            textBox3.Text = res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gcdOnClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double gcd = 0;
            for(int i=1;i<num1 && i<num2;i++)
            {
                if(num1%i==0 && num2%i==0)
                {
                    gcd = i; 
                }

            }
            string res = Convert.ToString(gcd);

            textBox3.Text = res;
        }

        private void lcmOnClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double lcm = 0;
            double big = (num1 > num2 ? num1 : num2);
            for (double i=big; i>=big; ++i)
            {
                if(i%num1==0 && i%num2==0)
                {
                    lcm = i;
                    break;
                }
            }
            string res = Convert.ToString(lcm);
            textBox3.Text = res;
        }

        private void percantageOnClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            if(num1<num2)
            {
                MessageBox.Show("Baka put in right order!");

            }

            string res = Convert.ToString(num1 % num2);

            textBox3.Text = res;
        }

        private void swithcOnClick2(object sender, EventArgs e)
        {
            
            switchCtrl1 = false;
        }
    }
}
