﻿using System;

using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool oprPressed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            if ((label.Text == "0")||oprPressed)
                label.Text = String.Empty;

            Button b = (Button)sender;
            label.Text += b.Text;
            hisLabel.Text += b.Text;
        }

        private void btnClrEvr_Click(object sender, EventArgs e)
        {
            label.Text = "0";
            hisLabel.Text = "";
        }

        private void oprClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            hisLabel.Text += b.Text;
            value = double.Parse(label.Text);
            oprPressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (operation)
            {

                case "+":
                    label.Text = (value + Double.Parse(label.Text)).ToString();
                    break;

                case "-":
                    label.Text = (value - Double.Parse(label.Text)).ToString();
                    break;

                case "*":
                    label.Text = (value * Double.Parse(label.Text)).ToString();
                    break;

                case "/":
                    label.Text = (value / Double.Parse(label.Text)).ToString();
                    break;

                default:
                    oprPressed = false;
                    break;

                    
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            label.Text = "0";

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if ((label.Text == "0") || (oprPressed))
            {
               // label.Clear();

            }
            Button btn = (Button)sender;
            oprPressed = false;
            if (btn.Text == ".")
            {
                if (!label.Text.Contains("."))
                    label.Text = label.Text + btn.Text;
                label1.Text += btn.Text;

            }
            else
            {
                label.Text += btn.Text;
                label1.Text += btn.Text;
            }
        }

        private void btnPlmin_Click(object sender, EventArgs e)
        {
            
        }
    }
}