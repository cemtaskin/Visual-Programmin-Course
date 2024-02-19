using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstNumber;
        int secondNumber; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {
                firstNumber = Convert.ToInt32(txtFirstNumber.Text);
            } catch { }

            try
            {
                secondNumber = Convert.ToInt32(txtSecondNumber.Text);
            }
            catch { }


            lblResult.Text = (firstNumber + secondNumber).ToString();
        }
    }
}
