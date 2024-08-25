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
        public Form1()
        {
            InitializeComponent();
        }
        int value1, value2;
        char sign;

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
        private void one_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "1";

        }

      

        private void two_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "2";
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "4";
        }


        private void three_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "3";
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "5";
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "6";
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "7";
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "8";
        }

    

        private void nine_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "9";
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "0";
        }


        //For operaton button 

        //for addition button 

        private void add_btn_Click(object sender, EventArgs e)
        {
            value1= int.Parse(value_disply.Text);
            sign = '+';
            value_disply.Text = ""; 


        }

        //for subration
        private void minus_btn_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(value_disply.Text);
            sign = '-';
            value_disply.Text = "";

        }

        //for multiplication 
        private void multiply_btn_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(value_disply.Text);
            sign = 'X';
            value_disply.Text = "";

        }

       

        //for division
        private void divide_btn_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(value_disply.Text);
            sign = '/';
            value_disply.Text = "";

        }

     
        //For equal to 
        private void equal_btn_Click(object sender, EventArgs e)
        {
            value2= int.Parse(value_disply.Text);
            int result;
            if (sign=='+')
            {
                result = value1 + value2;
                value_disply.Text = result.ToString(); 
            }
            else if (sign == '-')
            {
                result = value1 - value2;
                value_disply.Text = result.ToString();
            }
            else if (sign == 'X')
            {
                result = value1 * value2;
                value_disply.Text = result.ToString();
            }
            else if (sign == '/')
            {
                result = value1 / value2;
                value_disply.Text = result.ToString();
            }
            else
            {
                value_disply.Text = "Syntax Error";
            }
        }

        private void Dipu_Calculator_Click(object sender, EventArgs e)
        {

        }



        //For clear button
        private void clear_btn_Click(object sender, EventArgs e)
        {
            value_disply.Text = value_disply.Text + "";
            value_disply.Clear();
        }


        //Exit 
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
