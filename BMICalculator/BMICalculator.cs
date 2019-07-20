using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        // holds the actual TextBox selected for input (HeightTextBox or WeightTextBox)
        TextBox selectedTextBox;
        // decimalPresent controls the presence of a '.' in the BMITextBox.Text
        bool decimalPresent = false;

        private void ResetScaleColors()
        {
            UnderweightLabel1.BackColor = SystemColors.Control;
            UnderweightLabel2.BackColor = SystemColors.Control;
            NormalLabel1.BackColor = SystemColors.Control;
            NormalLabel2.BackColor = SystemColors.Control;
            OverweightLabel1.BackColor = SystemColors.Control;
            OverweightLabel2.BackColor = SystemColors.Control;
            ObeseLabel1.BackColor = SystemColors.Control;
            ObeseLabel2.BackColor = SystemColors.Control;
        }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }
            
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            selectedTextBox = HeightTextBox;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (selectedTextBox.Text != "0" && selectedTextBox.Text != "")
            {
                selectedTextBox.Text += "0";

            }
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "8";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "9";
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (selectedTextBox.Text != "" && decimalPresent == false)
            {
                selectedTextBox.Text += ".";
                decimalPresent = true;
            }
            else if (selectedTextBox.Text == "")
            {
                selectedTextBox.Text += "0.";
                decimalPresent = true;
            }
            
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTextBox.Text.Substring(selectedTextBox.Text.Length - 1) == ".")
                {
                    decimalPresent = false;
                }

                selectedTextBox.Text = selectedTextBox.Text.Substring(0, selectedTextBox.Text.Length - 1);

                if (selectedTextBox.Text == "0")
                {
                    selectedTextBox.Text = "";
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                selectedTextBox.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double BMI;

            BMITextBox.Font = new Font("Microsoft Sans Serif", 20);
            try
            {
                BMI = double.Parse(WeightTextBox.Text) / Math.Pow(double.Parse(HeightTextBox.Text), 2.0);

                if (ImperialRadioButton.Checked)
                {
                    BMI *= 703;
                }

                ResetScaleColors();
                if (BMI < 18.5)
                {
                    UnderweightLabel1.BackColor = Color.LightCoral;
                    UnderweightLabel2.BackColor = Color.LightCoral;
                }
                else if (BMI >= 18.5 && BMI <= 24.9)
                {
                    NormalLabel1.BackColor = Color.LawnGreen;
                    NormalLabel2.BackColor = Color.LawnGreen;
                }
                else if (BMI >= 25 && BMI <= 29.9)
                {
                    OverweightLabel1.BackColor = Color.LightCoral;
                    OverweightLabel2.BackColor = Color.LightCoral;
                }
                else if (BMI >= 30)
                {
                    ObeseLabel1.BackColor = Color.LightCoral;
                    ObeseLabel2.BackColor = Color.LightCoral;
                }

                BMITextBox.Text = BMI.ToString("f1");
                ButtonsTableLayoutPanel.Visible = false;
                BMIScaleTableLayoutPanel.Visible = true;

            }
            catch (FormatException)
            {
                BMITextBox.Font = new Font("Microsoft Sans Serif", 11);
                BMITextBox.Text = "Invalid values";
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void HeightTextBox_Enter(object sender, EventArgs e)
        {
            selectedTextBox = (TextBox)sender;
            BMIScaleTableLayoutPanel.Visible = false;
            ButtonsTableLayoutPanel.Visible = true;
        }

        private void WeightTextBox_Enter(object sender, EventArgs e)
        {
            selectedTextBox = (TextBox)sender;
            BMIScaleTableLayoutPanel.Visible = false;
            ButtonsTableLayoutPanel.Visible = true;
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked)
            {
                HeightUnit.Text = "in";
                WeightUnit.Text = "lb";

                try
                {
                    HeightTextBox.Text = $"{double.Parse(HeightTextBox.Text) * 39.37:f2}";
                    WeightTextBox.Text = $"{double.Parse(WeightTextBox.Text) * 2.20462:f2}";
                }
                catch (FormatException)
                {
                    HeightTextBox.Text = "";
                    WeightTextBox.Text = "";
                    decimalPresent = false;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked)
            {
                HeightUnit.Text = "m";
                WeightUnit.Text = "kg";
                try
                {
                    HeightTextBox.Text = $"{double.Parse(HeightTextBox.Text) / 39.37:f2}";
                    WeightTextBox.Text = $"{double.Parse(WeightTextBox.Text) / 2.20462:f2}";
                }
                catch (FormatException)
                {
                    HeightTextBox.Text = "";
                    WeightTextBox.Text = "";
                    decimalPresent = false;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
