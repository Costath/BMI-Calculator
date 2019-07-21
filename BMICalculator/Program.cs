using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculatorForm());
        }
    }
}
