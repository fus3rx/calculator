using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label.Text += "1";
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            label.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            label.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            label.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            label.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            label.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            label.Text= ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            label.Text += "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            label.Text += "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            label.Text += "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            label.Text += "/";
        }

        private void btnPlmin_Click(object sender, EventArgs e)
        {
            label.Text += "±";
        }

        private void btnBspc_Click(object sender, EventArgs e)
        {
            
    }

        private void btnClr_Click(object sender, EventArgs e)
        {
            label.Text = " ";
        }

        private void btnClrEvr_Click(object sender, EventArgs e)
        {
            label.Text = string.Empty;
        }
    }
    }