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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text =txtDisplay.Text+ button1.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button9.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        
        double total1 = 0;
        double total2 = 0;

        bool plusButtonClicked = false;
        bool minusButtonClicked=false;
        bool multiplyButtonClicked = false;
        bool devideButtonClicked = false;


     
        private void btnPlus_Click(object sender, EventArgs e)
        {
               total1 = total1 + double.Parse(txtDisplay.Text);
               txtDisplay.Clear();

               plusButtonClicked = true;
               minusButtonClicked = false;
               multiplyButtonClicked = false;
               devideButtonClicked = false;
    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked == true) {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }

            else if  (minusButtonClicked == true) {

                total2 = total1 - double.Parse(txtDisplay.Text);

            }

            else if (devideButtonClicked==true) {
            
                total2=total1 / double.Parse(txtDisplay.Text);
            }
            else if (multiplyButtonClicked==true) {
            
                total2=total1*double.Parse(txtDisplay.Text);

            }

            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        

        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            multiplyButtonClicked = false; 
            devideButtonClicked = false;
            plusButtonClicked = false;
            minusButtonClicked = true;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            multiplyButtonClicked = true;
            devideButtonClicked = false;
            plusButtonClicked = false;
            minusButtonClicked = false;
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            multiplyButtonClicked = false;
            devideButtonClicked = true;
            plusButtonClicked = false;
            minusButtonClicked = false;
        }

    
    }}

