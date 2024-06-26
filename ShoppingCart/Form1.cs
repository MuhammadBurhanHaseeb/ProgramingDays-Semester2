using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblOuter_Click(object sender, EventArgs e)
        {

        }

        private void lblP1_Click(object sender, EventArgs e)
        {

        }

        private void lblP21_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float quantity = 0 , multi = 0   ;
            if (float.TryParse(TBp21.Text, out float a ))
            {
                quantity = float.Parse(TBp21.Text);
                 multi = quantity * float.Parse(lblP22.Text);

            }
            else
            {
                 multi = 0 * float.Parse(lblP22.Text);

            }

            string display = multi.ToString();
            TBp22.Text = display;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblT1_Click(object sender, EventArgs e)
        {

        }

        private void lblP22_Click(object sender, EventArgs e)
        {

        }

        private void TBp12_TextChanged(object sender, EventArgs e)
        {
            if((float.TryParse(TBp22.Text, out float n) && (float.TryParse(TBp32.Text,out float k))))
            {
                float multi = float.Parse(TBp22.Text) + float.Parse(TBp32.Text) + float.Parse(TBp12.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display; 
            }
            else if(float.TryParse(TBp22.Text, out float a))
            {

                float multi = float.Parse(TBp22.Text) + float.Parse(TBp12.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
            else if(float.TryParse(TBp32.Text, out float b))
            {
                float multi = float.Parse(TBp32.Text) + float.Parse(TBp12.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
            else
            {
                float multi = float.Parse(TBp12.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
        }

        private void TBp11_TextChanged(object sender, EventArgs e)
        {
            float quantity = 0, multi = 0;
            if (float.TryParse(TBp11.Text, out float a))
            {
                quantity = float.Parse(TBp11.Text);
                multi = quantity * float.Parse(labelp12.Text);

            }
            else
            {
                multi = 0 * float.Parse(labelp12.Text);

            }

            string display = multi.ToString();
            TBp12.Text = display;


           /* float  quantity = float.Parse(TBp11.Text);
            float multi = quantity * float.Parse(labelp12.Text);
            string display = multi.ToString();
            TBp12.Text =  display;*/

            //>>>>>>>>>>>>>>>

            //float k = ((float.Parse(labelp12.Text)) + (float.Parse(lblP22.Text)) + (float.Parse(lblP32.Text))
           
           // TBt1.Text = "$" + display;

        }

        private void TBp31_TextChanged(object sender, EventArgs e)
        {
            float quantity = 0, multi = 0;
            if (float.TryParse(TBp31.Text, out float a))
            {
                quantity = float.Parse(TBp31.Text);
                multi = quantity * float.Parse(lblP32.Text);

            }
            else
            {
                multi = 0 * float.Parse(lblP32.Text);

            }

            string display = multi.ToString();
            TBp32.Text = display;


            /*float quantity = float.Parse(TBp31.Text);
            float multi = quantity * float.Parse(lblP32.Text);
            string display = multi.ToString();
            TBp32.Text =  display;*/
        }

        private void TBp22_TextChanged(object sender, EventArgs e)
        {
            if ((float.TryParse(TBp12.Text, out float n) && (float.TryParse(TBp32.Text, out float k))))
            {
                float multi = float.Parse(TBp22.Text) + float.Parse(TBp32.Text) + float.Parse(TBp12.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
            else if (float.TryParse(TBp12.Text, out float a))
            {

                float multi = float.Parse(TBp22.Text) + float.Parse(TBp12.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
            else if (float.TryParse(TBp32.Text, out float b))
            {
                float multi = float.Parse(TBp32.Text) + float.Parse(TBp22.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
            else
            {
                float multi = float.Parse(TBp22.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
        }

        private void TBp32_TextChanged(object sender, EventArgs e)
        {
            if ((float.TryParse(TBp22.Text, out float n) && (float.TryParse(TBp12.Text, out float k))))
            {
                float multi = float.Parse(TBp22.Text) + float.Parse(TBp32.Text) + float.Parse(TBp12.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
            else if (float.TryParse(TBp22.Text, out float a))
            {

                float multi = float.Parse(TBp22.Text) + float.Parse(TBp32.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
            else if (float.TryParse(TBp12.Text, out float b))
            {
                float multi = float.Parse(TBp32.Text) + float.Parse(TBp12.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
            else
            {
                float multi = float.Parse(TBp32.Text);
                string display = multi.ToString();
                TBt1.Text = "$" + display;
            }
        }

        private void lblP13_Click(object sender, EventArgs e)
        {
            TBp11.Text = "";
        }

        private void lblP23_Click(object sender, EventArgs e)
        {
            TBp21.Text = "";
        }

        private void lblP33_Click(object sender, EventArgs e)
        {
            TBp31.Text = "";
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            clearDataFromForm();
        }
        private void clearDataFromForm()
        {
            TBp11.Text = "";
            TBp21.Text = "";
            TBp31.Text = "";
        }
    }
}
