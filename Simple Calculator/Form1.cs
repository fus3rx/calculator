using System;

using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String opetion = "";
        bool operation = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            if (label.Text == "0")
                label.Text = String.Empty;

            Button b = (Button)sender;
            label.Text += b.Text;
        }

        private void btnClrEvr_Click(object sender, EventArgs e)
        {
            label.Text = "0";
        }

        private void oprClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            opetion = b.Text;
            value = double.Parse(label.Text);

        }
    }
}