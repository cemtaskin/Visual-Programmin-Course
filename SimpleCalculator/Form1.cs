using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
       
        public int FirstNumber { get {
                int r = 0;

                try
                {
                    r = Convert.ToInt32(txtFirstNumber.Text);
                }
                catch { }

                return r;
            } 
        }

        public int SecondNumber
        {
            get
            {
                int r = 0;

                try
                {
                    r = Convert.ToInt32(txtSecondNumber.Text);
                }
                catch { }

                return r;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperation (object sender,EventArgs e)
        {
            int result = 0;
            Button button = (Button)sender;
            switch (Convert.ToInt32(button.Tag))
            {
                case 1:
                    result = FirstNumber + SecondNumber;
                    break;
                case 2:
                    result = FirstNumber - SecondNumber;
                    break;
                case 3:
                    result = FirstNumber * SecondNumber;
                    break;
                case 4:
                    result = FirstNumber / SecondNumber;
                    break;
            }
            lblResult.Text = result.ToString();
        }
    }
}
