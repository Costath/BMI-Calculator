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

/*
 * Author's name: Thales Costa
 * Author's student ID: 301035028
 * Professor: Tom Tsiliopoulos
 * Course: Programming 2
 * Date last modified: July 20th, 2019
 * 
 * Description: This software implements a BMI (Body Mass Index) Calculator. User selects the desired 
 * measurement system between Imperial and Metric, and inputs height and weight values. The BMI value 
 * is calculated and displayed in a specific box, and a BMI scale is shown, highlighted according to 
 * the calculated BMI value.
 * The user can perform another calculation by simply clicking on height and weight text boxes.
 */

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        // holds the actual TextBox selected for input (HeightTextBox or WeightTextBox)
        private TextBox _selectedTextBox;
        // decimalPresent controls the presence of a '.' in the BMITextBox.Text
        private bool _heightTextBoxHasDecimal = false;
        private bool _weightTextBoxHasDecimal = false;
        /// <summary>
        /// Resets the color of each label in BMIScaleTableLayoutPanel to system default
        /// </summary>
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
        /// <summary>
        /// Initializes the form
        /// </summary>
        public BMICalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sets the default _selectedTextBox to HeightTextBox on BMICalculatorForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            _selectedTextBox = HeightTextBox;
        }
        /// <summary>
        /// Appends "0" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (_selectedTextBox.Text != "0" && _selectedTextBox.Text != "")
            {
                _selectedTextBox.Text += "0";

            }
        }
        /// <summary>
        /// Appends "1" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            _selectedTextBox.Text += "1";
        }
        /// <summary>
        /// Appends "2" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            _selectedTextBox.Text += "2";
        }
        /// <summary>
        /// Appends "3" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            _selectedTextBox.Text += "3";
        }
        /// <summary>
        /// Appends "4" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            _selectedTextBox.Text += "4";
        }
        /// <summary>
        /// Appends "5" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            _selectedTextBox.Text += "5";
        }
        /// <summary>
        /// Appends "6" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            _selectedTextBox.Text += "6";
        }
        /// <summary>
        /// Appends "7" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            _selectedTextBox.Text += "7";
        }
        /// <summary>
        /// Appends "8" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            _selectedTextBox.Text += "8";
        }
        /// <summary>
        /// Appends "9" to _selectedTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            _selectedTextBox.Text += "9";
        }
        /// <summary>
        /// Appends "." to _selectedTextBox.Text if it was not added yet. If _selectedTextBox.Text is empty string, appends "0."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            // Checks which TextBox is selected (HeightTextBox or WeightTextBox)
            if (_selectedTextBox.Name == "HeightTextBox")
            {
                if (_selectedTextBox.Text != "" && _heightTextBoxHasDecimal == false)
                {
                    _selectedTextBox.Text += ".";
                    _heightTextBoxHasDecimal = true;
                }
                else if (_selectedTextBox.Text == "")
                {
                    _selectedTextBox.Text += "0.";
                    _heightTextBoxHasDecimal = true;
                }
            }
            else if (_selectedTextBox.Name == "WeightTextBox")
            {
                if (_selectedTextBox.Text != "" && _weightTextBoxHasDecimal == false)
                {
                    _selectedTextBox.Text += ".";
                    _weightTextBoxHasDecimal = true;
                }
                else if (_selectedTextBox.Text == "")
                {
                    _selectedTextBox.Text += "0.";
                    _weightTextBoxHasDecimal = true;
                }
            }
        }
        /// <summary>
        /// Deletes the last character of _selectedTextBox.Text if there is any
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Sets _decimalPresent to FALSE if the deleted character was a "."
                if (_selectedTextBox.Text.Substring(_selectedTextBox.Text.Length - 1) == ".")
                {
                    if (_selectedTextBox.Name == "HeightTextBox")
                    {
                        _heightTextBoxHasDecimal = false;
                    }
                    else if (_selectedTextBox.Name == "WeightTextBox")
                    {
                        _weightTextBoxHasDecimal = false;
                    }
                    
                }
                _selectedTextBox.Text = _selectedTextBox.Text.Substring(0, _selectedTextBox.Text.Length - 1);
                // Sets _selectedTextBox.Text to empty string if the remaing string is "0"
                if (_selectedTextBox.Text == "0")
                {
                    _selectedTextBox.Text = "";
                }
            }// Handles ArgumentOutOfRangeException when _selectedTextBox.Text is empty string and DelButton is pressed
            catch (ArgumentOutOfRangeException)
            {
                _selectedTextBox.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// Clears the form to initial status when ResetButton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            _heightTextBoxHasDecimal = false;
            _weightTextBoxHasDecimal = false;
            _selectedTextBox = HeightTextBox;
            BMIScaleTableLayoutPanel.Visible = false;
            ButtonsTableLayoutPanel.Visible = true;
            MetricRadioButton.Checked = false;
            ImperialRadioButton.Checked = true;
            BMITextBox.Font = new Font("Microsoft Sans Serif", 20);
            BMITextBox.Text = "";
        }
        /// <summary>
        /// Calculates the BMI value, writes the result in BMITextBox.Text and chebge the color of the BMI Scale accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            // Holds the calculated BMI value
            double BMI;
            // Makes sure BMITextBox.Font size is 20
            BMITextBox.Font = new Font("Microsoft Sans Serif", 20);
            try
            {
                if (double.Parse(WeightTextBox.Text) == 0 || double.Parse(HeightTextBox.Text) == 0)
                {
                    throw new FormatException();
                }
                // BMI value calculation
                BMI = double.Parse(WeightTextBox.Text) / Math.Pow(double.Parse(HeightTextBox.Text), 2.0);
                // Adjusts the calculated BMI value if Imperial units are chosen
                if (ImperialRadioButton.Checked)
                {
                    BMI *= 703;
                }
                // Resets the color of each label in BMIScaleTableLayoutPanel to system default
                ResetScaleColors();
                // Changes the BackColor of the specific label in BMIScaleTableLayoutPanel according to the calculated BMI value
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
                // Writes the calculated BMI value to BMITextBox.Text formated with 2 decimal places
                BMITextBox.Text = BMI.ToString("f1");
                // Hides ButtonsTableLayoutPanel
                ButtonsTableLayoutPanel.Visible = false;
                // Shows BMIScaleTableLayoutPanel
                BMIScaleTableLayoutPanel.Visible = true;
            }// Handles FormatException when WeightTextBox.Text or HeightTextBox.Text is empty string and the function tries to parse it
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
        /// <summary>
        /// When HeightTextBox is selected, sets _selectedTextBox to HeightTextBox, hides BMIScaleTableLayoutPanel and shows ButtonsTableLayoutPanel to receive next input value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_Enter(object sender, EventArgs e)
        {
            _selectedTextBox = (TextBox)sender;
            BMIScaleTableLayoutPanel.Visible = false;
            ButtonsTableLayoutPanel.Visible = true;
        }
        /// <summary>
        /// When WeightTextBox is selected, sets _selectedTextBox to WeightTextBox, hides BMIScaleTableLayoutPanel and shows ButtonsTableLayoutPanel to receive next input value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_Enter(object sender, EventArgs e)
        {
            _selectedTextBox = (TextBox)sender;
            BMIScaleTableLayoutPanel.Visible = false;
            ButtonsTableLayoutPanel.Visible = true;
        }
        /// <summary>
        /// When ImperialRadioButton is selected, changes HeightUnitLabel and WeightUnitLabel accordingly and converts the values in HeightTextBox.Text and WeightTextBox.Text to imperial system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // ImperialRadioButton.Checked needs to be verified to avoid running the actions also when deselecting the radio button
            if (ImperialRadioButton.Checked)
            {
                HeightUnitLabel.Text = "in";
                WeightUnitLabel.Text = "lb";

                try
                {
                    HeightTextBox.Text = $"{double.Parse(HeightTextBox.Text) * 39.37:f2}";
                    WeightTextBox.Text = $"{double.Parse(WeightTextBox.Text) * 2.20462:f2}";
                }
                catch (FormatException)
                {
                    HeightTextBox.Text = "";
                    WeightTextBox.Text = "";
                    _heightTextBoxHasDecimal = false;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        /// <summary>
        /// When ImperialRadioButton is selected, changes HeightUnitLabel and WeightUnitLabel accordingly and converts the values in HeightTextBox.Text and WeightTextBox.Text to metric system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // MetricRadioButton.Checked needs to be verified to avoid running the actions also when deselecting the radio button
            if (MetricRadioButton.Checked)
            {
                HeightUnitLabel.Text = "m";
                WeightUnitLabel.Text = "kg";
                try
                {
                    HeightTextBox.Text = $"{double.Parse(HeightTextBox.Text) / 39.37:f2}";
                    WeightTextBox.Text = $"{double.Parse(WeightTextBox.Text) / 2.20462:f2}";
                }
                catch (FormatException)
                {
                    HeightTextBox.Text = "";
                    WeightTextBox.Text = "";
                    _heightTextBoxHasDecimal = false;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        /// <summary>
        /// Closes the application when the close X is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
