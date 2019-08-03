using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapRate_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double newValue = Equation(upfrontCost, baseRate, term);
            string newValueToString = String.Format("{0:0.00}", newValue);
            string newString = "$" + newValueToString;
            answer.Text = newString;


        }

        //overload method of below equation since form numerical values can't be cast as float
        protected double Equation(NumericUpDown cost, NumericUpDown rate, NumericUpDown term)
        {
            double a;
            float rateAsMultiple = (float) (1 + (rate.Value / 100));
            //lifeTimeCost not yet adjusted for interest on received payments
            double lifeTimeCost = (double)cost.Value *  Math.Pow((float)rateAsMultiple, (int) term.Value);
            a = lifeTimeCost / (double) term.Value;
            return a;
        }

        //Calculates average cost per year, not taking into account interest on money received
        protected float Equation(float cost, float rate, int term) {
            float a;
            float rateAsMultiple = 1 + (rate / 100);
            //lifeTimeCost not yet adjusted for interest on received payments
            float lifeTimeCost = cost * (float) Math.Pow(rateAsMultiple, term);
            a = lifeTimeCost / term;
            return a;
        }
    }
}
