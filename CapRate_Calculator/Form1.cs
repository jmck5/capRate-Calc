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
        private float GetFloatFromNUDobject(NumericUpDown o) {
            return (float)o.Value;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //Get actual number from NumericUpdown Objects First
            float cost = GetFloatFromNUDobject(upfrontCost);
            float r = GetFloatFromNUDobject(baseRate);
            int period = (int) GetFloatFromNUDobject(term);
            float newValue = CalcYearlyFee(cost, r, period);
            string newValueToString = String.Format("{0:0.00}", newValue);
            string newString = "$" + newValueToString;
            answer.Text = newString;


        }

        //Commented out, since difficult to write unit test for method that takes private NumericUpDown parameters
        //overload method of below equation since form numerical values can't be cast as float
        //public double Equation(NumericUpDown cost, NumericUpDown rate, NumericUpDown term)
        //{
        //    double a;
        //    float rateAsMultiple = (float) (1 + (rate.Value / 100));
        //    //lifeTimeCost not yet adjusted for interest on received payments
        //    double lifeTimeCost = (double)cost.Value *  Math.Pow((float)rateAsMultiple, (int) term.Value);
        //    a = lifeTimeCost / (double) term.Value;
        //    return a;
        //}

        //Calculates average cost per year, not taking into account interest on money received
        public float CalcYearlyFee(float cost, float rate, int term) {
            float annualFee;
            float ratio = 1 + (rate / 100);
            double requiredReturn = ((ratio - 1) * Math.Pow(ratio, term)) / (Math.Pow(ratio, term) - 1);
            //lifeTimeCost not yet adjusted for interest on received payments
            annualFee = cost * (float)requiredReturn;
            return annualFee;
        }
    }
}
