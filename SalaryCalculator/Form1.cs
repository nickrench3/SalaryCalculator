using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double hourlyRate = Convert.ToDouble(hourlyTextBox.Text);
            double annualSalary = hourlyRate * 2080;


            salaryTextBox.Text = annualSalary.ToString();
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            hourlyTextBox.Clear();
            salaryTextBox.Clear();
        }
    }
}
