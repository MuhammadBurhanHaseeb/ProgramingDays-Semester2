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
       public   string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
          
            TB1.Text = TB1.Text + "2";

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            TB1.Text = TB1.Text + "1";

        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            TB1.Text = TB1.Text + "-";

        }

        private void button11_Click(object sender, EventArgs e)
        {
          
            TB1.Text = TB1.Text + "/";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
           
            TB1.Text = TB1.Text + "0";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
        
            TB1.Text = TB1.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
           
            TB1.Text = TB1.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
            TB1.Text = TB1.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {



            TB1.Text = TB1.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
        
            TB1.Text = TB1.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            
            TB1.Text = TB1.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
           
            TB1.Text = TB1.Text + "9";

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {

                
            TB1.Text = TB1.Text + ".";

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
            TB1.Text = TB1.Text + "+";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
           
            TB1.Text = TB1.Text + "x";

            //TB1.Text = s;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            TB1.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int count = 0;
            string  n = TB1.Text;
            int length = n.Length;
            string sum = "";
            for (int  x= 0;x<length; x++)
            {
                count++;
             if  (count < length )
                {
                    sum = sum + n[x];
                }
            }
            TB1.Text = sum;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            int count = 0, plus = 0,minus=0,multi = 0 , div = 0  ;
            string n = TB1.Text;
            int length = n.Length;
            string a="", b="";
            for (int x = 0; x<length; x++)
            {
                if (count >1 || multi >1  ||  plus >1     || minus >1 || div >1)
                {
                    MessageBox.Show("error");
                }
                if (n[x] == 'x')
                {
                    multi++;
                    count++;
                }
                else if (n[x] == '-')
                {
                    minus++;
                    count++;
                }
                else if (n[x] == '+')
                {
                    plus++;
                    count++;
                }
                else if (n[x] == '/')
                {
                    div++;
                    count++;
                }
                else if (n[x] != 'x'&& n[x] != '-'&& n[x] != '+'&& n[x] != '/' && count == 0)
                {
                    a = a + n[x];
                }
                else if (n[x] != 'x' && n[x] != '-' && n[x] != '+' && n[x] != '/' && count == 1)
                {
                    b = b + n[x];
                }
            }

            float first = float.Parse(a);
            float second = float.Parse(b);
            float ans = 0;
            if (multi == 1 )
            {
                ans = first * second;
            }
            else if (plus == 1)
            {
                ans = first + second;
            }
            else if (minus == 1)
            {
                ans = first - second;
            }
            else if (div == 1)
            {
                ans = first / second;
            }
            string convert = ans.ToString();
            TB1.Text = convert;

        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {
          //  s = s + TB1.Text;
            //TB1.Text = s;
        }
    }
}
