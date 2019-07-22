using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Background picture source: https://livewellcolorado.org/healthy-living/360-gut-check/bmi-calculator/

namespace BMICalculator
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.BMIForm.Show();
            Hide();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
