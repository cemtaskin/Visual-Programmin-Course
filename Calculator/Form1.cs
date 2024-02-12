using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form //partial : our class defination is located in two or more files
    {
        public Form1() //this is default constructor. It executes when we create a new object from Form like this - > new Form1(); 
        {
            InitializeComponent();
        }


        public Form1(DateTime dateTime) //this is constructor with one parameter.It executes when we create a new object from Form like this - > new Form1(DateTimeValue); 
        {
            InitializeComponent();
            this.Text = dateTime.ToString();
        }

        private void btnHello_MouseHover(object sender, EventArgs e)
        {
            this.Text = "Mouse is over our button";
        }

        private void btnHello_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse is not over our button";
        }

        private void btnNewButton_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString());
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked button");
        }
    }
}
