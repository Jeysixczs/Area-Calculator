using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Calculator
{
    public partial class Form1 : Form
    {
        string nulls = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrectangle_Click(object sender, EventArgs e)
        {
            if (nulls == txtlength.Text || nulls == txtwidth.Text)
            {
                MessageBox.Show("Please enter a value.");
                return;
            }


            double lengths = Convert.ToDouble(txtlength.Text);
            double widths = Convert.ToDouble(txtwidth.Text);


            Calculator calculate = new Calculator();

            double result = calculate.CalculateArea(lengths, widths);
            txtrecent.Text = result.ToString();
            listresult.Items.Add("The are of Reactangle is " +result);
        }

        private void btncircle_Click(object sender, EventArgs e)
        {

            if (nulls == txtradius.Text)
            {
                MessageBox.Show("Please enter a value.");
                return;
            }

            double radiuss = Convert.ToDouble(txtradius.Text);
            Calculator calculator = new Calculator();

            double result = calculator.CalculateArea(radiuss);
            txtrecent.Text = result.ToString();
            listresult.Items.Add("The are of Circle is " + result);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbase.Text = "";
            txtheight.Text = "";
            txtlength.Text = "";
            txtradius.Text = "";
            txtwidth.Text = "";
        }

        private void btntriangle_Click(object sender, EventArgs e)
        {                           

            if (nulls == txtbase.Text || nulls == txtheight.Text)
            {
                MessageBox.Show("Please enter a value.");
                return;
            }

            double bases = Convert.ToDouble(txtbase.Text);
            double heights = Convert.ToDouble(txtheight.Text);
            bool istriangle = true;
            Calculator calulate = new Calculator();

            double result = calulate.CalculateArea(bases, heights, istriangle);
            txtrecent.Text = result.ToString();
            listresult.Items.Add("The are of Triangle is " +result);
        }
    }
}
