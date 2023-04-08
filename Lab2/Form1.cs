// Lab 2
// Cis 199-50
// Due: 09/19/2021
// By: S5034

// This program shows tip amount of a given meal price.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) // Execute function when user clicks the "Calculate Tip" button.
        {
            //Get User Input
            double mealPrice; // The price of meal inputted by user.
            mealPrice = Convert.ToDouble(inputTextBox.Text); // Get user input

            //Calculate Tip
            double lowValue; // 15% Tip
            lowValue = mealPrice * 0.15; // Calculate 15% of meal
            lowValue = Math.Ceiling(lowValue * 100)/100; // Round up to two decimal places

            double middleValue; // 18% Tip
            middleValue = mealPrice * 0.18; // Calculate 18% of meal
            middleValue = Math.Ceiling(middleValue * 100)/100; // Round up to two decimal places

            double highValue; // 20% Tip
            highValue = mealPrice * 0.20; // Calculate 20% of meal
            highValue = Math.Ceiling(highValue * 100)/100; // Round up to two decimal places

            //Display Tip
            lowTextBox.Text = lowValue.ToString("C2"); // Assigning tip to the 15% output label with currency formatting.
            middleTextBox.Text = middleValue.ToString("C2"); // Assigning tip to the 18% output label with currency formatting.
            highTextBox.Text = highValue.ToString("C2"); // Assigning tip to the 20% output label with currency formatting.

        }
    }
}
