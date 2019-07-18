using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        double result;
        float weight, height;
        public BMICalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calculate the BMI when the button Calculate BMI is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (ValidateEntries())
            {
                // calculates BMI based on the measure system selected
                if (MetricRadioButton.Checked)
                {
                    result = weight / (height * height);
                }
                else
                {
                    result = weight * 703 / (height * height);
                }
                ShowResults(result);
            }
        }

        private void ShowResults(double result)
        {
            // show the result and changes the progress bar
            ResultLabel.Text = result.ToString("0.00");
            if (result > 30)
            {
                ResultProgressBar.Value = 100;
                ResultProgressBar.ForeColor = Color.FromArgb(246, 12, 12);
                ResultDescription.Text = "Obese";
            }
            else
            {
                if (result > 25)
                {
                    ResultProgressBar.Value = 75;
                    ResultProgressBar.ForeColor = Color.FromArgb(255, 153, 51);
                    ResultDescription.Text = "Overweight";
                }
                else
                {
                    if (result > 18.5)
                    {
                        ResultProgressBar.Value = 50;
                        ResultProgressBar.ForeColor = Color.FromArgb(0, 204, 0);
                        ResultDescription.Text = "Normal";
                    }
                    else
                    {
                        ResultProgressBar.Value = 25;
                        ResultProgressBar.ForeColor = Color.FromArgb(255, 255, 102);
                        ResultDescription.Text = "Underweight";
                    }
                }
            }
        }

        /// <summary>
        /// Reset the screen when the reset button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            MetricRadioButton.Checked = true;
            ResultProgressBar.Value = 0;
            ResultLabel.Text = "";
            ResultDescription.Text = "";
            WeightInput.Text = string.Empty;
            HeightInput.Text = string.Empty;
        }

        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Application Exception: " + exception.Message);
            }
        }

        private void WeightInput_Enter(object sender, EventArgs e)
        {
            if (WeightInput.Text == "invalid weight")
            {
                WeightInput.Text = "";
            }
        }

        private void HeightInput_Enter(object sender, EventArgs e)
        {
            if (HeightInput.Text == "invalid height")
            {
                HeightInput.Text = "";
            }
        }

        private bool ValidateEntries()
        {
            bool isValid = true;
            try
            {
                float.TryParse(WeightInput.Text, out weight);
            }
            catch (Exception)
            {
                WeightInput.Text = "invalid weight";
                isValid = false;
            }
            try
            {
                float.TryParse(HeightInput.Text, out height); 
            }
            catch (Exception)
            {
                HeightInput.Text = "invalid height";
                isValid = false;
            }
            // check values entered
            if (weight == 0)
            {
                WeightInput.Text = "invalid weight";
                isValid = false;
            }
            if (height == 0)
            {
                HeightInput.Text = "invalid height";
                isValid = false;
            }
            return isValid;
        }
    }
}
