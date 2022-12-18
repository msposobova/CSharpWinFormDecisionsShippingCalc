using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Maryna Sposabava;
// Date: 16/11/2022;
// Assignment # 3;

namespace ShippingCalc
{
    public partial class frmShippingCalc : Form
    {
        public frmShippingCalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool isWeight = decimal.TryParse(txtWeight.Text, out decimal weight);
            if (!isWeight)
            {
                MessageBox.Show("Please enter a valid number in the weight box");
                txtWeight.Focus();
                txtWeight.SelectAll();
                return;
            }

            else if ((weight < 1) || (weight > 20))
            {
                MessageBox.Show("The weight must be between 1 and 20 kg.");

                txtWeight.Focus();
                txtWeight.SelectAll();
                return;
            }

            bool isDistance = decimal.TryParse(txtDistance.Text, out decimal distance);
            if (!isDistance)
            {
                MessageBox.Show("Please enter a valid number in the distance box");
                txtDistance.Focus();
                txtDistance.SelectAll();
                return;
            }

            else if ((distance < 10) || (distance > 3000))
            {
                MessageBox.Show("The distance must be between 10 and 3000 miles.");
                txtDistance.Focus();
                txtDistance.SelectAll();
                return;
            }

            if (weight <= 2)
            {
                decimal chargeLower2 = Math.Round(distance * 0.01m, 2);
                lblShippingCharge.Text = "$" + chargeLower2.ToString();
            }

            else if (weight <= 6)
            {
                decimal chargeLower6 = Math.Round(distance * 0.015m, 2);
                lblShippingCharge.Text = "$" + chargeLower6.ToString();
            }

            else if (weight <= 10)
            {
                decimal chargeLower10 = Math.Round(distance * 0.02m, 2);
                lblShippingCharge.Text = "$" + chargeLower10.ToString();
            }

            else if (weight <= 20)
            {
                decimal chargeLower20 = Math.Round(distance * 0.025m, 2);
                lblShippingCharge.Text = "$" + chargeLower20.ToString();
            }
        }
    }
}
