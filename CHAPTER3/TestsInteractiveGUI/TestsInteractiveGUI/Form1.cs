//Filename TestsInteractiveGUI
//Written by Zach Scroggins
//Written on September 13, 2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    public partial class TestScoreAverage : Form
    {
        public TestScoreAverage()
        {
            InitializeComponent();
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(test1TextBox.Text);
            int num2 = Convert.ToInt32(test2TextBox.Text);
            int num3 = Convert.ToInt32(test3TextBox.Text);
            int num4 = Convert.ToInt32(test4TextBox.Text);
            int num5 = Convert.ToInt32(test5TextBox.Text);

            double average = (num1 + num2 + num3 + num4 + num5) / 5.00;

            averageLabel.Text = String.Format("Your average test score is {0}", average.ToString("F2"));
        }
    }
}
